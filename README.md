# Prueba Mike Puentes

Este software cumple con el proposito de ingresar con un usuario, crear un usuario, solo existe un rol administrador.
Se creó un usuario con herencia como se ve en la siguiente imagen, pero como no se necesita el campo adicional, inicialmente funciona con usuario :smile:.

![ER_Diagram](https://github.com/mikesneider/TestCarvajal/blob/main/Info/ER_DB.PNG)

Todos los campos en los que interviende el usuario se hace ingreso por parametros para evitar SQL Injection

![login](https://github.com/mikesneider/TestCarvajal/blob/main/Info/login.gif)

Finalmente el software crea nuevos vuelos y se van viendo actualizados en la tabla de la parte derecha.
La base de datos contiene la información de ciudades y aerolineas que serán cargadas en los ComboBox

![soft](https://github.com/mikesneider/TestCarvajal/blob/main/Info/App.gif)

Si quieren ver el proyecto, es necesario tener instalado [VisualStudio](https://visualstudio.microsoft.com/es/vs/) y abrir el archivo "MichaelPuentesPruebaCarvajal.sln"
