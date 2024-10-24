import json

class Inventory:
    def __init__(self):
        self.products = []

    def add_product(self, product):
        self.products.append(product)
        print(f"Product {product.name} added successfully.")

    def remove_product(self, name):
        for product in self.products:
            if product.name == name:
                self.products.remove(product)
                print(f"Product {name} removed successfully.")
                return
        print(f"Product {name} not found.")

    def find_product(self, name):
        for product in self.products:
            if product.name == name:
                return product
        print(f"Product {name} not found.")
        return None

    def list_products(self):
        if not self.products:
            print("No products available.")
        else:
            for product in self.products:
                print(product)

    def save_to_file(self, path):
        try:
            with open(path, 'w') as file:
                json_data = [product.__dict__ for product in self.products]
                json.dump(json_data, file)
            print(f"Products saved to {path} successfully.")
        except Exception as e:
            print(f"Error saving products: {e}")

    def load_from_file(self, path):
        try:
            with open(path, 'r') as file:
                json_data = json.load(file)
                self.products = [Product(**data) for data in json_data]
            print(f"Products loaded from {path} successfully.")
        except Exception as e:
            print(f"Error loading products: {e}")