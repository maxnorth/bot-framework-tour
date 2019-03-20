## Bot Builder SDK
- The SDK used for defining behavior of your chat bot. Implements the bot framework protocol.
- Currently in v4, released in September of last year
- Has stable releases for C# and JavaScript/TypeScript. Has preview releases for Java and Python.
- Deploys to any app server, same as any HTTP app

----------------------------------

## Optional SDK Integrations
- Persistent state via Azure Storage, Cosmos DB, or custom storage implementation
- Cognitive services for bot intelligence, such as language understanding models, QnA builder, Spell Check, translation, etc.

---------------------------------

### Notes

The SDK versions separately from the underlying protocol used to communicate with the Bot Service. The v4 SDK simply uses a different set of coding patterns from v3, but still implements the same protocol. Bots built with v3 are still compatible with Bot Service.