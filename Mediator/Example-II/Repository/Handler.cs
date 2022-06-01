using ChatRoomMediator.Service;

namespace ChatRoomMediator.Repository;

public static class Handler{

    public static IResult Put(Mediator mediator, string name, string content) {
        var visitor = new Visitor(name);
        visitor.SetMediator(mediator);
        visitor.Send(content);
        return Results.NoContent();
    }

    public static IResult Get(Mediator mediator)
        => Results.Ok(mediator.All());

}
