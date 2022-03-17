using Grpc.Net.Client;
using MagicOnion.Client;
using MagicOnionTest.Interface;

var channel = GrpcChannel.ForAddress("https://localhost:7154");

// NOTE: If your project targets non-.NET Standard 2.1, use `Grpc.Core.Channel` class instead.
// var channel = new Channel("localhost", 5001, new SslCredentials());

// Create a proxy to call the server transparently.
var client = MagicOnionClient.Create<ICService>(channel);

// Call the server-side method using the proxy.
var result = await client.Hello("caoyiliang");
Console.WriteLine($"Result: {result}");
Console.ReadKey();