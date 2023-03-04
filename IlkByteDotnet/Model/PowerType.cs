using System;
using System.ComponentModel;

namespace IlkByteDotnet.Model;

public enum PowerType
{
    [Description("start")]
    Start = 1,
    [Description("shutdown")]
    Shutdown = 2,
    [Description("reboot")]
    Reboot = 3,
    [Description("destroy")]
    Destroy = 4
}