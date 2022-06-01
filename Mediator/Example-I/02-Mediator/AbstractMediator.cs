using System.Collections.Generic;

namespace ChatroomExample{
	public abstract class AbstractMediator{

		protected List<AbstractVisitor> _activeVisitors = new List<AbstractVisitor>();

		public abstract void Send(string message, AbstractVisitor sender);

		public abstract void Register(AbstractVisitor visitor);

		public abstract void Unregister(AbstractVisitor visitor);

	}
}
