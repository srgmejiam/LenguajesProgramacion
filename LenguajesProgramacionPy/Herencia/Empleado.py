from Persona import Persona

class Empleado(Persona):
    def __init__(self,Nombre,Edad,Salario):
        Persona.__init__(self, Nombre, Edad)
        self.Salario = Salario