const express = require("express");
const router = express.Router();
const { cargarUsuarios } = require("../helper/dataLoader.js");

// Listado de usuarios cargados 
let usuarios = cargarUsuarios();

router.get("/", (req, res)=> {
    res.json(usuarios);
});

router.get("/:id", (req,res) =>{
    const usuario = usuarios.find(x => x.id === parseInt(req.params.id));
    if (!usuario) return res.status(404).json({mensaje: "Usuario no encontrado :( "});
    res.json(usuario);
})

// Crear nuevos usuarios.
router.post("/", (req, res)=>{
    const ultimoId = usuarios.length > 0 ? Math.max( ...usuarios.map( x => x.id)) : 1;
    const nuevo = {id: ultimoId + 1, ...req.body}
    usuarios.push(nuevo);
    res.status(201).json(nuevo);
});

// Eliminar usuarios.
router.delete("/:id", (req, res)=>{
    usuarios = usuarios.filter( x => x.id !== parseInt(req.params.id));
    res.json({ mensaje: "Eliminamos el usuario exitosamente :D "});
});

module.exports = router;