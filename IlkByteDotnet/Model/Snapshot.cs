using System;
namespace IlkByteDotnet.Model;

public sealed class Snapshot
{
    public List<Snapshots> snapshots { get; set; }
}

public sealed class Snapshots
{
    public string name { get; set; }
    public bool current { get; set; }
    public string state { get; set; }
    public string location { get; set; }
    public string parent { get; set; }
    public int children { get; set; }
    public int descendants { get; set; }
    public bool metadata { get; set; }
    public SnapshotParams @params { get; set; }
    public string date { get; set; }
}

public sealed class SnapshotParams
{
    public bool is_cron { get; set; }
    public string last_run { get; set; }
    public string next_run { get; set; }
    public string cron_time { get; set; }
}

public sealed class SnapshotCronCreateRequest
{
    public string ServerName { get; set; }
    public string SnapshotName { get; set; }
    public int Day { get; set; }
    public int Hour { get; set; }
    public int Min { get; set; }
}