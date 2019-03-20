dialogs belong to a separate library, needs to be installed via `dotnet add package Microsoft.Bot.Builder.Dialogs -v 4.3.2`
Dialogue library - waterfall, prompts, show some other options
describe dialog stack
need to build waterfall dialogs deterministically, else you could get unexpected behavior
prompts, validation, retry prompts, validation scores (might hold off on this one til the)
dialogset can be associated with different kinds of state for different purposes

## [Compare changes](https://github.com/maxnorth/bot-framework-tour/compare/step-04-middleware...step-05-dialogs)