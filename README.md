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
* Infrastructure &^ (tied to Core)
* Storage &^ (Interfaces, tied to Core)
* Game &^ (interfaces, tied to Core)
* Storage.Mongo &^
* CommInterfaces &^
* Web
* Worker & (use Core, Infrastructure, Storage)
* Game.TicTacToe
* Game.Checkers
* Game.Vector3
* Game.UM
* Tests.Web
* Tests.Worker
* Tests.Core
* Tests.Infrastructure

https://github.com/ardalis/CleanArchitecture

TBGP.Core

TBGP.CommInterfaces

TBGP.Storage.Mongo

TBGP.UI
Unity

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
