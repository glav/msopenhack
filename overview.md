# Microsoft Open Hack Containers

## OpenHack
Hello and welcome to OpenHack, a challenge oriented hack event from Microsoft. From here you will be presented with a series of challenges, each one more difficult than the one before.

You should already be assigned to and seated with a team, with whom you will attempt to solve as many challenges as you can within today’s hack time

You have been assigned a coach who will be your first point of contact, and is here to support you and answer questions during the hack. They will not however solve the challenges for you.

## The Premise
You are the R&D team for a startup that wants to investigate the technical viability of renting out Minecraft server instances online. The business model is already well established in the market. Customers pay a fixed fee for access to an online multiplayer Minecraft server, or even a dedicated server of their own.

## The challenges
Each challenge will lead you through a stage of the technical investigation as briefly laid out by your fictional CTO, these investigations become more technically challenging as you progress.

We do not provide guides, or instructions to solve the challenges, just a few hints and documentation references that you may find useful. There are multiple ways to solve each challenge, and very likely some we haven’t thought of, so whilst we have automated validation of the most common solutions, we’re interested to see your own unique solutions to the problem, and you should absolutely work with your coaches and the OpenHack Team to validate your solution as correct.

One final tip: Read everything very carefully
The Openhack team have worked hard to ensure each problem is solvable, all the details you should need are within the challenge briefs, which are very carefully written and worded, to give you clues toward the solution, reading them fully is the best way to figure out a solution, and small points can be easily missed. Your coaches will help to fill gaps in your understanding, provided you ask them the right questions of course.

## Reference
The following information aims to give you a good understanding of Minecraft you may find helpful while working through the challenges.

### 1. Minecraft Servers
This OpenHack focuses on deploying older ‘Java’ Minecraft servers, we’ve taken the liberty of providing a custom container for these.

### 2. Minecraft Client & License
In order to test connections to your Minecraft servers, you’ll need the Minecraft Java Edition client for PC/Mac, and a Minecraft Account. You can find the download at Minecraft.net/Download

You’ll need to Create an Account before you login. You should find a ‘secret code’ on your Event Details sheet provided to you, this is a Minecraft License code and give you a full, permanent minecraft license for you to keep after the event.

### 3. Protocol: TCP
The Minecraft server accepts connections via TCP, not HTTP/REST

### 4. Container Images & Ports
- Find the Minecraft images on Docker Hub
- There are two ports of interest:
- Default Minecraft port: 25565
- Default RCON port: 25575

### 5. State
Minecraft server state is handled by a write-only operation to disk in the default ‘data’ directory. The server does not do any verification on the state. This means that if two Minecraft servers share that same default directory, they will overwrite each-others data.

### 6. Helpful 3rd Party Tools
If you need to get information from a Minecraft server, these tools are usually the first stop for most common requirements:

- [Minecraft Server Status Checker](https://dinnerbone.com/minecraft/tools/status/): Quickly check to see if your server is up and running.
- [Minecraft Status Info API](http://mcapi.us/): Get simple information about the status of your server.
- [mcstatus](https://github.com/Dinnerbone/mcstatus): The underlying code for the Minecraft Server Status Checker.

### 7. Server Commands
Here are the descriptions of some server commands you may encounter.


|**command**|**description**|
|--|--|
|ban <playername> [reason]|Blacklists the name playername from the server so that they can no longer connect|
|banlist|Displays the banlist. To display banned IP addresses, use the command banlist ips|
|list|Shows the names of all currently-connected players|
|stop|Gracefully shuts down the server|