namespace PostModule.Application.DTOs.Post;

public class CreatePostDto
{
    public string Title { get; set; }
    public string Status { get; set; }
    public string LocationType { get; set; }
    public string? Description { get; set; }
    public List<PostPriceDto> Prices { get; set; }
}