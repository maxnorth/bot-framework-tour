
- Introduce bot state
- Demonstrate behavior
- Restart bot, show that the state is not preserved
- Introduce persistent state repo (need to add azure providers `dotnet add package Microsoft.Bot.Builder.Azure -v 4.3.2`)

Must inject conversation state, access values via turnContext
For cosmos, it will create the db and collection using fixed size. can use unlimited scale collection but partitionKey must be 'id'
You can use the storage provider directly if you like, or use it as backing for other custom stateful services, such as dialog-specific state
There are different types of storage - UserData, ConversationData, PrivateConversationData (what do these mean within the context of different clients? depends entirely on the client and how the bot service determines the scope of a 'conversation')

## [Compare changes](https://github.com/maxnorth/bot-framework-tour/compare/step-02-bot-config...step-03-bot-state)