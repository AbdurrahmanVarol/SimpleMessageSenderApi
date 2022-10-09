using Microsoft.AspNetCore.Mvc;
using SimpleMessageSenderApi.Dtos;
using SimpleMessageSenderApi.Factories.Abstract;
using SimpleMessageSenderApi.Models;

namespace SimpleMessageSenderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private IMessageSenderFactory _messageSenderFactory;
        public MessagesController(IMessageSenderFactory messageSenderFactory)
        {
            _messageSenderFactory = messageSenderFactory;
        }
        [HttpPost]
        public string Post([FromBody] MessageModel messageModel)
        {
            var messageSender = _messageSenderFactory.CreateInstance(messageModel.MessageSenderType);
            return messageSender.Send(new MessageDto
            {
                Title = messageModel.Title,
                Text = messageModel.Text
            });
        }
    }
}
