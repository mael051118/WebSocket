from flask import Flask
from flask_sockets import Sockets

app = Flask(__name__)
sockets = Sockets(app)

@sockets.route('/')
def echo(ws):
    while not ws.closed:
        message = ws.received()
        print('message received:', message)
        ws.send(message + '/server')

from gevent import pywsgi
from geventwebsocket.handler import WebSocketHandler
server = pywsgi.WSGIServer(('',5000), app, handler_class=WebSocketHandler)
server.serve_forever()