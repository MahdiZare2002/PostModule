using Microsoft.AspNetCore.Mvc;
using PostModule.Application.DTOs.Post;
using PostModule.Application.Interfaces;

namespace PostModule.Presentation.Controllers;

[Route("api/v{version:apiVersion}/Post")]
[ApiController]
public class PostController : Controller
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePostAsync(CreatePostDto postDto)
    {
        var postId = await _postService.CreatePost(postDto);
        return CreatedAtAction(nameof(GetById), new { id = postId }, postId);
    }

    [HttpGet("id")]
    public IActionResult GetById(int id)
    {
        return Ok();
    }
}