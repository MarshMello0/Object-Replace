Object Replace is a mod where players can easily add in custom .obj models with textures.

If you do it twice to the same object it will just stack on top sadly. 

[size=200]Commands
[/size]
All Commands start with "or"

replace 
replace is the main command in this mod and it takes two more args after it. eg "or replace objectType folderName"
the object types can be found with the command "or type", they are a list of available objects to replace (will be adding onto it when I have found more)
folderName is the folder which you place in the ObjectReplaceMod

help
help displays all the commands related to Object Replace

type
type will display a list of objects you can replace 

[size=200]How to Install
[/size]
1. Download [glow=blue]RaftModLoader[/glow] from [url=https://www.raft-modding.com/modloader.php]here[/url]
2. Download this mod's [glow=lime].dll file[/glow]
3. Run RaftModLoader. It will open the game after a moment. Once you're on the main menu you should see a new button on the top right called [color=#69ef5d]"Open Mods folder"[/color]
4. Click the "Open mods folder" button, the folder that opens up is where you should place the [glow=lime]contents of the zip[/glow]
5. [b][u]From now on, launch the game by running the RaftModLoader. Mods will not work unless Raft is launched from RaftModLoader.[/u][/b]

[size=200]How to add custom models
[/size]
1.Inside the ObjectReplaceMod folder, create a new folder. The name of folder you will use as the path in the command
2.Inside this new folder you have to have two files to make it work, one called "model.obj" and other called "texture.png"
(You can only have one texture image)

Then once in game with the mod loaded just use "or replace objectType folderName" and it should replace it.

With my tests I have found that some models are really big or really small so it depends on what size they where modelled at in the first place as I can't scale them down in the code.
