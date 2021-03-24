using System.Threading.Tasks;
using project_back_end_foureach.Models;

namespace project_back_end_foureach.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
