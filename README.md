# D3FAU4TBOT Hub

An all in one management hub for D3FAU4TBOT in C#

You can download the latest version from the [Release](https://github.com/D3FAU4T/D3FAU4TBOT-Hub/releases) Section.

## Features
- You can access the Editor module and create/submit new levels.
- You can now check for updates from within the app

These are the 2 features I included so far. Please be patient as I work on more features :)

<br>
Small previews of the current state of the app:

1. https://cdn.discordapp.com/attachments/920832476606234664/1104456059269156965/image.png
2. https://cdn.discordapp.com/attachments/920832476606234664/1104456135697764372/image.png
3. https://cdn.discordapp.com/attachments/920832476606234664/1104456469467893781/image.png
4. https://cdn.discordapp.com/attachments/920832476606234664/1104456678839165008/image.png


## For developers

### How to get the code to contribute:

- Download the code using `git clone https://github.com/D3FAU4T/D3FAU4TBOT-Hub.git` or manually download the `zip` file.
- Download the Assets from [here](https://github.com/D3FAU4T/D3FAU4TBOT-Hub/releases/download/v1.1.0/Assets.zip)
- If you use OneDrive services, paste the Assets folder in `C:\Users\<YourName>\OneDrive\Documents\D3FAU4TBOT Hub` else paste in `C:\Users\<YourName>\Documents` (See Reason Below)
- Open the Solution file (`.sln`) in Visual Studio. (Not VS Code)
- Let the project open and then press the start button to debug the app.
- If you want to build the standalone app, Right-click on the Solution file in Solution explorer and then click build solution.

### Why Assets is not provided in the branch?

This project intends to install Assets only one time so if another update releases, you don't have to download it again thus saving a lot of data. However, with every release, I'll try to provide 2 installer.

1. Full installer
2. Updater

The Full installer is intended to install everything including Assets if you're installing for the first time.
The Updater is intended to update only the necessary files leaving the Assets thus saving the download data and making the download faster.
