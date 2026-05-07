![Status](https://img.shields.io/badge/Status-Complete-success?style=for-the-badge)
![Framework](https://img.shields.io/badge/.NET-10-blueviolet?style=for-the-badge)
# Cyber Defender CG Version 1.0

Welcome to the Cyber Defender. This project is a fantasy-themed Card Game (CG) centered
around cybersecurity defense strategies. You will identify digital threats and deploy defensive
counters to protect the network.

️ System Requirements & Dependencies

To ensure a stable with the game database, the following dependencies must be installed:
For Windows Users

● Microsoft Access Database Engine 2016 Redistributable: Required to process the
.accdb game data.

● .NET Runtime: The simulation is built on the .NET 10.0 framework.

For Linux Users (via Bottles)

● Environment: Gaming Bottle.

● Dependencies: dotnet10 (or latest) and msade12 (Access Data Engine).

🚀 Installation Instructions

Windows Deployment

1. Extract: Right-click the distributed ZIP and select Extract All.
   
2. Driver Install: Run accessdatabaseengine.exe located in the root folder.
   
3. Launch: Open Cyber_DefenderTCG.exe. If prompted by Windows SmartScreen, select
More Info > Run Anyway.

Linux Setup (Bottles

1. Create a new Gaming bottle named CyberDefender.
   
2. Install dotnet and msade12 via the Dependencies tab.
   
3. Add Cyber_DefenderTCG.exe as a shortcut and click Play.
   
🎮 Gameplay Features

● Cybersecurity Defense: Use defense cards to counter various digital threats.

● Anomaly System: Encounter random system anomalies that affect the UI and gameplay
stability.

● Rank Progression: Progress from a Script Kiddie to a Grand Architect as you gain XP
from matches.

📂 Project Structure

● Cyber_DefenderTCG.exe: The main simulation executable.

● CyberDefenderDatabase.accdb: The core database containing card data, user
accounts, and match logs.

● Assets/: Contains the background music and sound effect protocols.

● runtimes/: Essential library dependencies for cross-platform compatibility.

‍ Development

Lead Architect: Mark G

Platform: Developed on Winforms using the Visual Studio and C#/.NET Core.
