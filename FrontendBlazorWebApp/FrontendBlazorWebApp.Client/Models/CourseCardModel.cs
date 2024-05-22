namespace FrontendBlazorWebApp.Client.Models;

public class CourseCardModel
{
    public string? Id { get; set; }
    public string? ImageUri { get; set; }
    public bool IsBestseller { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? LikesInProcent { get; set; }
    public string? Likes { get; set; }
    public string? Hours { get; set; }
}
