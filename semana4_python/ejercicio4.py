cat = input("Ingrese categoría (A/B/C): ").upper()
horas = float(input("Ingrese horas trabajadas: "))
anios = int(input("Ingrese años de servicio: "))

if cat == "A":
    tarifa = 33.50
elif cat == "B":
    tarifa = 29.40
elif cat == "C":
    tarifa = 26.70
else:
    print("Categoría inválida")
    exit()

# Condiciones anidadas para el bono
if anios <= 3:
    bono = 0.00
else:
    if anios <= 10:
        bono = 0.10
    elif anios <= 15:
        bono = 0.20
    else:
        bono = 0.30

sueldo_final = tarifa * horas * (1 + bono)
print(f"Sueldo: S/. {sueldo_final:.2f}")
