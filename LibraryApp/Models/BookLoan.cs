using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class BookLoan
{
    public int Id { get; set; }

    public string IdUser { get; set; } = null!;

    public string IdBook { get; set; } = null!;

    public DateOnly DateIssuance { get; set; }

    public DateOnly DatePlanReturn { get; set; }

    public DateOnly? DateReturn { get; set; }

    public int IdStatus { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
