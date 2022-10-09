using SimpleMessageSenderApi.Enums;
using SimpleMessageSenderApi.MessageSenders.Abstract;

namespace SimpleMessageSenderApi.Factories.Abstract
{
    public interface IMessageSenderFactory
    {
        MessageSenderBase CreateInstance(MessageSenderType messageType);
    }
}
