# Prueba Mike Puentes

Este software cumple con el proposito de ingresar con un usuario o crearlo y luego puede acceder a la ventana de asignación de vuelos. Solo existe un rol administrador,
se creó un usuario con herencia como se ve en la siguiente imagen, pero como no se le dio uso al campo adicional entonces se utiliza la clase de usuario :smile:.

![ER_Diagram](https://github.com/mikesneider/TestCarvajal/blob/main/Info/ER_DB.PNG)

Todos los campos en los que interviende el usuario se hace ingreso por parametros para evitar SQL Injection

![login](https://github.com/mikesneider/TestCarvajal/blob/main/Info/login.gif)

Finalmente el software crea nuevos vuelos y se van viendo actualizados en la tabla de la parte derecha.
La base de datos contiene la información de ciudades y aerolineas que serán cargadas en los ComboBox

![soft](https://github.com/mikesneider/TestCarvajal/blob/main/Info/App.gif)

De acuerdo a los requerimientos el desarrollo está separado en las 3 capas.

Si quieren ver el proyecto, es necesario tener instalado [VisualStudio](https://visualstudio.microsoft.com/es/vs/) y abrir el archivo "MichaelPuentesPruebaCarvajal.sln"
