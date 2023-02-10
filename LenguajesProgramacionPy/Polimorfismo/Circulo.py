from Figuras import Figura as Fig

class Circulo(Fig):
    def __init__(self,radio):
        self.radio = radio
        
    def area(self):
        return 3.1416 * self.radio * self.radio
    