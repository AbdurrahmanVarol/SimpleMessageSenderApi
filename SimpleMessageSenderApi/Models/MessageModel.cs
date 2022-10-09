using SimpleMessageSenderApi.Enums;

namespace SimpleMessageSenderApi.Models
{
    public class MessageModel
    {
        public MessageSenderType MessageSenderType{ get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
