using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollerBear.Services;

/// <summary>
///     Background service for watching a youtube channel's rss feed for changes.
/// </summary>
/// <remarks>
///     When a new video is seen in a channel's rss feed, this service will
///     request more info from the Videos: list endpoint to differentiate between
///     regular uploads and livestreams.
/// </remarks>
public class YoutubePollingService
{
}
