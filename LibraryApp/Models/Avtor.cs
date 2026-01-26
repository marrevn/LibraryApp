using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class Avtor
{
    public int Id { get; set; }

    public string AvtorName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
