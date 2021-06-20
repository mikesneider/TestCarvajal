
namespace MichaelPuentesPruebaCarvajal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label3 = new System.Windows.Forms.Label();
            this.LB_usuarioActual = new System.Windows.Forms.Label();
            this.TB_NumeroVuelo = new System.Windows.Forms.TextBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Vuelos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_CiudadDestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DT_Fecha = new System.Windows.Forms.DateTimePicker();
            this.DT_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.DT_HoraLlegada = new System.Windows.Forms.DateTimePicker();
            this.CB_Aerolinea = new System.Windows.Forms.ComboBox();
            this.CB_EstadoVuelo = new System.Windows.Forms.ComboBox();
            this.BTN_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Información de vuelo";
            // 
            // LB_usuarioActual
            // 
            this.LB_usuarioActual.AutoSize = true;
            this.LB_usuarioActual.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_usuarioActual.ForeColor = System.Drawing.Color.Black;
            this.LB_usuarioActual.Location = new System.Drawing.Point(12, 498);
            this.LB_usuarioActual.Name = "LB_usuarioActual";
            this.LB_usuarioActual.Size = new System.Drawing.Size(50, 19);
            this.LB_usuarioActual.TabIndex = 9;
            this.LB_usuarioActual.Text = "Usuario";
            // 
            // TB_NumeroVuelo
            // 
            this.TB_NumeroVuelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NumeroVuelo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TB_NumeroVuelo.Location = new System.Drawing.Point(197, 314);
            this.TB_NumeroVuelo.Name = "TB_NumeroVuelo";
            this.TB_NumeroVuelo.Size = new System.Drawing.Size(220, 27);
            this.TB_NumeroVuelo.TabIndex = 8;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ingresar.Location = new System.Drawing.Point(197, 434);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(218, 32);
            this.Btn_Ingresar.TabIndex = 7;
            this.Btn_Ingresar.Text = "Ingresar vuelo saliente";
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "PROGRAMAR VUELOS SALIENTES";
            // 
            // DGV_Vuelos
            // 
            this.DGV_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Vuelos.Location = new System.Drawing.Point(489, 122);
            this.DGV_Vuelos.Name = "DGV_Vuelos";
            this.DGV_Vuelos.Size = new System.Drawing.Size(290, 283);
            this.DGV_Vuelos.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ciudad de Origen";
            // 
            // CB_ciudadOrigen
            // 
            this.CB_ciudadOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_ciudadOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_ciudadOrigen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ciudadOrigen.FormattingEnabled = true;
            this.CB_ciudadOrigen.Location = new System.Drawing.Point(197, 128);
            this.CB_ciudadOrigen.Name = "CB_ciudadOrigen";
            this.CB_ciudadOrigen.Size = new System.Drawing.Size(220, 26);
            this.CB_ciudadOrigen.TabIndex = 16;
            this.CB_ciudadOrigen.SelectedIndexChanged += new System.EventHandler(this.CB_ciudadOrigen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(29, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ciudad de Destino";
            // 
            // CB_CiudadDestino
            // 
            this.CB_CiudadDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CB_CiudadDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_CiudadDestino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CiudadDestino.FormattingEnabled = true;
            this.CB_CiudadDestino.Location = new System.Drawing.Point(197, 166);
            this.CB_CiudadDestino.Name = "CB_CiudadDestino";
            this.CB_CiudadDestino.Size = new System.Drawing.Size(220, 26);
            this.CB_CiudadDestino.TabIndex = 18;
            this.CB_CiudadDestino.SelectedIndexChanged += new System.EventHandler(this.CB_CiudadDestino_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(124, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(82, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hora Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(67, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hora Llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(38, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Numero de Vuelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(97, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Aerolinea";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(45, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Estado de Vuelo";
            // 
            // DT_Fecha
            // 
            this.DT_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_Fecha.Location = new System.Drawing.Point(197, 204);
            this.DT_Fecha.Name = "DT_Fecha";
            this.DT_Fecha.Size = new System.Drawing.Size(220, 26);
            this.DT_Fecha.TabIndex = 25;
            // 
            // DT_HoraSalida
            // 
            this.DT_HoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DT_HoraSalida.Location = new System.Drawing.Point(197, 243);
            this.DT_HoraSalida.Name = "DT_HoraSalida";
            this.DT_HoraSalida.ShowUpDown = true;
            this.DT_HoraSalida.Size = new System.Drawing.Size(220, 26);
            this.DT_HoraSalida.TabIndex = 26;
            // 
            // DT_HoraLlegada
            // 
            this.DT_HoraLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_HoraLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DT_HoraLlegada.Location = new System.Drawing.Point(197, 273);
            this.DT_HoraLlegada.Name = "DT_HoraLlegada";
            this.DT_HoraLlegada.ShowUpDown = true;
            this.DT_HoraLlegada.Size = new System.Drawing.Size(220, 26);
            this.DT_HoraLlegada.TabIndex = 27;
            // 
            // CB_Aerolinea
            // 
            this.CB_Aerolinea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Aerolinea.FormattingEnabled = true;
            this.CB_Aerolinea.Location = new System.Drawing.Point(197, 351);
            this.CB_Aerolinea.Name = "CB_Aerolinea";
            this.CB_Aerolinea.Size = new System.Drawing.Size(220, 26);
            this.CB_Aerolinea.TabIndex = 28;
            // 
            // CB_EstadoVuelo
            // 
            this.CB_EstadoVuelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_EstadoVuelo.FormattingEnabled = true;
            this.CB_EstadoVuelo.Location = new System.Drawing.Point(197, 383);
            this.CB_EstadoVuelo.Name = "CB_EstadoVuelo";
            this.CB_EstadoVuelo.Size = new System.Drawing.Size(220, 26);
            this.CB_EstadoVuelo.TabIndex = 29;
            // 
            // BTN_salir
            // 
            this.BTN_salir.BackColor = System.Drawing.Color.Crimson;
            this.BTN_salir.FlatAppearance.BorderSize = 0;
            this.BTN_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_salir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_salir.ForeColor = System.Drawing.Color.White;
            this.BTN_salir.Location = new System.Drawing.Point(708, 484);
            this.BTN_salir.Name = "BTN_salir";
            this.BTN_salir.Size = new System.Drawing.Size(101, 32);
            this.BTN_salir.TabIndex = 30;
            this.BTN_salir.Text = "Salir";
            this.BTN_salir.UseVisualStyleBackColor = false;
            this.BTN_salir.Click += new System.EventHandler(this.BTN_salir_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 525);
            this.Controls.Add(this.BTN_salir);
            this.Controls.Add(this.CB_EstadoVuelo);
            this.Controls.Add(this.CB_Aerolinea);
            this.Controls.Add(this.DT_HoraLlegada);
            this.Controls.Add(this.DT_HoraSalida);
            this.Controls.Add(this.DT_Fecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_CiudadDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_ciudadOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_Vuelos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_usuarioActual);
            this.Controls.Add(this.TB_NumeroVuelo);
            this.Controls.Add(this.Btn_Ingresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Mike";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_usuarioActual;
        private System.Windows.Forms.TextBox TB_NumeroVuelo;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Vuelos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_ciudadOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_CiudadDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DT_Fecha;
        private System.Windows.Forms.DateTimePicker DT_HoraSalida;
        private System.Windows.Forms.DateTimePicker DT_HoraLlegada;
        private System.Windows.Forms.ComboBox CB_Aerolinea;
        private System.Windows.Forms.ComboBox CB_EstadoVuelo;
        private System.Windows.Forms.Button BTN_salir;
    }
}

