using System;
namespace IlkByteDotnet.Model;

public class BaseModel<T>
{
    public bool Status { get; set; }
    public string Message { get; set; }
    public string Error { get; set; }
    public T? Data { get; set; }
}



