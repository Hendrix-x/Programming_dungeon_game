using UnityEngine;

// ==========================================================================
// THE DUNGEON - Homework (Intro to C#  +  Variables & Operators)
// --------------------------------------------------------------------------
// One growing program - keep building this SAME file.
//   PART A: do after the INTRO lecture (uses only Debug.Log).
//   PART B: finish after the VARIABLES lecture (variables & operators).
// Attach to an empty GameObject and press Play to test as you go.
// ==========================================================================
public class Homework_dungeonGame3 : MonoBehaviour
{
    string[] roomName = { "The Entrance Hall", "The Guard Room", "The Flooded Passage", "The Split Hallway",
    "???", "The Shopping Corner", "The Dining Hall", "The Exit Room"};
    string[] roomDescription = { "A torch flickers on the wall. A stone doorway leads north.",
        "A rusty sword rests on a table. A goblin snores in the corner.",
    "Ankle-deep water fills the hall. A broken door is at the end of the hallway.",
    "The exit leads into a hallway, dimly lit by the warm glow of a campfire.",
    "The room is dark, only lit up by a torch at the end of the room, illuminating another door.",
    "You find what looks like a shop containing some potions and jarred foods, but there doesn't seem to be anyone running the shop. There's just a worm on the table.",
    "All the food has rotted and decayed. The insects and vermin are having a feast. A swarm of ants are gathered around a tapestry.",
    "The tunnel has lead you to a hidden room. A room seemingly made for emergency evacuations, but why would people need to escape a dungeon in such haste?"};
    void Start()
    {
        string player_name = "Knight";
        int health = 100;
        int attack = 25;
        int armor = 20;
        int fire_damage = 20;
        int agility = 50;
        float defense = 1.5f; // max defense should be 3
        int gold = 15;
        int[] roomGold = { 5, 10};
        string[] inventory = { "", "", "", "" };
        string[] rewards = { "crimson sword", "stamina potion", "iron shield", "health potion", "steel boots" };
        string[] enemyName = { "Goblin", "Orc", "Spider" };
        int[] enemyHealth = { 50, 70, 80};
        int[] enemyAttack = { 20, 40, 40 };
        int[] enemyDefense = { 10, 30, 10 };
        int[] roomEnemy = { -1, 0, 1, -1, -1, -1, -1, -1 };
        
        int room_number = 0;
        int rooms_entered = 0;
        bool[] roomsVisited = { false, false, false, false, false, false, false, false };
        // (PART B) TODO B1: declare your stats here, at the very top of Start,
        //          once you have had the Variables lecture. You will need:
        //            playerName (string), health (int), attack (int),
        //            agility (int), gold (int), hasKey (bool),
        //            goblinHealth (int), goblinAttack (int).

        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + player_name + ". Your escape begins."); // replace Hero with the name of your player.

