var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.MyFirstAspireApp_ApiService>("apiservice");

builder.AddProject<Projects.MyFirstAspireApp_Web>("webfrontend")
		.WithReference(cache)
		.WithReference(apiservice);

builder.Build().Run();
