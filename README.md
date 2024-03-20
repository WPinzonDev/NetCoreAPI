## API de Gestión de Productos

Esta es una API sencilla desarrollada en .NET Core para la gestión de productos. Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) en una base de datos SQL Server. La API está diseñada siguiendo los principios RESTful y utiliza Entity Framework Core para interactuar con la base de datos.

### Características Principales

- **Obtener Productos**: Permite obtener la lista completa de productos almacenados en la base de datos.
- **Obtener Producto por ID**: Permite obtener un producto específico mediante su identificador único.
- **Agregar Producto**: Permite agregar un nuevo producto a la base de datos.
- **Actualizar Producto**: Permite actualizar la información de un producto existente.
- **Eliminar Producto**: Permite eliminar un producto de la base de datos.

### Estructura del Proyecto

El proyecto se organiza en varias partes principales:

- **Controladores (Controllers)**: Contienen la lógica de enrutamiento y manejo de las solicitudes HTTP entrantes. En este caso, el controlador `ProductosController` define las acciones para las operaciones CRUD de productos.

- **Modelos (Models)**: Define la estructura de datos de los productos. En este caso, el modelo `Producto` contiene los campos típicos de un producto, como el ID, título, descripción, precio, etc.

- **Servicios (Services)**: Contiene la lógica de negocio para realizar operaciones en la base de datos. El servicio `ProductoService` encapsula las operaciones CRUD de productos utilizando Entity Framework Core.

- **Contexto de la Aplicación (AppDbContext)**: Define el contexto de la base de datos y la configuración de las tablas. Utiliza Entity Framework Core para mapear los modelos a tablas de la base de datos.

- **Configuración (Startup.cs)**: Define la configuración de la aplicación, incluyendo la configuración del servicio de base de datos, la inyección de dependencias y la configuración del middleware para la gestión de solicitudes HTTP.

### Requisitos Previos

- .NET Core SDK instalado en el entorno de desarrollo.
- Una instancia de SQL Server disponible para la base de datos.

### Configuración

Antes de ejecutar la aplicación, asegúrate de configurar correctamente la cadena de conexión a la base de datos en el archivo `appsettings.json`.

    json
    {
      "ConnectionStrings": {
        "DefaultConnection": "tu_cadena_de_conexion_aqui"
      }
    }


### Ejecución

Para ejecutar la aplicación, simplemente compila el proyecto y ejecuta el archivo ejecutable generado. Puedes utilizar el comando `dotnet run` desde la línea de comandos dentro del directorio del proyecto.

### Documentación de la API

La API está documentada automáticamente utilizando Swagger. Una vez que la aplicación está en ejecución, puedes acceder a la documentación de la API y probar los endpoints visitando `/swagger` en tu navegador web.

### Notas Adicionales

- Este es un proyecto de ejemplo y puede ser extendido según las necesidades del usuario.
- Asegúrate de cumplir con las prácticas de seguridad adecuadas al implementar esta API en un entorno de producción.
- Se recomienda realizar pruebas exhaustivas antes de utilizarla en un entorno de producción.

¡Disfruta utilizando esta API de gestión de productos en tus proyectos! Si tienes alguna pregunta o problema, no dudes en abrir un issue en este repositorio.
