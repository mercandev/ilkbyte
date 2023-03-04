using System;
namespace IlkByteDotnet.Model;

public sealed class Account
{
    public decimal Balance { get; set; }
    public string Group { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
}
