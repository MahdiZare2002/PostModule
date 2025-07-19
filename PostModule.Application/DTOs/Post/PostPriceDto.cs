namespace PostModule.Application.DTOs.Post;

public class PostPriceDto
{
    public int Start { get; set; }
    public int End { get; set; }
    public PriceDetailDto Price { get; set; }
}