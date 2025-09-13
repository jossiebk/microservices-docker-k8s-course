const express = require("express");
const router = express.Router();
const { cargarResenas } = require("../helper/dataLoader");

// Lista de reseñas.
let resenas = cargarResenas();

// Obtener las reseñas de un libro.
router.get("/libro/:libroId", (req, res) =>{
    const resultado = resenas.filter( x => x.libroId === parseInt(req.params.libroId));
    res.json(resultado);
});

// Agregar reseñas
router.post("/", (req, res) =>{
    const resenaId = resenas.length > 0 ? Math.max(...resenas.map(x => x.id )) : 0;
    const nuevaResena = { id: resenaId + 1, ...req.body};
    resenas.push(nuevaResena);

    res.status(201).json(nuevaResena);
})

module.exports = router;