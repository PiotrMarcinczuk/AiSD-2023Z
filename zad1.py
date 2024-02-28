from collections import defaultdict

with open('car.txt', 'r') as car:
    lines = car.readlines()

    indexTab = [0, 1, 2, 3, 4, 5, 6]
    columns = [[line.split()[i] for i in indexTab] for line in lines]
    symbole_decyzyjne = set()
    liczba_atrybutow = []
    liczba_obiektow = len(lines)
    licznik_symboli = defaultdict(int)
    for row in columns:
       symbole_decyzyjne.add(row[6])
       licznik_symboli[row[6]] += 1


    print("Symbole decyzyjne: ", symbole_decyzyjne)
    print("Liczba obiektów: ", liczba_obiektow)
    for symbol, ilosc in licznik_symboli.items():
        print(f"Symbol: {symbol}, ilość: {ilosc}")


num_attributes = len(lines[0].split()) - 1  # Liczba atrybutów w każdym wierszu

num_unique_values = []
for i in range(num_attributes):
    values = set()
    for line in lines:
        values.add(line.split()[i])  # Indeks `i` odpowiada za kolejne atrybuty
    num_unique_values.append(len(values))

print("Liczba różnych dostępnych wartości dla każdego atrybutu:", num_unique_values)

for i, num_values in enumerate(num_unique_values):
    values = set()
    for line in lines:
        values.add(line.split()[i])  # Indeks `i` odpowiada za kolejne atrybuty
    print(f"Atrybut {i+1}: {values}")

# 4a
import random
from collections import Counter

# Wczytanie danych
with open('car.txt', 'r') as file:
    lines = file.readlines()




