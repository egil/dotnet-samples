﻿using GPSTracker.Common;
using Microsoft.AspNetCore.SignalR;

namespace GPSTracker;

/// <summary>
/// Broadcasts location messages to clients which are connected to the local SignalR hub.
/// </summary>
internal sealed class RemoteLocationHub(IHubContext<LocationHub> hub) : IRemoteLocationHub
{
    // Send a message to every client which is connected to the hub
    public ValueTask BroadcastUpdates(VelocityBatch messages) =>
        new(hub.Clients.All.SendAsync(
            "locationUpdates", messages, CancellationToken.None));
}
