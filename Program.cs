using TradePlacementWorker;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddLogging();
        services.AddHostedService<AkkaWorker>();
    })
    .ConfigureLogging((ctx, builder) =>
    {
        builder.AddConsole();
    })
    .UseConsoleLifetime()
    .Build();

await host.RunAsync();
