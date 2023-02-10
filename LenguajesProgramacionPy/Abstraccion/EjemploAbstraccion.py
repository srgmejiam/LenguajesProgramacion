#import sys
#sys.path.append('C:\\Users\\Srg06\\Documents\\Python\\Abstraccion')

from Automovil import Auto
import time as t
import os as sy

def EjemploAbstraccion():

    car = Auto("Toyota","Tacoma",2020,0)

    for x in range(1,60):
        car.acelerar(1)
        print(str(car.obtenerVelocidad()) + " Km/h")
        t.sleep(0.3)
        sy.system("cls")
    
    for x in range(1,60):
        car.desacelerar(1)
        print(str(car.obtenerVelocidad()) + " Km/h")
        t.sleep(0.3)
        sy.system("cls")
    t.sleep(10)



