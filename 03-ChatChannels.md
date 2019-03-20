

There used to be a web app where you could select a pairing of a channel and a message type, and it would describe the behavior that the bot service takes in supporting that message type for that channel. The link to that site now redirects to the standard bot service documentation landing page.

There is something similar in the regular documentation, called the [channel reference](https://docs.microsoft.com/en-us/azure/bot-service/bot-service-channels-reference?view=azure-bot-service-4.0) which provides a more technical degree of information about the chat messaging protocol and how each channel supports the different messages. For instance, not all message types are typical content messages. The 'typing' message can be sent by your bot to indicate a forthcoming response. The channel reference indicates that this message is only supported by web chat and the direct line protocol.

What is Direct Line? The Azure Bot Service exposes an API that allows for implementing custom chat clients. This is the same API used by the web chat client that Microsoft provides, an which you can add to your personal web applications.