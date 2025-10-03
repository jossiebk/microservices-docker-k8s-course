const grpc = require('@grpc/grpc-js');
const protoLoader = require('@grpc/proto-loader');

const packageDef = protoLoader.loadSync("hello.proto", {});
const grpcObject = grpc.loadPackageDefinition(packageDef);
const client = new grpcObject.Greeter("localhost:50051", grpc.credentials.createInsecure());

const accion = "suma"; // Aqui pueden cambiar la accion para decidir cual usar.

if (accion === "hola") {
  client.SayHello({ name: "Jossie" }, (err, response) => {
    if (err) {
      console.error("Error:", err);
      return;
    }
    console.log("Respuesta del servidor:", response.message);
  });
} else if (accion === "suma") {
  client.Suma({ numero1: 5, numero2: 7 }, (err, response) => {
    if (err) {
      console.error("Error en suma:", err);
      return;
    }
    console.log("Resultado de la suma:", response.resultado);
  });
}