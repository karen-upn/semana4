promedio = int(input("Ingrese el promedio (0-20): "))

if promedio < 0 or promedio > 20:
    print("Valor inválido")
elif promedio >= 0 and promedio <= 5:
    print("Deficiente")
elif promedio >= 6 and promedio <= 10:
    print("Regular")
elif promedio >= 11 and promedio <= 14:
    print("Bueno")
else:  # promedio entre 15 y 20
    print("Excelente")
