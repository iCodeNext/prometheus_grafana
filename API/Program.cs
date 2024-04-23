using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMetricServer();

app.MapGet("/Hello", () =>
{
    return "Hello From Project :)";
});
app.UseHttpMetrics();

app.Run();

 