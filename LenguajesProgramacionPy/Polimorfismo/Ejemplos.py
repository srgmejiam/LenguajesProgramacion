from Rectangulo import Rectangulo
from Circulo import Circulo
import time as t

def EjemploPolimorfismo():
    
    figura = Rectangulo(10, 20)
    print ("El área del rectangulo es: "+str(figura.area()))


    figura = Circulo(10)
    print("El área del Circulo es: "+ str(figura.area()))

    t.sleep(10)
