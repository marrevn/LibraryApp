using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class Book
{
    public string Isbn { get; set; } = null!;

    public string NameBook { get; set; } = null!;

    public int IdAvtor { get; set; }

    public int IdGenre { get; set; }

    public int IdPublishing { get; set; }

    public int YearIzd { get; set; }

    public int Page { get; set; }

    public int Copies { get; set; }

    public int CountBook { get; set; }

    public string Annotation { get; set; } = null!;

    public string? PhotoUrl { get; set; }

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

    public virtual Avtor Avtor { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual Publishing Publishing { get; set; } = null!;
}
