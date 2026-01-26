using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class User
{
    public string Bilet { get; set; } = null!;

    public short IdRole { get; set; }

    public string Fio { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string PasswordUser { get; set; } = null!;

    public virtual ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();
}
