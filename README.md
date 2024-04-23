# ReStreamer

Quick demo of re-streaming files located in remote locations!

## Spinning up the service

- VS Code: use the included profile
- cli: `dotnet run --project ./ReStreamer/ReStreamer.csproj --urls http://localhost:5138`

## Try it out!

- http://localhost:5138/stream?url=https://download.samplelib.com/mp3/sample-15s.mp3
- http://localhost:5138/stream?url=https://download.samplelib.com/mp4/sample-5s.mp4
- http://localhost:5138/stream?url=https://download.samplelib.com/png/sample-boat-400x300.png
