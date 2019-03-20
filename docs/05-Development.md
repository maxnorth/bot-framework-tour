<div style="font-size: 2.25em">

### Development tooling
    - Bot emulator
    - Multiple CLI applications for integration support
    - Standardized configuration file type for a single source of truth that can be referenced by your app, the emulator, and deployments
    - App scaffolding

</div>

## Notes

Scaffolding, available as visual studio extension package or as a template for `dotnet new`.
Tends to create some clutter, my demo starts simpler and shows the absolute mimimum necessary to get a bot working.

The bot framework emulator provides emulation of the bot service. It is both client and server, and hosts a url at which your bot app sends response messages. You can use the endpoint hosted by the bot emulator like a bot service url when testing a web chat client locally.

## Resources

[Download Bot Framework Emulator](https://github.com/Microsoft/BotFramework-Emulator/releases/latest)