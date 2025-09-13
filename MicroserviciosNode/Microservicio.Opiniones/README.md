# Microservicio Opiniones

Este microservicio gestiona las opiniones de los usuarios sobre productos o servicios.

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
GET    http://localhost:5202/api/resenas/libro/1
POST   http://localhost:5202/api/resenas
```

### Ejemplo de body para POST /api/resenas
```json
{
  "usuario": "Juan Perez",
  "comentario": "Muy buen libro",
  "calificacion": 5
}
```
