using System;
using System.Collections.Generic;

namespace Sofbeauty.Models;

public partial class Customer
{
    public int CustomersId { get; set; }

    public string CustomersName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
