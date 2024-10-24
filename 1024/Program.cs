import json

class CatalogSystem:
    class Product:
        def __init__(self, name, price, in_stock):
            self.name = name
            self.price = price
            self.in_stock = in_stock

        def __str__(self):
            stock_status = "Készleten" if self.in_stock else "Nincs készleten"
            return f"Termék: {self.name}, Ár: {self.price} USD, Állapot: {stock_status}"

    class Inventory:
        def __init__(self):
            self.products = []

        def add_product(self, product):
            self.products.append(product)
            print(f"A(z) {product.name} termék sikeresen hozzáadva.")

        def remove_product(self, name):
            for product in self.products:
                if product.name == name:
                    self.products.remove(product)
                    print(f"A(z) {name} termék sikeresen törölve.")
                    return
            print(f"A(z) {name} termék nem található.")

        def find_product(self, name):
            for product in self.products:
                if product.name == name:
                    return product
            print(f"A(z) {name} termék nem található.")
            return None

        def list_products(self):
            if not self.products:
                print("Nincsenek termékek a készletben.")
            else:
                for product in self.products:
                    print(product)

        def save_to_file(self, path):
            try:
                with open(path, 'w') as file:
                    json_data = [product.__dict__ for product in self.products]
                    json.dump(json_data, file)
                print(f"Termékek sikeresen mentve ide: {path}.")
            except Exception as e:
                print(f"Hiba a termékek mentésekor: {e}")

        def load_from_file(self, path):
            try:
                with open(path, 'r') as file:
                    json_data = json.load(file)
                    self.products = [CatalogSystem.Product(**data) for data in json_data]
                print(f"Termékek sikeresen betöltve innen: {path}.")
            except Exception as e:
                print(f"Hiba a termékek betöltésekor: {e}")
    
    # Ügyfél osztály
    class Client:
        def __init__(self, name, phone, email):
            self.name = name
            self.phone = phone
            self.email = email

        def __str__(self):
            return f"Ügyfél: {self.name}, Telefon: {self.phone}, Email: {self.email}"
    
    class ClientManager:
        def __init__(self):
            self.clients = []

        def add_client(self, client):
            self.clients.append(client)
            print(f"A(z) {client.name} ügyfél sikeresen hozzáadva.")

        def remove_client(self, name):
            for client in self.clients:
                if client.name == name:
                    self.clients.remove(client)
                    print(f"A(z) {name} ügyfél sikeresen törölve.")
                    return
            print(f"A(z) {name} ügyfél nem található.")

        def find_client(self, name):
            for client in self.clients:
                if client.name == name:
                    return client
            print(f"A(z) {name} ügyfél nem található.")
            return None

        def list_clients(self):
            if not self.clients:
                print("Nincsenek ügyfelek.")
            else:
                for client in self.clients:
                    print(client)

        def save_to_file(self, path):
            try:
                with open(path, 'w') as file:
                    json_data = [client.__dict__ for client in self.clients]
                    json.dump(json_data, file)
                print(f"Ügyfelek sikeresen mentve ide: {path}.")
            except Exception as e:
                print(f"Hiba az ügyfelek mentésekor: {e}")

        def load_from_file(self, path):
            try:
                with open(path, 'r') as file:
                    json_data = json.load(file)
                    self.clients = [CatalogSystem.Client(**data) for data in json_data]
                print(f"Ügyfelek sikeresen betöltve innen: {path}.")
            except Exception as e:
                print(f"Hiba az ügyfelek betöltésekor: {e}")
				


inventory = CatalogSystem.Inventory()
client_manager = CatalogSystem.ClientManager()

# Termékek hozzáadása
product1 = CatalogSystem.Product("Laptop", 1200, True)
product2 = CatalogSystem.Product("Okostelefon", 800, False)
inventory.add_product(product1)
inventory.add_product(product2)

# Termékek listázása
inventory.list_products()

# Termék keresése
print(inventory.find_product("Laptop"))

# Termék törlése
inventory.remove_product("Okostelefon")

# Termékek mentése és betöltése fájlból
inventory.save_to_file("products.json")
inventory.load_from_file("products.json")

# Ügyfelek hozzáadása
client1 = CatalogSystem.Client("John Doe", "123456789", "john@example.com")
client2 = CatalogSystem.Client("Jane Smith", "987654321", "jane@example.com")
client_manager.add_client(client1)
client_manager.add_client(client2)

# Ügyfelek listázása
client_manager.list_clients()

# Ügyfelek mentése és betöltése fájlból
client_manager.save_to_file("clients.json")
client_manager.load_from_file("clients.json")