using Grpc.Net.Client; // Importing the Grpc.Net.Client namespace for working with gRPC client
using System; // Importing the System namespace for basic functionalities
using System.Threading.Tasks; // Importing the System.Threading.Tasks namespace for asynchronous programming

namespace GrpcClient // Defining the namespace for the GrpcClient project
{
    class Program // Defining the Program class
    {
        static async Task Main(string[] args) // Defining the entry point of the program
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001"); // Creating a gRPC channel for the specified address
            var client = new Greeter.GreeterClient(channel); // Creating a gRPC client using the channel
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Erhan", Lastname = "Ballıeker" }); // Calling the SayHelloAsync method of the gRPC client
            Console.WriteLine("Greeting: " + reply.Message); // Printing the greeting message received from the server
            Console.WriteLine("Press any key to exit..."); // Printing a message to prompt the user to exit
            Console.ReadKey(); // Waiting for the user to press any key before exiting the program
        }
    }
}
