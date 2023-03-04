using System;
using IlkByteDotnet.Model;
using System.Security.Principal;

namespace IlkByteDotnet;

public class IlkByteService : IIlkByteService
{
    private readonly IlkByteAuth _ilkbyteAuth;

    public IlkByteService(IlkByteAuth ilkbyteAuth)
    => this._ilkbyteAuth = ilkbyteAuth;

    public async Task<BaseModel<Account>> Account()
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.ACCOUNT_INFORMATION_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret);
        return await IlkByteHelper.GetService<BaseModel<Account>>(requestUrl);
    }

    public async Task<BaseModel<AccountUsers>> AccountUsers()
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.ACCOUNT_USERS_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret);
        return await IlkByteHelper.GetService<BaseModel<AccountUsers>>(requestUrl);
    }

    public async Task<BaseModel<Server>> ActiveServerList(int paginationNumber = 1)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_ACTIVE_LIST_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, paginationNumber);
        return await IlkByteHelper.GetService<BaseModel<Server>>(requestUrl);
    }

    public async Task<BaseModel<ServerCreate>> CreateServer(ServerCreateRequest request)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_CREATE_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, request.username, request.password, request.name, request.os_id, request.app_id, request.package_id);
        return await IlkByteHelper.GetService<BaseModel<ServerCreate>>(requestUrl);
    }

    public async Task<BaseModel<ServerConfigOptions>> ServerConfigOptions()
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_CONFIG_OPTIONS_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret);
        return await IlkByteHelper.GetService<BaseModel<ServerConfigOptions>>(requestUrl);
    }

    public async Task<BaseModel<ServerIpList>> ServerIpList(string serverName)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_IP_LIST_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName);
        return await IlkByteHelper.GetService<BaseModel<ServerIpList>>(requestUrl);
    }

    public async Task<BaseModel<List<ServerIpLogs>>> ServerIpLogs(string serverName)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_IP_LOG_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName);
        return await IlkByteHelper.GetService<BaseModel<List<ServerIpLogs>>>(requestUrl);
    }

    public async Task<BaseModel<Server>> ServerList(int paginationNumber = 1)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_LIST_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, paginationNumber);
        return await IlkByteHelper.GetService<BaseModel<Server>>(requestUrl);
    }

    public async Task<BaseModel<ServerPowerManagement>> ServerPowerManagement(string serverName, PowerType powerType)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_POWER_MANAGMENT_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, powerType.GetEnumDescription());
        return await IlkByteHelper.GetService<BaseModel<ServerPowerManagement>>(requestUrl);
    }

    public async Task<BaseModel<object>> ServerSnapshotCronCreate(SnapshotCronCreateRequest request)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_CRON_ADD_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, request.ServerName, request.SnapshotName, request.Day, request.Hour, request.Min);
        return await IlkByteHelper.GetService<BaseModel<object>>(requestUrl);
    }

    public async Task<BaseModel<object>> ServerSnapshotCronDelete(string serverName, string snapshotName)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_CRON_DELETE_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, snapshotName);
        return await IlkByteHelper.GetService<BaseModel<object>>(requestUrl);
    }

    public async Task<BaseModel<Snapshot>> ServerSnapshotList(string serverName)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_LIST_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName);
        return await IlkByteHelper.GetService<BaseModel<Snapshot>>(requestUrl);
    }

    public async Task<BaseModel<object>> ServerSnapshotOperation(string serverName, string snapshotName, SnapshotType snapshotType)
    {
        string requestUrl = string.Empty;

        switch (snapshotType)
        {
            case SnapshotType.Create:
                requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_CREATE_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, snapshotName);
                break;
            case SnapshotType.Revert:
                requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_REVERT_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, snapshotName);
                break;
            case SnapshotType.Update:
                requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_UPDATE_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, snapshotName);
                break;
            case SnapshotType.Delete:
                requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SNAPSHOT_DELETE_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName, snapshotName);
                break;
            default:
                throw new Exception("Out-of-process!");
        }
        return await IlkByteHelper.GetService<BaseModel<object>>(requestUrl);
    }

    public async Task<BaseModel<ServerStatus>> ServerStatus(string serverName)
    {
        var requestUrl = string.Format(UrlConst.BASE_URL + UrlConst.SERVER_STATUS_URL, _ilkbyteAuth.Access, _ilkbyteAuth.Secret, serverName);
        return await IlkByteHelper.GetService<BaseModel<ServerStatus>>(requestUrl);
    }
}