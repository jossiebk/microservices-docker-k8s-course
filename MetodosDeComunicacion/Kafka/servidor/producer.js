const { Kafka } = require("kafkajs");

const kafka = new Kafka({
  clientId: "my-app",
  brokers: ["localhost:9092"],
});

const producer = kafka.producer();

async function run() {
  await producer.connect();

  const msg = "Hola desde Kafka! :D " + new Date().toLocaleTimeString();
  await producer.send({
    topic: "test-topic",
    messages: [{ value: msg }],
  });

  console.log("Mensaje enviado ===> :", msg);

  await producer.disconnect();
}

run().catch(console.error);
