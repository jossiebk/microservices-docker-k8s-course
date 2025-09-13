const fs = require("fs");
const path = require("path");

const dataPath = path.join(__dirname,"../data/resenas.json");

function cargarResenas(){
    try{
        const rawData = fs.readFileSync(dataPath);
        const resenas = JSON.parse(rawData);
        console.log("Reseñas cargadas desde JSON: ", resenas.length);
        return resenas;
    }catch(err){
        console.log("No se pudo cargar el archivo.");
        return [];
    }
}

module.exports = {cargarResenas}