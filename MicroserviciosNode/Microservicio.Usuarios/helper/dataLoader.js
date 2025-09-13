const fs = require("fs");
const path = require("path");

const dataPath = path.join(__dirname, "../data/usuarios.json");

function cargarUsuarios(){
    try{
        const rawData = fs.readFileSync(dataPath);
        const usuarios = JSON.parse(rawData);
        console.log("usuarios cargados: ", usuarios.length);
        return usuarios;
    }catch(err){
        console.log("No se pudo cargar el archivo usuarios.json");
        return [];
    }
}

module.exports = {cargarUsuarios}