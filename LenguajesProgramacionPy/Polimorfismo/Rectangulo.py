from Figuras import Figura as Fig

class Rectangulo(Fig):
    def __init__(self,largo,ancho):
        self.largo = largo
        self.ancho = ancho
        
    def area(self):
        return self.ancho * self.largo