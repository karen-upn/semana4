#Ejercicio 1: Descuento por compra minima
monto = float (input("Ingrese el monto de la compra: S/ "))

if monto >= 100:
    descuento = monto * 0.10
else:
    descuento = 0
total = monto - descuento

print("descuento aplicado: S/" , descuento)
print("Total a pagar: S/" , total)
