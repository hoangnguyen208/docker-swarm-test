var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options => {
    options.ListenAnyIP(8085);
});

var app = builder.Build();

app.MapGet("/", () => { 
    var hostname = System.Net.Dns.GetHostName();
    Task.Delay(1000).Wait();
    Console.WriteLine("Dotnet App listening to 8085, hostname= " + hostname);
    return "Dotnet App on swarm, hostname = " + hostname;
});

app.Run();
