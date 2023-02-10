from Empleado import Empleado
import time as t

class EjemploHerencia():
    def Ejemplo():  
        empleado = Empleado("Juan", 36, 45000)
        print(empleado.Nombre)
        print(empleado.Edad)
        print(empleado.Salario)
        t.sleep(10)
