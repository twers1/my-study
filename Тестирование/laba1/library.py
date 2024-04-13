from fastapi import FastAPI, HTTPException
from pydantic import BaseModel
from typing import List
from sqlalchemy import create_engine, Column, Integer, String, ForeignKey
from sqlalchemy.orm import sessionmaker
from sqlalchemy.ext.declarative import declarative_base

Base = declarative_base()


class Author(Base):
    __tablename__ = 'authors'

    id = Column(Integer, primary_key=True)
    name = Column(String)


class Category(Base):
    __tablename__ = 'categories'

    id = Column(Integer, primary_key=True)
    name = Column(String)


class Book(Base):
    __tablename__ = 'books'

    id = Column(Integer, primary_key=True)
    title = Column(String)
    author_id = Column(Integer, ForeignKey('authors.id'))
    category_id = Column(Integer, ForeignKey('categories.id'))
    release_year = Column(Integer)
    isbn = Column(String, unique=True)
    copies = Column(Integer)


class BookCreate(BaseModel):
    title: str
    author_id: int
    category_id: int
    release_year: int
    isbn: str
    copies: int


class AuthorCreate(BaseModel):
    name: str


class CategoryCreate(BaseModel):
    name: str


engine = create_engine('sqlite:///library.db')
Base.metadata.create_all(engine)
SessionLocal = sessionmaker(bind=engine)


def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()


def get_book_by_id(db, book_id: int):
    return db.query(Book).filter(Book.id == book_id).first()


def get_books_by_author(db, author_id: int):
    return db.query(Book).filter(Book.author_id == author_id).all()


def get_books_by_category(db, category_id: int):
    return db.query(Book).filter(Book.category_id == category_id).all()


def create_book(db, book: BookCreate):
    new_book = Book(**book.dict())
    db.add(new_book)
    db.commit()
    return new_book


def update_book(db, book_id: int, book: BookCreate):
    updated_book = db.query(Book).filter(Book.id == book_id).first()
    if not updated_book:
        raise HTTPException(status_code=404, detail='Book not found')
    for key, value in book.dict().items():
        setattr(updated_book, key, value)
    db.commit()
    return updated_book


def delete_book(db, book_id: int):
    book_to_delete = db.query(Book).filter(Book.id == book_id).first()
    if not book_to_delete:
        raise HTTPException(status_code=404, detail='Book not found')
    db.delete(book_to_delete)
    db.commit()


def create_author(db, author: AuthorCreate):
    new_author = Author(**author.dict())
    db.add(new_author)
    db.commit()
    return new_author


def update_author(db, author_id: int, author: AuthorCreate):
    updated_author = db.query(Author).filter(Author.id == author_id).first()
    if not updated_author:
        raise HTTPException(status_code=404, detail='Author not found')
    for key, value in author.dict().items():
        setattr(updated_author, key, value)
    db.commit()
    return updated_author


def delete_author(db, author_id: int):
    author_to_delete = db.query(Author).filter(Author.id == author_id).first()
    if not author_to_delete:
        raise HTTPException(status_code=404, detail='Author not found')
    db.delete(author_to_delete)
    db.commit()


def create_category(db, category: CategoryCreate):
    new_category = Category(**category.dict())
    db.add(new_category)
    db.commit()
    return new_category


def update_category(db, category_id: int, category: CategoryCreate):
    updated_category = db.query(Category).filter(Category.id == category_id).first()
    if not updated_category:
        raise HTTPException(status_code=404, detail='Category not found')
    for key, value in category.dict().items():
        setattr(updated_category, key, value)
    db.commit()
    return updated_category


def delete_category(db, category_id: int):
    category_to_delete = db.query(Category).filter(Category.id == category_id).first()
    if not category_to_delete:
        raise HTTPException(status_code=404, detail='Category not found')
    db.delete(category_to_delete)
    db.commit()


app = FastAPI()


@app.post('/books', response_model=Book)
def create_book_endpoint(book: BookCreate):
    with get_db() as db:
        return create_book(db, book)


@app.get('/books/{book_id}', response_model=Book)
def get_book_by_id_endpoint(book_id: int):
    with get_db() as db:
        book = get_book_by_id(db, book_id)
        if not book:
            raise HTTPException(status_code=404, detail='Book not found')
        return book


@app.put('/books/{book_id}', response_model=Book)
def update_book_endpoint(book_id: int, book: BookCreate):
    with get_db() as db:
        return update_book(db, book_id, book)


@app.delete('/books/{book_id}')
def delete_book_endpoint(book_id: int):
    with get_db() as db:
        delete_book(db, book_id)
        return {'detail': 'Book deleted'}


@app.get('/books/author/{author_id}', response_model=List[Book])
def get_books_by_author_endpoint(author_id: int):
    with get_db() as db:
        books = get_books_by_author(db, author_id)
        return books


@app.get('/books/category/{category_id}', response_model=List[Book])
def get_books_by_category_endpoint(category_id: int):
    with get_db() as db:
        books = get_books_by_category(db, category_id)
        return books


@app.post('/authors', response_model=Author)
def create_author_endpoint(author: AuthorCreate):
    with get_db() as db:
        return create_author(db, author)


@app.put('/authors/{author_id}', response_model=Author)
def update_author_endpoint(author_id: int, author: AuthorCreate):
    with get_db() as db:
        return update_author(db, author_id, author)


@app.delete('/authors/{author_id}')
def delete_author_endpoint(author_id: int):
    with get_db() as db:
        delete_author(db, author_id)
        return {'detail': 'Author deleted'}


@app.post('/categories', response_model=Category)
def create_category_endpoint(category: CategoryCreate):
    with get_db() as db:
        return create_category(db, category)


@app.put('/categories/{category_id}', response_model=Category)
def update_category_endpoint(category_id: int, category: CategoryCreate):
    with get_db() as db:
        return update_category(db, category_id, category)


@app.delete('/categories/{category_id}')
def delete_category_endpoint(category_id: int):
    with get_db() as db:
        delete_category(db, category_id)
        return {'detail': 'Category deleted'}
