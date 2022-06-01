using ChatRoomMediator.Data;

namespace ChatRoomMediator.Repository;

public class Mediator {

    private readonly Queue<Message>? _items;

    public Mediator()
        => _items = new Queue<Message>();

    public void PushMessage(Message item)
        => _items?.Enqueue(item);

    public IList<Message>? All()
        => _items?.ToArray();

}
