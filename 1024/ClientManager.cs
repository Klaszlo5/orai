class ClientManager:
    def __init__(self):
        self.clients = []

    def add_client(self, client):
        self.clients.append(client)
        print(f"Client {client.name} added successfully.")

    def remove_client(self, name):
        for client in self.clients:
            if client.name == name:
                self.clients.remove(client)
                print(f"Client {name} removed successfully.")
                return
        print(f"Client {name} not found.")

    def find_client(self, name):
        for client in self.clients:
            if client.name == name:
                return client
        print(f"Client {name} not found.")
        return None

    def list_clients(self):
        if not self.clients:
            print("No clients available.")
        else:
            for client in self.clients:
                print(client)

    def save_to_file(self, path):
        try:
            with open(path, 'w') as file:
                json_data = [client.__dict__ for client in self.clients]
                json.dump(json_data, file)
            print(f"Clients saved to {path} successfully.")
        except Exception as e:
            print(f"Error saving clients: {e}")

    def load_from_file(self, path):
        try:
            with open(path, 'r') as file:
                json_data = json.load(file)
                self.clients = [Client(**data) for data in json_data]
            print(f"Clients loaded from {path} successfully.")
        except Exception as e:
            print(f"Error loading clients: {e}")