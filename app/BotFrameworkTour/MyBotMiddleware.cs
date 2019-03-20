using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

public class MyBotMiddleware : IMiddleware
{
    public async Task OnTurnAsync(ITurnContext turnContext, NextDelegate next, CancellationToken cancellationToken = default(CancellationToken))
    {
        if (turnContext.Activity.Text != "ignore")
        {
            turnContext.TurnState.Add("start-time", DateTime.Now.ToString());
            await next(cancellationToken);
        }
    }
}