# Entrada de datos
parcial = int(input("Ingrese examen parcial: "))
final = int(input("Ingrese examen final: "))
p1 = int(input("Ingrese práctica 1: "))
p2 = int(input("Ingrese práctica 2: "))
p3 = int(input("Ingrese práctica 3: "))

# Calcular promedio de las 2 mejores prácticas
menor = min(p1, p2, p3)
prom_prac = (p1 + p2 + p3 - menor) / 2

# Calcular promedio final
prom_final = (parcial + final + prom_prac) / 3

# Mostrar resultados
print(f"Promedio de prácticas: {prom_prac:.2f}")
print(f"Promedio final: {prom_final:.2f}")

# Clasificación
if prom_final >= 18:
    print("Excelente")
elif prom_final >= 14:
    print("Bueno")
elif prom_final >= 10:
    print("Regular")
else:
    print("Deficiente")
