using System;
using System.Collections.Generic;

namespace StoryReader.DAL.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Role { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Story> Stories { get; set; } = new List<Story>();
}
