class Auto:
    def __init__(self, marca,modelo,anio,velocidad):
        self.marca = marca
        self.modelo = modelo
        self.anio = anio
        self.velocidad = 0
        
    def acelerar(self,kmh):
        self.velocidad += kmh
        
    def desacelerar(self,kmh):
        self.velocidad -= kmh
    
    def obtenerVelocidad(self):
        return self.velocidad