... #speaker:??? #portrait:dinotrainer_neutral #layout:right
* [Hello?]
    ...
    <i>The dino stares at you intensely</i>
    ** [...]
        Oh, you noticed me!
        -> dino_intro
    ** [Stare back intensely]
        Finally, someone knows how to respond!
        -> dino_intro
* [Continue to dungeon]
<i>You ignore the dino and proceed into the dungeon.</i>
    -> DONE
=== dino_intro ===
Those applicants that just entered the dungeon were really boring.
They straight up ignored me!
* [Who're you]
Oh, you want to know who I am? 
Hehe.
That's something I only share to people who pass this combat exam.
Anyways,
Want to learn about the dungeon's secrets?
** [What secrets?]
    -> game_mechanics_info
** [I already know its secrets]
    Ah, you must be some sort of genius then.
    No one is supposed to know the dungeon's secrets.
    That's amazing!
    You MUST come visit the <b><color=\#c90076>training room</color></b> if you pass the exam!
    I will prepare a reward that'll be worth your visit!
    <i>You prepare to enter the dungeon, and gestured goodbye to the dino</i>
    -> DONE
=== game_mechanics_info ===
I'm sure you've noticed the chest at the bottom left of your screen.
If you click that chest you will open up the player menu.
It consists of three columns:
The left column is the dungeon simulation's weapon upgrading system.
I'm guessing you know about the gold coins?
I'm not supposed to tell you this, but the gold coins are used to upgrade your weapon.
The number below the weapon represents the cost to upgrade the weapon.
Left-click the number with enough gold coins will upgrade your weapon.
You can upgrade your weapon a total of 9 times with each upgrade increasing its damage and push force.
Push force is basically how much knockback the enemy takes when you hit them.
Higher push force equals stronger knockback.
The right column is your "dungeon stats".
It's basically a way to show how many gold coins and health you have, as well as your level.
The middle column is just your avatar. You can change it to the dungeon's presets if you like.
Oh, I almost forgot.
The purple bar at the bottom is your "dungeon experience".
It's used to keep track of how close you are to "levelling up".
You gain 5 health each time you level up.
You also feel any injuries you have appear to be healed each time you level up.
The maximum level is 10, by the way.
There are a total of five levels to this dungeon.
The first level is a preliminary level to eliminate the unprepared applicants.
However, the other four levels get much harder as you progress.
Each boss at the end of each level becomes more difficult to defeat, especially the last one.
You should be fine anyways.
I should get going before I get caught by the staff.
Good luck on the exam!
Oh, and if you do pass the exam come by the <b><color=\#c90076>training room.</color></b> I'll be waiting!
-> END