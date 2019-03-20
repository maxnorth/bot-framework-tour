Scaffolding, available as visual studio extension package or as dotnet cli extension (term? plugin?)
Tends to create some clutter, i'd like to start simpler and show the absolute mimimum necessary to get thing working.

Start with:        
    dotnet new web -n BotFrameworkTour
    dotnet new sln -n BotFrameworkTour
    dotnet sln add BotFrameworkTour/BotFrameworkTour.csproj

Let VS Code add launcher and build task

Run to prove everything works

---------------------

- Add package dependency for bot builder (must specify version) <PackageReference Include="Microsoft.Bot.Builder.Integration.AspNet.Core" Version="4.3.2" />
- Add `app.UseBotFramework()` **before** `app.Run(...)`
- Try connecting emulator to /api/messages (note that you **must** use http endpoint, **not** https). Observe error about missing registration.
- Add IBot implementation with "Hello world" response, add `services.AddBot<MyBot>()`
- Test again, this will work (not in older versions)

--------------------

- Introduce config via .bot file (use `BotConfiguration.FromFolder`)
- Add file copy
https://docs.microsoft.com/en-us/azure/bot-service/bot-file-basics?view=azure-bot-service-4.0

---------------------

- Introduce bot state
- Demonstrate behavior
- Restart bot, show that the state is not preserved
- Introduce persistent state repo (need to add azure providers `dotnet add package Microsoft.Bot.Builder.Azure -v 4.3.2`)

Must inject conversation state, access values via turnContext
For cosmos, it will create the db and collection using fixed size. can use unlimited scale collection but partitionKey must be 'id'
You can use the storage provider directly if you like, or use it as backing for other custom stateful services, such as dialog-specific state
There are different types of storage - UserData, ConversationData, PrivateConversationData (what do these mean within the context of different clients? depends entirely on the client and how the bot service translates it to the bot framework )

------------------

middleware https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-concept-middleware?view=azure-bot-service-4.0
demonstrate moving save conversation state into autosave middleware. show how it gets linked to the ConversationState
point out use of other middleware components, such as transcript logger. mention that all of this is open source, code is accessible
demonstrate implementation of custom middleware. circuit break. modify TurnState.
show how you can provide event handlers to catch response messages and such.

-------------------

dialogs belong to a separate library, needs to be installed via `dotnet add package Microsoft.Bot.Builder.Dialogs -v 4.3.2`
Dialogue library - waterfall, prompts, show some other options
describe dialog stack
need to build waterfall dialogs deterministically, else you could get unexpected behavior
prompts, validation, retry prompts, validation scores (might hold off on this one til the)
dialogset can be associated with different kinds of state for different purposes
------------------------

`dotnet add package Microsoft.Bot.Builder.AI.Luis -v 4.3.2`
recognizers
custom, luis recognizer (used to be regex recognizer)
when training luis, there is a custom portal https://www.luis.ai/home

-------------------

- Translation/internationalization

------------------

Add bot code, send back text user sent

Connect emulator, demonstrate creation of bot file.

Communicate with bot, demonstrate functional messaging. 

Demonstrate role of botfile, connect it to the bot app via config, demonstrate changing of config values (port, name).

Return to messaging behavior, explain a bit about how there are different types of messages (activities).



Possible notes:
Reading the event logs
How to use emulator with remote app (couple options: go through bot service, or configure the emulator with ngrok)
ngrok note - can hit 'payment required' error if ngrok has been running for too long. the emulator will show an alert
Authentication model, 
Might explain how the approach i'm taking differs from what you'll find in the docs (templates/scaffolds)

Terms:
What is an Adapter?
What is an Activity?
What is meant by back-channel communication?


Notes:
Going to split up the presentation into two major pieces: The bot framework as a whole, and then the bot builder sdk
Found this great tip on targeting emulator directline from local webchat, completeley undocumented https://github.com/Microsoft/BotFramework-Emulator/issues/416
Kendo ui has a web chat client component: https://www.telerik.com/kendo-angular-ui/components/conversationalui/integrations/botframework/
List of activities: https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-connector-activities?view=azure-bot-service-4.0
ngrok URL: https://ngrok.com (has a nice demo on their site)



Microsoft.Bot.Builder.Integration.AspNet.Core



BotFile
---------------
Can be encrypted, used as place to store credentials
Reasons for existence:
- Provides a standard way of storing resources regardless of the language/platform you use.
- Bot Framework Emulator and CLI tools rely on and work great with tracking connected services in a consistent format (in a .bot file)
- Elegant tooling solutions around services creation and management is harder without a well defined schema (.bot file).