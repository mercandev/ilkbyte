using System;
using IlkByteDotnet.Model;
using System.Security.Principal;

namespace IlkByteDotnet;

public interface IIlkByteService
{
    Task<BaseModel<Account>> Account();
    Task<BaseModel<AccountUsers>> AccountUsers();
    Task<BaseModel<Server>> ServerList(int paginationNumber = 1);
    Task<BaseModel<Server>> ActiveServerList(int paginationNumber = 1);
    Task<BaseModel<ServerConfigOptions>> ServerConfigOptions();
    Task<BaseModel<ServerCreate>> CreateServer(ServerCreateRequest request);
    Task<BaseModel<ServerStatus>> ServerStatus(string serverName);
    Task<BaseModel<ServerPowerManagement>> ServerPowerManagement(string serverName, PowerType powerType);
    Task<BaseModel<ServerIpList>> ServerIpList(string serverName);
    Task<BaseModel<List<ServerIpLogs>>> ServerIpLogs(string serverName);
    Task<BaseModel<Snapshot>> ServerSnapshotList(string serverName);
    Task<BaseModel<object>> ServerSnapshotOperation(string serverName, string snapshotName, SnapshotType snapshotType);
    Task<BaseModel<object>> ServerSnapshotCronCreate(SnapshotCronCreateRequest request);
    Task<BaseModel<object>> ServerSnapshotCronDelete(string serverName, string snapshotName);

}