const express =  require("express");
const bodyParser = require("body-parser");
const usuariosRoutes = require("./routes/resenas.js");

const app = express();
app.use(bodyParser.json());
app.use("/api/resenas", usuariosRoutes);

app.listen(5202, () => console.log("Microservicio de RESEÑAS corriendo en el puerto 5202")); 