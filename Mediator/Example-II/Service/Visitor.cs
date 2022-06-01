using ChatRoomMediator.Repository;

namespace ChatRoomMediator.Service;

public class Visitor{

    private Mediator? _mediator;
    private string? _name;

    public Visitor(string name)
        => _name = name;

    public void SetMediator(Mediator mediator)
        => _mediator = mediator;

    public void Send(string content)
        => _mediator?.PushMessage(
            new(){
                Title = _name + " sent:",
                Content = content
            }
        );

}
