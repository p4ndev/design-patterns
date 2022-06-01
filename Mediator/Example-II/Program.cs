using ChatRoomMediator.Repository;
using ChatRoomMediator.Service;

var builder  = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Mediator>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("/chat",      Actions.Get.Messages);
app.MapPut("/chat/john", Actions.Put.John.Message);
app.MapPut("/chat/mark", Actions.Put.Mark.Message);

app.Run();