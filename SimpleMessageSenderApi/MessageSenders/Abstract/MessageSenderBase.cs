using SimpleMessageSenderApi.Dtos;

namespace SimpleMessageSenderApi.MessageSenders.Abstract
{
    public abstract class MessageSenderBase
    {
        public string Send(MessageDto messageDto)
        {
            if (!IsMessageValid(messageDto))
            {
                return "Message not sended";
            }
            return Execute(messageDto);
        }
        protected abstract bool IsMessageValid(MessageDto messageDto);
        protected abstract string Execute(MessageDto messageDto);
    }
}
