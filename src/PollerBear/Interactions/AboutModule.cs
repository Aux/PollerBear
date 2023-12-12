using Discord;
using Discord.Interactions;

namespace PollerBear.Interactions;

public class AboutModule : InteractionModuleBase<SocketInteractionContext>
{
    [SlashCommand("about", "Get information about this bot application.")]
    public async Task AboutAsync()
    {
        var app = await Context.Client.GetApplicationInfoAsync();

        var uptime = System.Diagnostics.Process.GetCurrentProcess().StartTime;

        var embed = new EmbedBuilder()
            .WithTitle(app.Name)
            .WithDescription(app.Description)
            .AddField("Online Since", uptime.ToString("f"))
            .AddField("Source", "https://github.com/Aux/PollerBear")
            .WithFooter($"owned by {app.Owner} ({app.Owner.Id})")
            .Build();

        await RespondAsync(embed: embed, ephemeral: true);
    }
}
