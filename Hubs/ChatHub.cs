using System.Threading.Tasks;
using project_back_end_foureach.Hubs.Clients;
using project_back_end_foureach.Models;
using Microsoft.AspNetCore.SignalR;
namespace project_back_end_foureach.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        private readonly IRepository<ChatMessage> _chatRepository;

        public ChatHub(IRepository<ChatMessage> chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
            // await _chatRepository.Insert(ChatMessage);
        }

        public async Task SendTyper(ChatMessage message)
        {
            await Clients.All.ReceiveTyper(message);

        }
    }
}