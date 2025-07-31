using System;
using System.Collections.Generic;

namespace SmartFinanceManagement.Models;

public partial class User
{
    public int UserId { get; set; }

    public string ContactNumber { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedOn { get; set; }

    public string EmailId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string IsActive { get; set; } = null!;

    public string IsDelete { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public DateOnly UpdatedOn { get; set; }

    public string UserName { get; set; } = null!;

    public string UserType { get; set; } = null!;
}
