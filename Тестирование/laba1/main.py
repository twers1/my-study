# Задание 10. Апи

import uvicorn
from fastapi import FastAPI, status
from pydantic import BaseModel

app = FastAPI()


class Fruit(BaseModel):
    name: str


fruit = ["Яблоко", "Апельсин", "Мандарин", "Банан"]


@app.get("/", status_code=status.HTTP_200_OK)
async def get_fruit():
    return {"fruit": fruit}


@app.post("/", status_code=status.HTTP_201_CREATED)
async def add_fruit(fruit_item: str):
    fruit.append(fruit_item)
    return {"message": "Товар успешно добавлен"}


@app.put("/{fruit_id}", status_code=status.HTTP_200_OK)
async def change_fruit(fruit_id: int, new_fruit: Fruit):
    fruit[fruit_id] = new_fruit.name
    return {"message": "Товар успешно изменен"}


@app.delete('/{fruit_id}', status_code=status.HTTP_200_OK)
async def delete_fruit(fruit_id: int):
    fruit.pop(fruit_id)
    return {"message": "Товар успешно удален"}


if __name__ == "__main__":
    uvicorn.run("main:app", reload=True)