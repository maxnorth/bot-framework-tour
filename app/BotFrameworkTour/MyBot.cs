using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

public class MyBot : IBot {

    public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default(CancellationToken)) {
        
        await turnContext.SendActivityAsync("Hello world");
    }
}