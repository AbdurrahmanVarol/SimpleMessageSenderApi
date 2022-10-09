using SimpleMessageSenderApi.Enums;
using SimpleMessageSenderApi.Factories.Abstract;
using SimpleMessageSenderApi.MessageSenders.Abstract;
using SimpleMessageSenderApi.MessageSenders.Concrate;

namespace SimpleMessageSenderApi.Factories.Concrate
{
    public class MessageSenderFactory : IMessageSenderFactory
    {
        public MessageSenderBase CreateInstance(MessageSenderType messageType)
        {
            return messageType switch
            {
                MessageSenderType.Sms => new SmsSender(),
                MessageSenderType.Email => new SmsSender(),
                _ => throw new NotImplementedException(nameof(messageType))
            };
        }
    }
}
