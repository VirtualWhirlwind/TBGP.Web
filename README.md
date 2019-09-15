# TBGP.Web

OVERVIEW
* Client Server Based
* JSON Payload
* OAUTH User System (rely on things like Google, etc so no creds stored)
* Library Data Storage (start with MongoDB)
* Multiple Games
* Non-Real Time Chat System
* ASP Core/Pages web side
* First client: Unity
* Mobile client later
* Implement locking mechanism while processing a turn
* Store stats for turn runs for reporting and crash detection
* Enable Encryption At Rest for DB
* Make use of Lets Encrypt for SSL Cert

REPOS
TBGP.Web
* Core &^ (dependent on CommInterfaces)
* Infrastructure &^ (dependent on Core to implement interfaces, dependent on Storage.Mongo?)
* Storage.Mongo &^
* CommInterfaces &^
* Web
* Worker & (use Core, Infrastructure, Storage)
* 
* Game &^ (interfaces, tied to Core)
* Game.TicTacToe
* Game.Checkers
* Game.Vector3
* Game.UM
* Tests.Web
* Tests.Worker
* Tests.Core
* Tests.Infrastructure

Later, break out via "Clean Architecutre" to the following repo's:
https://github.com/ardalis/CleanArchitecture

TBGP.Web - Core Razor Pages

TBGP.Core

TBGP.Infrastructure

TBGP.Storage.Mongo?

TBGP.CommInterfaces

TBGP.UI - Unity

^ = NuGet 
& = Separate repo later


ROADMAP
* Start with all non-unity in one repo
* Break out pieces in to additional repo's and nuget as time permits and the pieces mature
* gitflow methodology
* github tools for organization and collaboration
* No PII stored
* ASP Pages
* MongoDB

GAMES
Tic-Tac-Toe
Checkers
Vector3
UM
