using SimpleMessageSenderApi.Dtos;
using SimpleMessageSenderApi.MessageSenders.Abstract;

namespace SimpleMessageSenderApi.MessageSenders.Concrate
{
    public class SmsSender : MessageSenderBase
    {
        protected override string Execute(MessageDto messageDto)
        {
            /*
             * Sms codes
             * .
             * .
             * .
             */
            return "Sms sended";
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
