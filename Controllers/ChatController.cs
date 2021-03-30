using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using project_back_end_foureach.Models;

[ApiController]
[Route("chats")]
public class ChatController : ControllerBase
{
    private readonly IRepository<ChatMessage> _chatRepository;

    public ChatController(IRepository<ChatMessage> chatRepository)
    {
        _chatRepository = chatRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<ChatMessage>> GetAll()
    {
        return await _chatRepository.GetAll();
    }

    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] ChatMessage chatMessage)
    {
        try
        {
            var newChatMessage = await _chatRepository.Insert(chatMessage);
            return Created($"/Chats/{chatMessage.Id}", newChatMessage);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}