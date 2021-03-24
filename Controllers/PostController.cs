using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


[ApiController]
[Route("posts")]
public class PostController : ControllerBase
{
    private readonly IRepository<Post> _postRepository;

    public BookController(IRepository<Post> postRepository)
    {
        _postRepository = postRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Community>> GetAll()
    {
        return await  _postRepository.GetAll();
    }

//?
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        try
        {
            var result = await _postRepository.Get(id);
            return Ok(result);
        }
        catch (Exception)
        {
            return NotFound($"No post with id {id} found!");
        }

    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
           await _postRepository.Delete(id);
           return Ok();
        }
        catch(Exception)
        {
           return NotFound();
        }

    }


    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] Post post){
        try
        {
            var newPost = await _postRepository.Insert(post);
            return Created($"/posts/{post.Id}", newPost);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}

