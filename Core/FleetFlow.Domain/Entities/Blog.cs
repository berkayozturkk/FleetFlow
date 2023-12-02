using FleetFlow.Domain.Abstraction;

namespace FleetFlow.Domain.Entities;

public class Blog : Entity<Guid>
{
    public string Title { get; set; }
    public Guid AuthorID { get; set; }
    public Author Author { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public Guid CategoryID { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public List<TagCloud> TagClouds { get; set; }
    public List<Comment> Comments { get; set; }


    public Blog(){}
    public Blog(Guid id, string title, Guid authorId, string coverImageUrl, DateTime createdDate, Guid categoryId, string description) : base(id)
    {
        Title = title;
        AuthorID = authorId;
        CoverImageUrl = coverImageUrl;
        CreatedDate = createdDate;
        CategoryID = categoryId;
        Description = description;
    }
}
