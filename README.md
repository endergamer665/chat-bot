

this is a collage progect of mine ive decided to make public under the GPL

i dont expect anyone to do anything with this and i will make it ony able to be forked for obvius resons

this is under dotnet 5.0 because my collage only has that so compile at your own risk


# Instalation

## Windows 
PowerShell 
### git instalation

```bash
git clone https://github.com/endergamer665/chat-bot.git
cd ./chat-bot
dotnet build -c Release
```
after compileing an exicutabel can be found in  

    /chat-bot/chat-bot/bin/Release/net5.0

to get rid of the souce code and make the a standalone portabel app run

```bash
cd ./chat-bot/bin/Release
Move-Item -Path "net5.0" -Destination "../../../../chatbot"
cd ../../../../
```
this creats a new file seperate file labeled chatbot to remove the souce code run

```bash
Remove-Item -Path "chat-bot" -Recurse -force
```

### zip instalation 