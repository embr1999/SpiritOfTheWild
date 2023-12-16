import socket
import struct

# Server configuration
host = '127.0.0.1'
port = 8001

# Create a socket object
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# Bind the socket to a specific address and port
server_socket.bind((host, port))

# Listen for incoming connections
server_socket.listen()

print(f"Server listening on {host}:{port}")

# Accept a connection from a client
client_socket, client_address = server_socket.accept()
print(f"Connection from {client_address}")

# Receive and decode float values
while True:
    # Assuming a 4-byte float, adjust the format string accordingly
    data = client_socket.recv(4)
    
    # Break the loop if no data is received
    if not data:
        break

    # Unpack the binary data to a float
    received_float = struct.unpack('!f', data)[0]
    print(f"Received float value
