using graphqlDemo.GQLTypes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register GraphQL server
builder.Services.AddGraphQLServer().AddQueryType<QueryType>();

string LOCAL_POLICY = "LOCAL_POLICY";

builder.Services.AddCors(options =>
     {
         options.AddPolicy(LOCAL_POLICY,builder => 
            builder.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
         );
     }   
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//enabling cors
app.UseCors(LOCAL_POLICY);
app.UseAuthorization();

app.MapControllers();
//Add GraphQL endpoint
app.MapGraphQL(); //default end point("/graphql")

app.Run();
