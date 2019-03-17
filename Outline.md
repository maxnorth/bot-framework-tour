# Intro
- Framework for creating chat bots
    - What are the various parts of the 'framework'?
        - SDK for creating bot apps
            - The SDK used for defining behavior of your chat bot
            - Currently in v4, released in September of last year
            - Has stable releases for C# and JavaScript/TypeScript. Has preview releases for Java and Python.
            - Multi-platform. 
        - Azure 'Bot Service' resource for supporting multiple clients
            - What does this do that the SDK doesn't do?
            - Why is this necessary?
                - Decouples the architecture of channel support from bot logic.
            - What all does it do? (return to this, need dedicated slides for this)
            - What kind of channels are supported
        - Web chat JS utility
            - Open source, built on react, can be pulled into the project in several ways (CDN script, npm reference, etc)
        - Development tooling
            - Bot emulator
            - Multiple CLI applications for integration support
            - Standardized configuration file type for a single source of truth that can be referenced by your app, the emulator, and deployments

# App Architecture
