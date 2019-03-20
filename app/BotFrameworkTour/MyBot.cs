using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

public class MyBot : IBot {

    private readonly ConversationState _conversationState;

    public MyBot(ConversationState conversationState) {
        _conversationState = conversationState;
    }

    public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default(CancellationToken)) {
        
        var myBotStateProp = _conversationState.CreateProperty<MyBotState>(nameof(MyBotState));

        var myBotState = await myBotStateProp.GetAsync(turnContext) ?? new MyBotState();

        myBotState.Counter += 1;

        await myBotStateProp.SetAsync(turnContext, myBotState);

        await _conversationState.SaveChangesAsync(turnContext);

        await turnContext.SendActivityAsync("Hello world " + myBotState.Counter);
    }

    private class MyBotState {
        public int Counter { get; set; }
    }
}