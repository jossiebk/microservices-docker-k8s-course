# Microservicio Usuarios

Este microservicio gestiona la información y autenticación de usuarios.

## Scripts principales
- `npm start`: Inicia el servidor.

## Estructura
- `routes/`: Rutas de la API
- `data/`: Archivos de datos
- `helper/`: Funciones auxiliares

## Requisitos
- Node.js
- npm

## Instalación
```bash
npm install
```

## Ejecución
```bash
npm start
```

## Endpoints de prueba

```
GET    http://localhost:5201/api/usuarios
GET    http://localhost:5201/api/usuarios/1
POST   http://localhost:5201/api/usuarios
DELETE http://localhost:5201/api/usuarios/1
```

### Ejemplo de body para POST /api/usuarios
```json
{
  "nombre": "Juan Perez",
  "email": "juan@example.com",
  "password": "123456"
}
```
