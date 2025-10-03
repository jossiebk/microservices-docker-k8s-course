const grpc = require('@grpc/grpc-js');
const protoLoader = require('@grpc/proto-loader');

const packageDef = protoLoader.loadSync("hello.proto", {});
const grpcObject = grpc.loadPackageDefinition(packageDef);
const greeter = grpcObject.Greeter;

function sayHello(call, callback) {
  console.log("llego una peticion al servidor con SayHello");
  // podemos darle mas logica
  callback(null, { message: "Hola " + call.request.name + " desde el servidor gRPC" });
}

function suma(call, callback) {
    console.log("llego una peticion al servidor con Suma");
    const { numero1, numero2 } = call.request;
    const resultado = numero1 + numero2;
    console.log(`Resultado de la suma: ${numero1} + ${numero2} = ${resultado}`);
    callback(null, { resultado });
}

const server = new grpc.Server();
server.addService(greeter.service, 
    { 
        SayHello: sayHello ,
        Suma : suma
    });

server.bindAsync("0.0.0.0:50051", grpc.ServerCredentials.createInsecure(), () => {
  server.start();
  console.log("El servidor gRPC esta corriendo en puerto 50051");
});
