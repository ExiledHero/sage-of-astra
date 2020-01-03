using System;
using System.Threading.Tasks;
using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using SageOfAstra.Configs;

namespace SageOfAstra.Preconditions
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    class RequireMasterAttribute : PreconditionAttribute
    {
        public override async Task<PreconditionResult> CheckPermissionsAsync(ICommandContext context, CommandInfo command, IServiceProvider map)
        {
            var config = map.GetService<CoreConfig>();

            return await Task.FromResult(
                context.User.Id == config.MasterId
                ? PreconditionResult.FromSuccess()
                : PreconditionResult.FromError("Insufficient permission.")).ConfigureAwait(false);
        }
    }
}
