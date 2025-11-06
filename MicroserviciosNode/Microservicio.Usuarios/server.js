const express =  require("express");
const bodyParser = require("body-parser");
const usuariosRoutes = require("./routes/usuarios.js");

const app = express();
app.use(bodyParser.json());
app.use("/api/usuarios", usuariosRoutes);

app.get('/', (req, res) => {
  res.status(200).send('OK');
});

app.listen(5201, () => console.log("Microservicio de usuarios corriendo en el puerto 5201")); 