# EasyMod
A mod to allow users to easily create their own mods for Hollow Knight.

## Manual Build

### Prerequisites
- An authentic copy of Hollow Knight with the modding API installed
- The `dotnet` CLI command (with .NET 6)
- A POSIX-compatible shell

### Quick Start
```sh
$ git clone https://github.com/thomasebsmith/HollowKnight.EasyMod.git
$ cd HollowKnight.EasyMod

$ ./scripts/build .../hollow/knight/Managed
# The DLL will be built but not installed

# - OR -

$ ./scripts/build .../hollow/knight/Managed .../hollow/knight/Managed/Mods
# The DLL will be built and installed
```
