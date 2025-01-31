﻿namespace BattleBitAPI.Networking
{
    public enum NetworkCommuncation : byte
    {
        None = 0,
        Hail = 1,
        Accepted = 2,
        Denied = 3,

        ExecuteCommand = 10,
        SendPlayerStats = 11,
        SpawnPlayer = 12,

        PlayerConnected = 50,
        PlayerDisconnected = 51,
        OnPlayerTypedMessage = 52,
        OnPlayerKilledAnotherPlayer = 53,
        GetPlayerStats = 54,
        SavePlayerStats = 55,
        OnPlayerAskingToChangeRole = 56,
        OnPlayerChangedRole = 57,
        OnPlayerJoinedASquad = 58,
        OnPlayerLeftSquad = 59,
        OnPlayerChangedTeam = 60,
        OnPlayerRequestingToSpawn = 61,
    }
}
