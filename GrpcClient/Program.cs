using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;


using var channel = GrpcChannel.ForAddress("https://localhost:5001");

var client = new User.UserClient(channel);

var userResponse = await client.GetUserByIdAsync(new GetUserByIdRequest { Id = 25 }, new CallOptions());
Console.WriteLine(userResponse.FirstName);
Console.ReadLine();