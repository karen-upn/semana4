#Ejercicio2: Menu de opciones con match- case

print("//// Menu de operaciones////")
print("1. Calcular area de un circulo")
print("2. Calcular area de un cuadrado")
print("3. Calcular area de un triangulo")
print("4. Salir")

opcion =int(input("Seleccione una opcion: "))
match opcion:
    case 1:
        print("Hola, Bienvenido.")
    case 2:
        print(" Hoy es un gran dia. ")
    case 3:
        print("Hasta luego. ")
    case _:
        print("Opcion no valida. ")
    {}