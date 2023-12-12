using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollerBear.Services;

/// <summary>
///     Background service for pulling twitch's get streams endpoint on a schedule
/// </summary>
/// <remarks>
///     Twitch has a restrictive ratelimit on eventsub for unauthenticated topics.
///     So when a user wants notifications for a channel but has no authorization,
///     it gets placed in the polling service that can pull more than 1k streams
///     at a time every 5 minutes without any concern for ratelimits.
/// </remarks>
public class TwitchPollingService
{
}
