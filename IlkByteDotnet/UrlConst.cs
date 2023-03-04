using System;

namespace IlkByteDotnet;

public static class UrlConst
{
    public const string BASE_URL = "https://api.ilkbyte.com/";
    public const string ACCOUNT_INFORMATION_URL = "account?access={0}&secret={1}";
    public const string ACCOUNT_USERS_URL = "account/users?access={0}&secret={1}";
    public const string SERVER_LIST_URL = "server/list/all?access={0}&secret={1}&p={2}";
    public const string SERVER_ACTIVE_LIST_URL = "server/list?access={0}&secret={1}&p={2}";
    public const string SERVER_CONFIG_OPTIONS_URL = "server/create?access={0}&secret={1}";
    public const string SERVER_CREATE_URL = "server/create/config?access={0}&secret={1}&username={2}&password={3}&name={4}&os_id={5}&app_id={6}&package_id={7}";
    public const string SERVER_STATUS_URL = "server/manage/{2}/show?access={0}&secret={1}";
    public const string SERVER_POWER_MANAGMENT_URL = "server/manage/{2}/power?access={0}&secret={1}&set={3}";
    public const string SERVER_IP_LIST_URL = "server/manage/{2}/ip/list?access={0}&secret={1}";
    public const string SERVER_IP_LOG_URL = "server/manage/{2}/ip/logs?access={0}&secret={1}";
    public const string SNAPSHOT_LIST_URL = "server/manage/{2}/snapshot?access={0}&secret={1}";
    public const string SNAPSHOT_CREATE_URL = "server/manage/{2}/snapshot/create?access={0}&secret={1}&name={3}";
    public const string SNAPSHOT_REVERT_URL = "server/manage/{2}/snapshot/revert?access={0}&secret={1}&name={3}";
    public const string SNAPSHOT_UPDATE_URL = "server/manage/{2}/snapshot/update?access={0}&secret={1}&name={3}";
    public const string SNAPSHOT_DELETE_URL = "server/manage/{2}/snapshot/delete?access={0}&secret={1}&name={3}";
    public const string SNAPSHOT_CRON_ADD_URL = "server/manage/{2}/snapshot/cron/add?access={0}&secret={1}&name={3}&day={4}&hour={5}&min={6}";
    public const string SNAPSHOT_CRON_DELETE_URL = "server/manage/{2}/snapshot/cron/delete?access={0}&secret={1}&name={3}";
    public const string BACKUP_LIST_URL = "server/manage/{2}/backup?access={0}&secret={1}";
    public const string BACKUP_RESTORE = "server/manage/{2}/backup/restore?access={0}&secret={1}&backup_name={3}";
    public const string DOMAIN_LIST = "domain/list?access={0}&secret={1}&p={2}";
    public const string DOMAIN_CREATE = "domain/create?access={0}&secret={1}&domain={2}&server={3}&ipv6={4}";
}

