## Development tooling
- Bot emulator: chat client for development workflow, emulator of Bot Service
- Multiple CLI applications for integration support
- Standardized configuration file type for a single source of truth that can be referenced by your app, the emulator, and deployments
- App scaffolding
- Custom .bot config file: standardized config format for use by app, emulator, and command line tools
- ngrok

---------------------------

### Notes

#### Scaffolding
Scaffolding, available as visual studio extension package or as a template for `dotnet new`.
Tends to create some clutter, my demo starts simpler and shows the absolute mimimum necessary to get a bot working.

#### Emulator
The bot framework emulator provides emulation of the bot service. It is both client and server, and hosts a url at which your bot app sends response messages. You can use the endpoint hosted by the bot emulator like a bot service url when testing a web chat client locally.

#### .bot config file
Can be encrypted, used as place to store credentials
Microsoft's reasons for existence:
- Provides a standard way of storing resources regardless of the language/platform you use.
- Bot Framework Emulator and CLI tools rely on and work great with tracking connected services in a consistent format (in a .bot file)
- Elegant tooling solutions around services creation and management is harder without a well defined schema (.bot file).

### Resources

[Download Bot Framework Emulator](https://github.com/Microsoft/BotFramework-Emulator/releases/latest)
[Bot Builder Tools](https://github.com/Microsoft/botbuilder-tools)