using System;
namespace IlkByteDotnet.Model;


public sealed class BackupList
{
    public decimal amount { get; set; }
    public List<Backup> backup { get; set; }
}

public sealed class Backup
{
    public string name { get; set; }
    public string file_size { get; set; }
    public string file_hash { get; set; }
    public bool is_locked { get; set; }
    public string backup_time { get; set; }
}