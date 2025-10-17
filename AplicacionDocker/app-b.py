from flask import Flask

app = Flask(__name__)

@app.route("/mensaje", methods=["GET"])
def mensaje():
    return "Hola desde B"

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)