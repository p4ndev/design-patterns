using ChatRoomMediator.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChatRoomMediator.Service;

public static class Actions {

    private static string FIRST_VISITOR = "John";
    private static string SECOND_VISITOR = "Mark";

    public static class Put {

        public static class John {
            public static IResult Message(Mediator mediator, [FromBody] string content)
                => Handler.Put(mediator, FIRST_VISITOR, content);
        }

        public static class Mark {
            public static IResult Message(Mediator mediator, [FromBody] string content)
                => Handler.Put(mediator, SECOND_VISITOR, content);
        }

    }

    public static class Get {
        public static IResult Messages(Mediator mediator)
            => Handler.Get(mediator);
    }
    
}
