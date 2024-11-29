using Grpc.Net.Client;
using GrpcApp;

namespace GrpcClient;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Try to connect to the gRPC server on: https://localhost:7007");
        // Establish a connection to the server
        var channel = GrpcChannel.ForAddress("https://localhost:7007");

        // Create the client
        var client = new ItemService.ItemServiceClient(channel);

        // Make the gRPC call
        var response = await client.GetItemAsync(new ItemRequest { ItemId = 1 });

        // Display the result
        Console.WriteLine($"Item: {response.ItemName}, Price: {response.ItemPrice}");

        // Close the connection
        await channel.ShutdownAsync();

        Console.ReadLine();
    }
}

