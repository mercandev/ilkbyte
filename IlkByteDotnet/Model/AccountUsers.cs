using System;
namespace IlkByteDotnet.Model;

public sealed class AccountUsers
{
    public Pagination pagination { get; set; }
    public List<UserList> user_list { get; set; }
}

public sealed class UserList
{
    public string email { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string last_login { get; set; }
    public string level { get; set; }
    public string status { get; set; }
    public bool verify { get; set; }
}

