using System;
using System.Collections.Generic;

namespace StoryReader.DAL.Entities;

public partial class Story
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public string? Description { get; set; }

    public string? AuthorName { get; set; }

    public string? CoverUrl { get; set; }

    public string? Status { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

    public virtual User CreatedByNavigation { get; set; } = null!;
}
