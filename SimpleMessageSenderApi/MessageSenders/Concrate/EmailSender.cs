using SimpleMessageSenderApi.Dtos;
using SimpleMessageSenderApi.MessageSenders.Abstract;

namespace SimpleMessageSenderApi.MessageSenders.Concrate
{
    public class EmailSender : MessageSenderBase
    {
        protected override string Execute(MessageDto messageDto)
        {
            /*
             * Email codes
             * .
             * .
             * .
             */
            return "Email sended";
        }

        protected override bool IsMessageValid(MessageDto messageDto)
        {
            /*
             * Validation codes
             * .
             * .
             * .
             */
            return true;
        }
    }
}