        for(int r = 0; r < roomName.Length; r++)
        {
            Debug.Log(roomName[r]);
        }

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log(roomName[room_number]);
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        roomsVisited[room_number] = true;
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        Debug.Log("Next to the torch is a shelf with a scant few shillings of gold.");
        Debug.Log("Any gold is better than no gold, so you take the " + roomGold[0] + " gold.");
        gold += roomGold[0];
        Debug.Log("You now have " + gold + " gold.");
        Debug.Log("You move into the next room.");
        room_number += 1;
        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log(roomName[room_number]);
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        roomsVisited[room_number] = true;
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        if (roomEnemy[room_number] != -1)
        {
            Debug.Log("The sound of your footsteps awakens the goblin, you grab the rusty sword and fight.");
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "sword";
                    break;
                }
            }
            while (health > 0 || enemyHealth[0] > 0)
            {
                int damageBonus = 0;
                for (int s = 0; s < inventory.Length; s++)
                {
                    if (inventory[s] == "sword")
                    {
                        damageBonus += 5;
                        break;
                    }
                }
                enemyHealth[0] -= (((attack + damageBonus) * Random.Range(0, 2)) / enemyDefense[0]);
                health -= ((enemyAttack[0] * Random.Range(0, 2)) / armor);
                Debug.Log("Clash!");
            }
            if (enemyHealth[0] == 0)
            {
                Debug.Log("Your battle is victorious, but not without struggle. You have " + health + " hp left.");
            }
            if (health >= 70)
            {
                Debug.Log("Your condition is still strong enough to continue going");
            }
            else if (health >= 50)
            {
                Debug.Log("Your health could be better, but still with the strength to go on.");
            }
            else if (health >= 20)
            {
                Debug.Log("You are in a quite rough state. It's compelling to stop right here, but not now.");
            }
            if (health <= 0)
            {
                Debug.Log("Your journey has come to an unfortunate end...");
            }
        }
        Debug.Log("You move into the next room.");
        Debug.Log("");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        room_number += 1;
        Debug.Log("The Flooded Passage");
        // no semicolon
        Debug.Log(roomName[room_number]);
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        roomsVisited[room_number] = true;
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        // no problems
        Debug.Log("You see something moving in the water, but can't tell what. Snakes rise out of the water and prepare to strike.");
        Debug.Log("You makes haste toward the exit, evading the snakes' strikes.");
        agility += 6;
        Debug.Log("Your quick escape has improved your agility. Your agility is now at " + agility + ".");
        if (roomEnemy[room_number] != -1)
        {
            Debug.Log("However, a rumble begins to eminate from behind a wall. Footsteps growing closer...");
            Debug.Log("Bursting through the wall, an orc arrives and is ready to attack anything that dare disturb him.");
            while (health > 0 || enemyHealth[1] > 0)
            {
                int attack_turns = 0;
                attack_turns += 1;
                int damageBonus = 0;
                for (int s = 0; s < inventory.Length; s++)
                {
                    if (inventory[s] == "sword")
                    {
                        damageBonus += 5;
                        break;
                    }
                }
                enemyHealth[1] -= (((attack + damageBonus) * Random.Range(0, 2)) / enemyDefense[1]);
                if (attack_turns % 2 == 0)
                {
                    health -= ((enemyAttack[1] * Random.Range(0, 2)) / armor);
                }
                Debug.Log("Clash!");
            }
            if (enemyHealth[1] == 0)
            {
                Debug.Log("Your battle is victorious, but not without struggle. You have " + health + " hp left.");
            }
            if (health >= 70)
            {
                Debug.Log("Your condition is still strong enough to continue going");
            }
            else if (health >= 50)
            {
                Debug.Log("Your health could be better, but still with the strength to go on.");
            }
            else if (health >= 20)
            {
                Debug.Log("You are in a quite rough state. It's compelling to stop right here, but not now.");
            }
            if (health <= 0)
            {
                Debug.Log("Your journey has come to an unfortunate end...");
            }
            Debug.Log("You have successfully slain the orc. A tough but well fought battle.");
            Debug.Log("You begin to relax after the battle, but you quickly tense back up after hearing a hiss from the pitch black ceiling...");
        }
        if (roomEnemy[room_number] != -1)
        {
            Debug.Log("A giant spider drops down from the ceiling, dripping acidic juice that violently reacts to the water.");
            Debug.Log("You quickly ready yourself for combat once again.");

            int poison_count = 0;
            while (health > 0 || enemyHealth[2] > 0)
            {
                int damageBonus = 0;
                for (int s = 0; s < inventory.Length; s++)
                {
                    if (inventory[s] == "sword")
                    {
                        damageBonus += 5;
                        break;
                    }
                }
                int attack_turns_1 = 0;
                attack_turns_1 += 1;
                if (poison_count > 0)
                {
                    health -= 2;
                    poison_count -= 1;
                }
                enemyHealth[2] -= (((attack + damageBonus) * Random.Range(0, 2)) / enemyDefense[2]);
                if (attack_turns_1 % 2 == 0)
                {
                    health -= ((enemyAttack[2] * Random.Range(0, 2)) / armor);
                    poison_count = 3;
                }
                Debug.Log("Clash!");
            }
            if (enemyHealth[2] == 0)
            {
                Debug.Log("Your battle is victorious, but not without struggle. You have " + health + " hp left.");
            }
            if (health >= 70)
            {
                Debug.Log("Your condition is still strong enough to continue going");
            }
            else if (health >= 50)
            {
                Debug.Log("Your health could be better, but still with the strength to go on.");
            }
            else if (health >= 20)
            {
                Debug.Log("You are in a quite rough state. It's compelling to stop right here, but not now.");
            }
            if (health <= 0)
            {
                Debug.Log("Your journey has come to an unfortunate end...");
            }
            Debug.Log("The giant spider has been slain. Acid oozes out of its head as it collapses to the floor.");
            Debug.Log("You avoid the acid and make your way to the exit.");
        }
        Debug.Log("You move into the next room.");
        // no problems
        room_number += 1;
        Debug.Log(roomName[room_number]);
        roomsVisited[room_number] = true;
        Debug.Log("The exit leads into a hallway, dimly lit by the warm glow of a campfire.");
        Debug.Log("After all that fighting, you decide that taking a rest by a calm, warm fire sounds like a welcome break.");
        Debug.Log("You take a seat by the campfire. Despite the fire looking like it's going to go out soon, you can feel the fire's warmth rejuvinating you.");
        int fire_turns = 5;
        while (health < 100 || fire_turns > 0)
        {
            health += 3;
            fire_turns -= 1;
        }
        if (fire_turns == 0)
        {
            Debug.Log("The campfire has burned out. Seems like it's time to keep going.");
        }
        Debug.Log("You feel better after taking a rest. Your health is now at " + health + ".");
        Debug.Log("In the darkness, you notice a few sparse bits of gold on the ground. About " + roomGold[1] + " gold.");
        gold += roomGold[1];
        Debug.Log("You gather all the gold together and keep it. You now have " + gold + " gold left.");
        Debug.Log("The hallway splits into two paths. One path is blocked by a door that requires a key to unlock.");

        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == "key")
            {
                Debug.Log("You use your key to unlock the door and go inside.");
                room_number += 1;
                Debug.Log(roomName[room_number]);
                rooms_entered += 1;
                if (rooms_entered % 3 == 0)
                {
                    Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
                }
                roomsVisited[room_number] = true;
                Debug.Log("The room is dark, only lit up by a torch at the end of the room, illuminating another door.");
                Debug.Log("As you approach the door, you hear a faint grumble.");
                Debug.Log("You move toward the door slightly faster, but suddenly, a burst of fire erupts from out of the darkness of the room!");
                Debug.Log("You took " + fire_damage + " damage from the fire. You quickly dodge out of the way. You decide to make a break for the door, too distracted to try to see what shot fire at you.");
                health -= fire_damage;
                if (health >= 70)
                {
                    Debug.Log("Your condition is still strong enough to continue going");
                }
                else if (health >= 50)
                {
                    Debug.Log("Your health could be better, but still with the strength to go on.");
                }
                else if (health >= 20)
                {
                    Debug.Log("You are in a quite rough state. It's compelling to stop right here, but not now.");
                }
                if (health <= 0)
                {
                    Debug.Log("Your journey has come to an unfortunate end...");
                }
                Debug.Log("You escape the room, but not without wondering what was in that room. A trap? A monster? Are you equipped to take it on?");
                Debug.Log("You decide to keep that room in mind. Hopefully you can come back to it when you are more prepared.");
            }
            if (inventory[inventory.Length - 1] == "")
            {
                Debug.Log("You don't have a key for the door, so it seems your only option is to go down the other path.");
                Debug.Log("The shopping corner");
                room_number += 2;
                Debug.Log(roomName[room_number]);
                rooms_entered += 1;
                if (rooms_entered % 3 == 0)
                {
                    Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
                }
                roomsVisited[room_number] = true;
                Debug.Log("You find what looks like a shop containing some potions and jarred foods, but there doesn't seem to be anyone running the shop. There's just a worm on the table.");
                Debug.Log("Oh, the worm is running the shop. The worm offers you some health potions and food to buy.");
                Debug.Log("Each potion costs 5 gold. You can afford " + (gold / 5) + " potions, with " + (gold % 5) + " gold left.");
                if (gold >= 5)
                {
                    for (int ii = 0; ii < inventory.Length; ii++)
                    {
                        if (inventory[ii] == "")
                        {
                            inventory[ii] = "potion";
                            Debug.Log("You buy a potion. It may be helpful in the future.");
                            break;
                        }
                    }
                }
                Debug.Log("You progress on to the next room.");
            }
        }
        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        room_number += 1;
        Debug.Log("The Dining Hall");
        Debug.Log(roomName[room_number]);
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        roomsVisited[room_number] = true;
        Debug.Log("All the food has rotted and decayed. The insects and vermin are having a feast. A swarm of ants are gathered around a tapestry.");
        Debug.Log("You approach the tapestry and move it aside, revealing a dark tunnel. Seeing no other way out, you enter the tunnel and move onto the next room");

        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.
        room_number += 1;
        Debug.Log("The Exit Room");
        Debug.Log(roomName[room_number]);
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        roomsVisited[room_number] = true;
        Debug.Log("The tunnel has lead you to a hidden room. A room seemingly made for emergency evacuations, but why would people need to escape a dungeon in such haste?");
        Debug.Log("You notice a vault in the corner of the room. It's locked and requires a key to open.");
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == "key")
            {
                Debug.Log("You use your key to unlock the vault. Inside, there is 200 gold and a note. You take the gold and the note, intending to read it later.");
                gold += 200;
                break;
            }
            if (inventory[inventory.Length - 1] == "")
            {
                Debug.Log("Unfortunately, you don't have a key that matches the vault, so all you can do is move on.");
            }
        }
        Debug.Log("You see a ladder leading to a trap door on the ceiling. You open the trap door and find yourself outside the dungeon.");

        Debug.Log("Your final inventory: ");
        for (int i = 0; i < inventory.Length; i++)
        {
            Debug.Log(inventory[i]);
        }
        Debug.Log("Rewards: ");
        for (int r = 0; r < rewards.Length; r++)
        {
            Debug.Log(rewards[r]);
        }

        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        //int gold = 15;
        // nothing was wrong
        Debug.Log("The Treasure Room");
        // lack of quotation marks
        Debug.Log("It seems this room has been raided. You find " + 5000 + " gold.");
        // nothing was wrong
        Debug.Log("You move into the next room.");
        // lack of ending quotation marks and semicolon

        // TODO B3: Go back through your rooms above and add an event/item to each
        //          one that changes a stat/variable, printing the new value right
        //          after the event. Like with the gold in the treasure room, keep
        //          each event inside the room where it happens. Possible events:
        //            pick up a sword to increase attack      
        //            step on a trap        
        //            grab the rusty key    
        //            (your own event)

        // TODO B4: In the appropriate room, add a goblin. The goblin attacks the
        //          player and the player attacks the goblin. Use the variables
        //          you've created in PART A to simulate this with code. After the
        //          simulation is done, Print both healths, then print whether or 
        //          not the goblin is defeated. 

        // TODO B5: Add a new room somewhere before the exit that has a merchant. 
        //          The merchant sells potions for 5 gold each. Print how many
        //          potions you can afford and how much gold you will have left over. 

        // TODO B6: Add a defense stat (declare it up top with the others). Use it
        //          in your combat so the goblin's hit damage is reduced by your
        //          defense and your hit damage is reduced by the goblin's defense
        //          Then, add an item that raises defense in a room. 

        // ================= PART A - CONDITIONALS (do after L7) =================

        // A1: After the goblin fight, report whether the goblin was defeated or
        //     the hero was the one who fell. (done)

        // A2: At a vault door, the hero may pass only if they are carrying the
        //     key and are still alive. If they cannot pass, report which of the
        //     two requirements they are missing. (Done)

        // A3: The passage forks in two. Send the hero down one of the routes and
        //     describe each one - the two routes may even rejoin at the same
        //     place further on. (done)

        // A4: As the hero explores, every third room they enter has a red glow.
        //     Given the number of the room the hero is standing in, report
        //     whether this room has the red glow. (done)

        // A5: Whenever the hero takes damage, report their condition: collapsed
        //     if no health remains, badly wounded if their health has dropped
        //     dangerously low, or otherwise hurt but steady. This is a snippet
        //     you will reuse a lot - go back through everything you have already
        //     written (INCLUDING your previous assignment) and drop it in right
        //     after every place the hero loses health (the spike trap, and
        //     anywhere else). You will add it again in Part B after each hit the
        //     hero takes in a fight. (done)



        // ================= PART B - LOOPS (do after L8) =================

        // Place the following combat encounters in different rooms of your choice.

        // B1: A goblin blocks the way - fight it round by round until one of you
        //     runs out of health. Give the hero and the goblin each an armor
        //     class. On every swing, roll a die (Random.Range works well) and
        //     compare it to the target's armor class: the blow only lands if the
        //     roll meets or beats that armor class. On top of that, any of the
        //     hero's landed hits can be a critical hit that deals extra damage.
        //     Report each roll and its result, and after any round in which the
        //     hero takes damage, run your A5 condition check. (done)

        // B2: Beyond the goblin waits an ogre - slow, but brutal. Fight it the
        //     same way (armor classes, dice rolls to hit, and the hero's chance
        //     to crit), except the ogre is so sluggish it only swings every
        //     other round. Fight until one of them falls, and keep running your
        //     A5 check whenever the hero takes damage. (done)

        // B3: Then a giant spider drops from the ceiling. Fight it just like the
        //     ogre - dice-and-armor-class swings, the hero's crits, and it too
        //     only strikes every other round - but its bite is venomous: any
        //     time it lands a hit, the hero is poisoned and loses 2 health at
        //     the start of each of the next three rounds, on top of the bite
        //     itself. Fight until one of them falls, running your A5 check after
        //     any damage (including the poison ticks). (done)

        // B4: With the fights behind them, the hero rests at a campfire,
        //     recovering a little health each turn until fully healed or the
        //     fire dies after a set number of turns. Report their health as it
        //     climbs, and never let it rise above the maximum.

        //================== PART 3 ============================================

        // A1: ROOMS INTO ARRAYS. Put your existing room names and descriptions into
        //     two arrays (roomNames[i] and roomDescsriptions[i] describe the SAME
        //     room). Keep the same rooms you already have (do not add or remove any).
        // 
        //     Hint: How many elements should be in the roomNames array? What about
        //     the roomDescriptions array? Should they be different lengths or the same?
        //      (done)



        // A2: SHOW THE MAP. At the very start of the game, output every room name with
        //     a single loop (a quick map of the dungeon) using Debug.Log
        //
        //      Hint: What new type of loop can you use for this that works specifically
        //      with containers?
        //      (Done)



        // A3: MOVE BY INDEX. Keep a currentRoom number that starts at 0. Each time the
        //     player moves on, add 1 to it and show that room's name and description
        //     from the arrays, instead of hand-writing each room's header.
        //      (done)



        // A4: ONE INVENTORY ARRAY. Replace your separate item flags (hasKey, the
        //     sword, the shield, and so on) with a single inventory array. Add an item
        //     to it each time the player picks something up.
        //
        //     Hint: How big does this array need to be? What data type should it be?
        //      (done)



        // A5: SHOW THE LOOT. At the end of the run, print the player's whole inventory
        //(done)



        // A6: KEY FROM THE INVENTORY. At the vault door, do not use a hasKey bool.
        //     Check whether "key" is in the inventory array to decide if the hero may
        //     pass.
        //     
        //     Hint: How could you use what we've previously learned (loops and ifs) to
        //     find if a specific item is in an array?
        //      (done)



        // A7: COMBAT ITEMS, NOT PERMANENT UPGRADES. Right now picking up the
        //     sword or shield permanently raises attack or defense. Stop doing that. Leave the
        //     Do not increase the base stats (attack and defense) of the player.
        //
        //     Instead, INSIDE each fight, check the inventory and apply the appropriate bonus
        //     only in the attack and damage calculations. For example:
        //     If the hero is carrying the sword, add swordBonus to the attack and damage roll
        //     If the hero is carrying the shield, subtract shieldBonus when reducing damage taken
        //      (done)



        // A8: ENEMIES INTO ARRAYS (the data, not the encounters). Right now each enemy
        //     is a pile of separate variables (goblinHealth, goblinAttack, ogreHealth,
        //     and so on). Put them into arrays instead (enemyNames[], enemyHealth[],
        //     enemyAttack[], enemyArmorClass[] and enemyDefense[]), one array element
        //     per enemy (element 0 = goblin, element 1 = ogre, element 2 = spider)
        //    Keep each fight in its OWN room and read the enemy from the arrays by index.
        //
        //     Hint: How many arrays do you need? How many elements per array?
        //      (done)



        // A9: GOLD BY ROOM. Store the gold each room holds in a roomGold[] array and
        //     total it with a loop, instead of adding gold by hand in each room. As the player
        //     walks through each room, add however much gold is in the room to the player's
        //     overall gold.
        //
        //     Hint: How many elements do you need in this array? What should you do if
        //     a room doesn't have gold in it?
        //      (done)



        // A10: ROOM ENEMIES. Create a roomEnemy[] array alongside your room arrays,
        //      one slot per room, holding the index of the enemy waiting there (or -1 for none).
        //      As currentRoom advances, if roomEnemy[currentRoom] is not -1, run the
        //      enemy's fight. This ties each enemy to its room through the arrays.
        //
        //      Hint: What data type should the roomEnemy array be if it is an array of indexes?
        //      (done)



        // A11: TRACK VISITED ROOMS: Create a "visited" array of bools, one per room,
        //      so you can mark the rooms the player has already been through.
        //
        //      Hint: How big should this array be? What data type should it be? What should
        //      the starting values be?
        //      (done)



        // A12: LOOT TABLE: an array of possible rewards. Print the whole table (or
        //      pick from it) with a loop instead of writing each reward out by hand. We won't
        //      be using this table for anything yet, but add at least three possible rewards.
        //      Example rewards could be some kind of healing item, weapon, armor, etc.
        //      (done)
    }
}
