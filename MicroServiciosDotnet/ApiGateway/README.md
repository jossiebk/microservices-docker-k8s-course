# ApiGateway

ApiGateway para el uso con los microservicios generados.

## Requisitos
- .NET 8 SDK <==

## Ejecución local

1. Clona el repositorio y navega a la carpeta del microservicio:
   ```
   git clone <url-del-repo>
   cd MicroServiciosDotnet/ApiGateway
   ```

2. Restaura las dependencias:
   ```
   dotnet restore
   ```

3. Ejecuta el proyecto con el puerto por defecto en launchSettings.json:
   ```
   dotnet run
   ```
   Ejecuta el proyecto con el puerto por defecto en ocelot.json:
   ```
   dotnet run --urls http://localhost:9595
   ```


El servicio estará disponible en la URL que indique la consola 

## Notas
- No se requieren pasos adicionales, a menos que el proyecto tenga configuraciones especiales (variables de entorno, bases de datos externas, etc).
- Para desarrollo, puedes modificar `appsettings.Development.json` según tus necesidades.

## Endpoints de prueba

perstamos
```
GET http://localhost:9595/api/gateway/prestamos
GET http://localhost:9595/api/gateway/prestamos/1
```

Libros
```
GET http://localhost:9595/api/gateway/libros
GET http://localhost:9595/api/gateway/libros/1
POST http://localhost:9595/api/gateway/libros
DELETE http://localhost:9595/api/gateway/libros/1
```

Usuarios
```
GET    http://localhost:9595/api/gateway/usuarios
GET    http://localhost:9595/api/gateway/usuarios/1
POST   http://localhost:9595/api/gateway/usuarios
DELETE http://localhost:9595/api/gateway/usuarios/1
```

Opiniones (Reseñas)
```
GET    http://localhost:9595/api/gateway/resenas/libro/1
POST   http://localhost:9595/api/gateway/resenas
```

