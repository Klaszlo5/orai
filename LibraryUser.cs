using System;
using System.Collections.Generic;

public class LibraryUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime MembershipStartDate { get; set; }
    public List<Loan> Loans { get; set; } = new List<Loan>();
}