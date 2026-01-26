using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public partial class Role
{
    public short Id { get; set; }

    public string RoleName { get; set; } = null!;
}
