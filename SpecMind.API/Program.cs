var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure to automatically invoke the registered validators
// builder.Services.AddScoped<FluentValidationFilter>();
// builder.Services.AddControllers(options =>
// {
//     options.Filters.Add<FluentValidationFilter>();
// });

builder.Services.AddFluentValidationAutoRegistration();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
});

// Register Validators
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserDTOValidator>();

builder.Services.AddSwaggerGen();
builder.Services.AddApplicationServiceDependencies();
builder.Services.AddInfrastructureServiceDependencies(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
