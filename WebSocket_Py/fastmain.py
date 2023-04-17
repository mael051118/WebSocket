from fastapi import FastAPI, WebSocket

app = FastAPI()


@app.websocket('/')
async def echo(websocket: WebSocket):
    await websocket.accept()

    while true:
        data = await websocket.receive_text()
        print('message received:',data)
        await websocket.send_text(data + '/server')