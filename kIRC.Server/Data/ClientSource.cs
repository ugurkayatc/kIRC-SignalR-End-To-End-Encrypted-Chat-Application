using kIRC.Server.Models;

namespace SignalRServer.Data;

public static class ClientSource
{
    public static List<Client> Clients { get; } = new();
}