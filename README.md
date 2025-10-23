## Audio Rename Tool
Audio Rename Tool is a simple Windows Forms utility (targeting .NET 8) that helps you preview audio files, copy/rename them into a RenamedFiles folder, and export a Lua file (Duckpack2.lua) formatted for Prop Hunt taunt packs.
### Features
•	Browse a folder and list audio files (.mp3, .wav, .wma, .aac, .ogg)

•	Preview selected audio files using the Windows Media Player ActiveX control

•	Convert .ogg files to .wav (temporarily) for playback using NReco.VideoConverter (FFmpeg)

•	Copy selected file into RenamedFiles with a new name (preserves original extension)

•	Track renamed files in-session and export a Lua file (Duckpack2.lua) that inserts entries for each renamed file into GAMEMODE.Prop_Taunts

## Requirements
•	Windows with Windows Media Player (for the ActiveX control)

•	Visual Studio 2022 (or newer) or dotnet CLI supporting .NET 8

•	.NET 8 runtime / SDK

•	NuGet package: NReco.VideoConverter

•	(Optional) FFmpeg binaries if conversion fails (NReco often bundles ffmpeg for common platforms but can require system ffmpeg in some setups)
