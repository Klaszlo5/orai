class Product:
    def __init__(self, name, price, in_stock):
        self.name = name
        self.price = price
        self.in_stock = in_stock

    def __str__(self):
        stock_status = "In stock" if self.in_stock else "Out of stock"
        return f"Product: {self.name}, Price: {self.price} USD, Status: {stock_status}"