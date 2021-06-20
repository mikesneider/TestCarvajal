using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MichaelPuentesPruebaCarvajal.Modelos;

namespace MichaelPuentesPruebaCarvajal.Controles
{
    class cs_login
    {
        public static bool crearUsuario(string username, string password)
        {
            password = EncryptPassword(password);
            //verifico si el usuario existe
            var Usuarios = cs_users.getAllFromBD(username);
            if (Usuarios.Count > 0)
            {
                MessageBox.Show("Este Usuario ya existe", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cs_users.IngresarUsuario(username, password);
                MessageBox.Show("Nuevo usuario registrado\nIngresando...", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

        }
        public static bool VerificarLogin(string username,string password)
        {
            //encrypt password
            password = EncryptPassword(password);
            var Usuarios = cs_users.getAllFromBD(username, password);
            if (Usuarios.Count == 0)
                return false;
            else
            {
                cs_global.UsuarioActual = Usuarios[0];
                return true;
            }
                
        }
        private static string EncryptPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(password))
                  .Select(item => item.ToString("x2")));
            }
        }
        
    }
}
