using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class Publishing
{
    public int Id { get; set; }

    public string PublishName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
