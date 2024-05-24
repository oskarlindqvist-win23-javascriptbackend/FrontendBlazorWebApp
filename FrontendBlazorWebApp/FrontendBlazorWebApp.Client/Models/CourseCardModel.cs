namespace FrontendBlazorWebApp.Client.Models;

public class CourseCardModel
{
    public string? Id { get; set; }
    public string? ImageUri { get; set; }
    public bool IsBestseller { get; set; }
    public string? Title { get; set; }
    public List<AuthorModel>? Authors { get; set; }
    public PricesModel? Prices { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Likes { get; set; }
    public string? Hours { get; set; }
}

public class AuthorModel
{
    public string? Name { get; set; }
}

public class PricesModel
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
