<div style="font-size: 2.25em">

### Chat Channels
- Pre-supported channels, such as text, email, Facebook, Slack, and many others
- DirectLine API provides a way to implement custom chat clients or translation layers between existing chat clients
- WebChat JS library provided by Microsoft for web-embedded chat clients. Build on DirectLine.

------------------------------------

### Chat Features

- Various message types: images, hero cards, carousels, buttons, AdaptiveCards, attachments, spoken text, typing indicators, etc
- Not all channels support all features
- The emulator supports essentially everything - be wary of this
- If in doubt, consult the [channel reference](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0)

</div>

## Notes

### Channel feature limitations

There used to be a web app called the 'channel inspector' where you could select a pairing of a channel and a message type, and it would describe the behavior that the bot service takes in supporting that message type for that channel. The link to that site now redirects to the standard bot service documentation landing page. This used to describe a feature known as 'down-rendering' in which the Bot Service would convert message types that were not directly supported by the client into a format that the client could understand. Often this involved turning messages into images, or sending links that function as buttons. The channel reference (above) seems to have replaced the channel inspector and makes no mention of 'down-rendering', indicating it may be on its way out.

### Web Chat
- Open source library, built on react, can be pulled into the project in several ways (CDN script, npm reference, etc)
- Kendo UI also provides a web chat client for the bot framework.

## Resources
- [WebChat client](https://github.com/Microsoft/BotFramework-WebChat)
- [Kendo UI web chat client component](https://www.telerik.com/kendo-angular-ui/components/conversationalui/integrations/botframework/)
- [Bot Activity Types](https://docs.microsoft.com/en-us/azure/bot-service/rest-api/bot-framework-rest-connector-activities?view=azure-bot-service-4.0)
- [OAuth Support](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-authentication?view=azure-bot-service-4.0&tabs=csharp)