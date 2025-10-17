from flask import Flask
import requests

app = Flask(__name__)

@app.route("/procesar", methods=["GET"])
def procesar():
    # Ojo: aca es para la llamada usando la red de docker.
    respuesta_b = requests.get("http://servicio-b:5000/mensaje").text
    return respuesta_b + " y saludos desde A"

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)