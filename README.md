# personapi-dotnet

## Descripción
Este proyecto es una aplicación web desarrollada en ASP.NET Core que permite gestionar información sobre personas, sus profesiones, estudios y teléfonos. Utiliza Entity Framework Core para la interacción con la base de datos y está diseñado con el patrón Modelo-Vista-Controlador (MVC). La aplicación se ejecuta en un contenedor de Docker que incluye SQL Server 2022 para la gestión de datos.

## Tabla de Contenidos
- [Tecnologías Utilizadas](#tecnologías-utilizadas)
- [Instalación](#instalación)
- [Configuración de la Base de Datos](#configuración-de-la-base-de-datos)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [EndPoints](#endpoints)
- [Uso de Swagger](#uso-de-swagger)
- [Contribución](#contribución)
- [Licencia](#licencia)

## Tecnologías Utilizadas
- **.NET 6.0**: Framework para la creación de la aplicación web.
- **SQL Server 2022**: Base de datos utilizada para almacenar la información.
- **Entity Framework Core**: ORM para manejar la base de datos.
- **Docker**: Para contenerizar la aplicación y la base de datos.
- **Swagger**: Para documentar y probar la API.

## Instalación
Para instalar el proyecto, se deben seguir los siguientes pasos:

1. **Clonar el repositorio**: Se abre una terminal y se ejecuta el siguiente comando para clonar el repositorio:
   ```bash
   git clone https://github.com/Larasalcedof/personapi-dotnet.git
Navegar al directorio del proyecto: Se cambia al directorio del proyecto clonado:
bash

2. **Navegar al directorio del proyecto:**
cd personapi-dotnet

3. **Instalar las dependencias necesarias:**
Se abre Visual Studio y se carga el proyecto. Luego, se va a la consola del Administrador de paquetes NuGet y se ejecutan los siguientes comandos para instalar las dependencias requeridas:
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools

4.**Configurar Docker:**
Se asegura que Docker esté instalado y en ejecución en la máquina. En la raíz del proyecto, se busca el archivo docker-compose.yml, que contiene la configuración necesaria para crear y ejecutar el contenedor de SQL Server. Luego, se abre una terminal en la raíz del proyecto y se ejecuta el siguiente comando para iniciar el contenedor:
docker-compose up -d
Esto iniciará el contenedor en segundo plano.

5.**Configurar la Base de Datos:**
La base de datos persona_db se crea automáticamente en el contenedor al ejecutar el proyecto. Se verifica que la cadena de conexión en appsettings.json esté configurada correctamente, la cual debería lucir así:
json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=persona_db;User Id=sa;Password=YourPassword;"
}
Se debe reemplazar YourPassword con la contraseña configurada para el usuario sa en SQL Server.

6.**Compilar el proyecto:**
 En Visual Studio, se selecciona Compilar > Compilar solución para asegurarse de que todo esté configurado correctamente.
 
7.**Ejecutar la aplicación:**
 Una vez que la solución se haya compilado sin errores, se puede ejecutar la aplicación. Se presiona F5 o se selecciona Iniciar depuración para lanzar la aplicación en el navegador.
 
8.**Acceder a Swagger**
Una vez que la aplicación esté en ejecución, se accede a la documentación de la API en http://localhost:5000/swagger (puede variar según la configuración de puertos).

## Estructura del Proyecto
El proyecto está organizado de la siguiente manera:

- **Controllers**: Contiene los controladores de la aplicación que manejan las solicitudes HTTP y devuelven las respuestas correspondientes.
- **Models**: Aquí se encuentran los modelos que representan las entidades y las interfaces para el acceso a datos.
  - **Entities**: Clases que representan las entidades del modelo de datos (Persona, Telefono, Profesion, Estudios).
  - **Interfaces**: Contiene las interfaces para los repositorios, definiendo los contratos para las operaciones de datos.
  - **Repositories**: Implementaciones de las interfaces que contienen la lógica para interactuar con la base de datos.
- **Views**: Carpeta que contiene las vistas de la aplicación, donde se presentan los datos al usuario.
- **appsettings.json**: Archivo de configuración que contiene las cadenas de conexión y otras configuraciones necesarias para la aplicación.
- **Program.cs**: Punto de entrada de la aplicación, donde se configuran los servicios y la canalización de solicitudes.

## EndPoints
A continuación se detallan los endpoints disponibles en la API:

### Persona
- `GET /api/persona`: Obtiene una lista de todas las personas.
- `GET /api/persona/{id}`: Obtiene una persona por su ID.
- `POST /api/persona`: Crea una nueva persona.
- `PUT /api/persona/{id}`: Actualiza una persona existente.
- `DELETE /api/persona/{id}`: Elimina una persona.

### Telefono
- `GET /api/telefono`: Obtiene una lista de todos los teléfonos.
- `GET /api/telefono/{id}`: Obtiene un teléfono por su ID.
- `POST /api/telefono`: Crea un nuevo teléfono.
- `PUT /api/telefono/{id}`: Actualiza un teléfono existente.
- `DELETE /api/telefono/{id}`: Elimina un teléfono.

### Profesion
- `GET /api/profesion`: Obtiene una lista de todas las profesiones.
- `GET /api/profesion/{id}`: Obtiene una profesión por su ID.
- `POST /api/profesion`: Crea una nueva profesión.
- `PUT /api/profesion/{id}`: Actualiza una profesión existente.
- `DELETE /api/profesion/{id}`: Elimina una profesión.

### Estudios
- `GET /api/estudios`: Obtiene una lista de todos los estudios.
- `GET /api/estudios/{id}`: Obtiene un estudio por su ID.
- `POST /api/estudios`: Crea un nuevo estudio.
- `PUT /api/estudios/{id}`: Actualiza un estudio existente.
- `DELETE /api/estudios/{id}`: Elimina un estudio.

## Uso de Swagger
Swagger se ha integrado en la aplicación para proporcionar una interfaz visual que facilita la prueba de los endpoints de la API. Para acceder a Swagger, se debe abrir el navegador y dirigirse a `http://localhost:5000/swagger` después de haber iniciado la aplicación. Desde allí, se puede explorar y probar cada uno de los endpoints definidos en la API.

## Contribución
Las contribuciones son bienvenidas. Si se desea contribuir al proyecto, se puede seguir estos pasos:
1. Realizar un fork del repositorio.
2. Crear una nueva rama (`git checkout -b feature/nueva-caracteristica`).
3. Realizar los cambios y hacer commit (`git commit -m 'Añadir nueva característica'`).
4. Hacer push a la rama (`git push origin feature/nueva-caracteristica`).
5. Crear un nuevo Pull Request.

## Licencia
Este proyecto está bajo la Licencia MIT. Para más detalles, consulte el archivo `LICENSE`.


