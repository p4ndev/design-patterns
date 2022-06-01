namespace ChatroomExample{
	public class Chatroom : AbstractMediator{

		public override void Register(AbstractVisitor visitor)
			=> _activeVisitors.Add(visitor);

		public override void Unregister(AbstractVisitor visitor)
			=> _activeVisitors.Remove(visitor);

		public override void Send(string message, AbstractVisitor sender){
			foreach (var visitor in _activeVisitors)
				if (visitor != sender)
					visitor.Receive(message);
		}

	}
}
