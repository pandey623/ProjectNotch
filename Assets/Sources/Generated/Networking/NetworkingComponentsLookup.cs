//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentsLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class NetworkingComponentsLookup {

    public const int Client = 0;
    public const int Connection = 1;
    public const int Ids = 2;
    public const int IncomingMessages = 3;
    public const int NextPlayerId = 4;
    public const int OutgoingMessages = 5;
    public const int PlayerId = 6;
    public const int Server = 7;

    public const int TotalComponents = 8;

    public static readonly string[] componentNames = {
        "Client",
        "Connection",
        "Ids",
        "IncomingMessages",
        "NextPlayerId",
        "OutgoingMessages",
        "PlayerId",
        "Server"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(ClientComponent),
        typeof(ConnectionComponent),
        typeof(IdsComponent),
        typeof(IncomingMessagesComponent),
        typeof(NextPlayerIdComponent),
        typeof(OutgoingMessagesComponent),
        typeof(PlayerIdComponent),
        typeof(ServerComponent)
    };
}
