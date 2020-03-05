# Dugreed Save Editor
This programs lets you decrypt dungreed save files so you can manually modify them and then it a lets you encrypt it back so the game can read the modified version.

## How to use
* Find the save file you want to modify in `<dungreed_location>\Dungreed_Data\StreamingAssets`. The files you want are the ones named with the format SlotX.uml, for this example I will talk about **Slot1.uml**
* (If you don't want to risk loosing your save file you might want to make a copy of the one you are going to modify)
* Then make another copy of the save file you want to modify and place it in the same directory that contains decryptor.exe and encryptor.exe
* Open a command prompt in the same directory as decryptor.exe
* In the command prompt, use the command `decryptor.exe Slot1.uml Slot1.xml`
* Open the **Slot1.xml** file in your favorite text editor and edit your save
* Once you are finished, use the command `encryptor.exe Slot1.xml Slot1.uml`
* Replace the Slot1.uml file in your Dungreed game directory by the one you have created with encryptor.exe
* ???
* Profit !


## Source code
If you want to compile the programs yourself or want to use the code, you can find it in the `src/` directory. To compile it just use a c# compiler on the source code as showed in the Makefile. The source code doesn't use anything fancy.
