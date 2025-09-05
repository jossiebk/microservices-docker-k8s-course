# Microservicio.Libros

Microservicio de ejemplo para gestión de libros en .NET 8.

## Requisitos
- .NET 8 SDK <==

## Ejecución local

1. Clona el repositorio y navega a la carpeta del microservicio:
   ```
   git clone <url-del-repo>
   cd MicroServiciosDotnet/Microservicio.Libros
   ```

2. Restaura las dependencias:
   ```
   dotnet restore
   ```

3. Ejecuta el proyecto:
   ```
   dotnet run
   ```

El servicio estará disponible en la URL que indique la consola 

## Notas
- No se requieren pasos adicionales, a menos que el proyecto tenga configuraciones especiales (variables de entorno, bases de datos externas, etc).
- Para desarrollo, puedes modificar `appsettings.Development.json` según tus necesidades.

## Estructura principal
- `src/Controllers/` — Controladores API
- `src/Models/` — Modelos de datos
- `src/Services/` — Lógica de negocio
- `src/Data/` — Datos de ejemplo (JSON)