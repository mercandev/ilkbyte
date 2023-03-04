using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IlkByteDotnet;
using IlkByteDotnet.Model;
using Microsoft.AspNetCore.Mvc;

namespace IB.Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ByteTestController : Controller
{
    private readonly IIlkByteService _ilkByteService;

    public ByteTestController(IIlkByteService ilkByteService)
    => this._ilkByteService = ilkByteService;


    [HttpGet]
    public async Task<BaseModel<Account>> Account()
    => await _ilkByteService.Account();

    [HttpGet]
    public async Task<BaseModel<AccountUsers>> AccountUsers()
    => await _ilkByteService.AccountUsers();

    [HttpGet]
    public async Task<BaseModel<Server>> ServerList(int pageNumber)
    => await _ilkByteService.ServerList(pageNumber);

    [HttpGet]
    public async Task<BaseModel<Server>> ActiveServerList(int pageNumber)
    => await _ilkByteService.ActiveServerList(pageNumber);

    [HttpGet]
    public async Task<BaseModel<ServerConfigOptions>> ServerConfigOptions()
    => await _ilkByteService.ServerConfigOptions();

    [HttpPost]
    public async Task<BaseModel<ServerCreate>> CreateServer(ServerCreateRequest request)
    => await _ilkByteService.CreateServer(request);

    [HttpGet]
    public async Task<BaseModel<ServerStatus>> ServerStatus(string serverName)
    => await _ilkByteService.ServerStatus(serverName);

    [HttpGet]
    public async Task<BaseModel<ServerPowerManagement>> ServerPowerManagement(string serverName, PowerType powerType)
    => await _ilkByteService.ServerPowerManagement(serverName, powerType);

    [HttpGet]
    public async Task<BaseModel<ServerIpList>> ServerIpList(string serverName)
    => await _ilkByteService.ServerIpList(serverName);

    [HttpGet]
    public async Task<BaseModel<List<ServerIpLogs>>> ServerIpLogs(string serverName)
    => await _ilkByteService.ServerIpLogs(serverName);

    [HttpGet]
    public async Task<BaseModel<Snapshot>> SnapshotList(string serverName)
    => await _ilkByteService.ServerSnapshotList(serverName);

    [HttpGet]
    public async Task<BaseModel<object>> SnapshotOperation(string serverName, string snapshotName, SnapshotType snapshotType)
    => await _ilkByteService.ServerSnapshotOperation(serverName, snapshotName, snapshotType);

    [HttpPut]
    public async Task<BaseModel<object>> SnapshotCronCreate(SnapshotCronCreateRequest request)
    => await _ilkByteService.ServerSnapshotCronCreate(request);

    [HttpDelete]
    public async Task<BaseModel<object>> SnapshotCronDelete(string serverName, string snapshotName)
    => await _ilkByteService.ServerSnapshotCronDelete(serverName, snapshotName);
}

