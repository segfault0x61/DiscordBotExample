using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DiscordBotExample.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        [Description("Returns pong.")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.RespondAsync("Pong!").ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Adds two numbers together.")]
        public async Task Add(CommandContext ctx, [Description("First Number")] int num1,
            [Description("Second Number")] int num2)

        {
            await ctx.RespondAsync((num1 + num2).ToString()).ConfigureAwait(false);
        }
    }
}
