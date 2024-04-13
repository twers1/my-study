from sqlalchemy import create_engine, Column, Integer, String, ForeignKey
from sqlalchemy.orm import relationship, sessionmaker
from sqlalchemy.ext.declarative import declarative_base

engine = create_engine('sqlite:///test.db', echo=True)

Base = declarative_base()

session = sessionmaker(bind=engine)()


class Student(Base):
    __tablename__ = 'students'

    id = Column(Integer, primary_key=True)
    name = Column(String)
    age = Column(Integer)
    departament_id = Column(Integer, ForeignKey('departments.id'))
    department = relationship("Department")


class Department(Base):
    __tablename__ = 'departments'

    id = Column(Integer, primary_key=True)
    name = Column(String)
    students = relationship("Student")


Base.metadata.create_all(engine)

math_dept = Department(name="Математика")
physics_dept = Department(name="Физика")

student1 = Student(name='Иван', age=20, department=math_dept)
student2 = Student(name='Игорь', age=21, department=physics_dept)

session.add_all([math_dept, physics_dept, student1, student2])
session.commit()


# math_students = session.query(Student).join(Department).filter(Department.name == "Математика").all()
# physics_students = session.query(Student).join(Department).filter(Department.name == "Физика").all()
#
# print("Студенты математики:")
# for student in math_students:
#     print(f"Имя {student.name}, Возраст: {student.age}")
#
# print("\n Студенты физики:")
# for student in physics_students:
#     print(f"Имя {student.name}, Возраст: {student.age}")


def print_students_by_department(department_name):
    students = session.query(Student).join(Department).filter(Department.name == department_name).all()
    print(f"Студенты {department_name}:")
    for student in students:
        print(f"Имя {student.name}, Возраст: {student.age}")


print_students_by_department("Математика")
print("\n")
print_students_by_department("Физика")
