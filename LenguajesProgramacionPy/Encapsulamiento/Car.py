from inspect import classify_class_attrs


class Car:
    def __init__(self, make, model, year, speed):
        self.__make = make
        self.__model = model
        self.__year = year
        self.__speed = 0

    def set_speed(self, speed):
        if speed >= 0:
            self.__speed = speed

    def get_speed(self):
        return self.__speed

    def get_make(self):
        return self.__make

    def get_model(self):
        return self.__model

    def get_year(self):
        return self.__year


    def EjemploEncapsulamiento():
        # Creación de un objeto de la clase Car
        my_car = Car("Toyota", "Camry", 2020, 0)

        # Cambiando la velocidad a 80
        my_car.set_speed(80)

        # Imprimiendo la velocidad actual
        print("La velocidad actual es:", my_car.get_speed())
