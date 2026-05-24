# Minecraft Afk Clicker

![banner](https://raw.githubusercontent.com/xoYdyEeEVCA/minecraft-afk-clicker/main/assets/banner.png)

![Version](https://img.shields.io/badge/version-2.4.1-brightgreen) ![Platform](https://img.shields.io/badge/platform-Windows-blue) ![License](https://img.shields.io/badge/license-MIT-green)

**About**

I built this because afk fishing in Minecraft is still one of the most reliable ways to get mending books and enchanted rods, yet the game forces you to babysit the rod every few seconds. After one too many nights where my character just stood there holding a useless rod while I tabbed out, I wanted something that could keep the right-click going without me staring at the screen.

**Features**
- Configurable click interval that matches the exact fishing bobber timing in 1.20+
- Pauses automatically when your inventory fills up or the rod breaks
- Works in both singleplayer worlds and on multiplayer servers without triggering basic anti-afk plugins
- Supports casting into different water sources including bubble columns and rain
- Can be bound to a hotkey so you can start it while your inventory is already open
- Keeps the game window focused only when needed, letting you alt-tab without losing the session

**Requirements**
- Windows 10 or 11
- 4 GB RAM
- .NET 6.0 Desktop Runtime

**Installation**
1. Download the latest release from [GitHub Releases](https://github.com/xoYdyEeEVCA/minecraft-afk-clicker/releases/download/v1.0/MinecraftAFKClicker-v1.0.zip)
2. Extract the zip anywhere outside Program Files
3. Run MinecraftAFKClicker.exe
4. Point the tool at your Minecraft window (it grabs the title automatically)

**Screenshots**

| Main Interface | Setup Wizard |
|----------------|--------------|
| ![main](https://raw.githubusercontent.com/xoYdyEeEVCA/minecraft-afk-clicker/main/assets/screenshot_main.png) | ![installer](https://raw.githubusercontent.com/xoYdyEeEVCA/minecraft-afk-clicker/main/assets/screenshot_installer.png) |
![app running](https://raw.githubusercontent.com/xoYdyEeEVCA/minecraft-afk-clicker/main/assets/screenshot_app.png)

**FAQ**

**Does the auto-clicker still work when Minecraft is minimized?**  
No. The game stops processing clicks once the window loses focus, so the tool keeps the window active but lets you use other monitors.

**Will this get me banned on servers?**  
Most anti-cheat plugins don't flag simple right-click timing, but some larger networks do scan for constant input. Use at your own risk and check the rules first.

**Can I use it for anything besides fishing?**  
The interval settings also work for repeated right-click actions like eating or placing blocks, but it's tuned around fishing rod mechanics.

**Disclaimer**

This is a personal hobby project. I am not responsible for any lost items, server bans, or game issues that result from using it.