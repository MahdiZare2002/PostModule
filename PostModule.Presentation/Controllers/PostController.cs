using Microsoft.AspNetCore.Mvc;
using PostModule.Application.DTOs.Post;
using PostModule.Application.Interfaces;

namespace PostModule.Presentation.Controllers;

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

    [HttpGet($"{{{nameof(id)}:int}}")]
    public async Task<IActionResult> GetById(int id)
    {
        return Ok();
    }
}