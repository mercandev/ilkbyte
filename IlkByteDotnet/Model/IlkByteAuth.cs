using System;
namespace IlkByteDotnet.Model;

public class IlkByteAuth
{
    public string Access { get; set; }
    public string Secret { get; set; }

    public IlkByteAuth(string access, string secret)
    {
        this.Access = access;
        this.Secret = secret;
    }

    public IlkByteAuth()
    {

    }
}
