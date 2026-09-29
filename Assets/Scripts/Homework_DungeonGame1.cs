using UnityEngine;

// ==========================================================================
// THE DUNGEON - Homework (Intro to C#  +  Variables & Operators)
// --------------------------------------------------------------------------
// One growing program - keep building this SAME file.
//   PART A: do after the INTRO lecture (uses only Debug.Log).
//   PART B: finish after the VARIABLES lecture (variables & operators).
// Attach to an empty GameObject and press Play to test as you go.
// ==========================================================================
public class DungeonGame : MonoBehaviour
{
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
        bool has_key = false;
        int goblin_health = 50;
        int goblin_attack = 20;
        int goblin_armor = 10;
        int orc_health = 70;
        int orc_attack = 40;
        int orc_armor = 30;
        int rooms_entered = 0;
        // (PART B) TODO B1: declare your stats here, at the very top of Start,
        //          once you have had the Variables lecture. You will need:
        //            playerName (string), health (int), attack (int),
        //            agility (int), gold (int), hasKey (bool),
        //            goblinHealth (int), goblinAttack (int).

        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, Hero. Your escape begins."); // replace Hero with the name of your player.

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        Debug.Log("Next to the torch is a shelf with a scant few shillings of gold.");
        Debug.Log("Any gold is better than no gold, so you take the 5 gold.");
        gold += 5;
        Debug.Log("You now have " + gold + " gold.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("The sound of your footsteps awakens the goblin, you grab the rusty sword and fight.");
        while (health > 0 or orc_health > 0)
        {
            goblin_health -= ((attack * Random.Range(0,2)) / goblin_armor);
            health -= ((goblin_attack * Random.Range(0,1.5)) / armor);
            Debug.Log("Clash!");
        }
        if (goblin_health == 0)
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
        Debug.Log("You move into the next room.");
        Debug.Log("");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        Debug.Log("The Flooded Passage");
        // no semicolon
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        // no problems
        Debug.Log("You see something moving in the water, but can't tell what. Snakes rise out of the water and prepare to strike.");
        Debug.Log("You makes haste toward the exit, evading the snakes' strikes.");
        agility += 6;
        Debug.Log("Your quick escape has improved your agility. Your agility is now at " + agility + ".");
        Debug.Log("However, a rumble begins to eminate from behind a wall. Footsteps growing closer...");
        Debug.Log("Bursting through the wall, an orc arrives and is ready to attack anything that dare disturb him.");
        while (health > 0 or orc_health > 0)
        {
            int attack_turns = 0;
            attack_turns += 1;
            orc_health -= ((attack * Random.Range(0,2)) / orc_armor);
            if (attack_turns % 2 == 0)
            {
                health -= ((orc_attack * Random.Range(0,1.5)) / armor);
            }
            Debug.Log("Clash!");
        }
        if (goblin_health == 0)
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
        Debug.Log("A giant spider drops down from the ceiling, dripping acidic juice that violently reacts to the water.");
        Debug.Log("You quickly ready yourself for combat once again.")
        int spider_health = 80;
        int spider_attack = 40;
        int spider_armor = 10;
        bool poison_count = 0;
        while (health > 0 or spider_health > 0)
        {
            int attack_turns_1 = 0;
            attack_turns_1 += 1;
            if (poison_count > 0)
            {
                health -= 2;
                poison_count -= 1;
            }
            spider_health -= ((attack * Random.Range(0,2)) / spider_armor);
            if (attack_turns_1 % 2 == 0)
            {
                health -= ((spider_attack * Random.Range(0,1.5)) / armor);
                poison_count = 3;
            }
            Debug.Log("Clash!");
        }
        if (goblin_health == 0)
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
        Debug.Log("You move into the next room.");
        // no problems
        Debug.Log("The exit leads into a hallway, dimly lit by the warm glow of a campfire.");
        Debug.Log("After all that fighting, you decide that taking a rest by a calm, warm fire sounds like a welcome break.");
        Debug.Log("You take a seat by the campfire. Despite the fire looking like it's going to go out soon, you can feel the fire's warmth rejuvinating you.");
        int fire_turns = 5;
        while (health < 100 or fire_turns > 0)
        {
            health += 3;
            fire_turns -= 1;
        }
        if (fire_turns == 0)
        {
            Debug.Log("The campfire has burned out. Seems like it's time to keep going.");
        }
        Debug.Log("You feel better after taking a rest. Your health is now at " + health + ".");
        Debug.Log("The hallway splits into two paths. One path is blocked by a door that requires a key to unlock.");

        if (has_key == true)
        {
            Debug.Log("You use your key to unlock the door and go inside.");
            rooms_entered += 1;
            if (rooms_entered % 3 == 0)
            {
                Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
            }
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
        else
        {
            Debug.Log("You don't have a key for the door, so it seems your only option is to go down the other path.");
            Debug.Log("The shopping corner");
            rooms_entered += 1;
            if (rooms_entered % 3 == 0)
            {
                Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
            }
            Debug.Log("You find what looks like a shop containing some potions and jarred foods, but there doesn't seem to be anyone running the shop. There's just a worm on the table.");
            Debug.Log("Oh, the worm is running the shop. The worm offers you some health potions and food to buy.");
            Debug.Log("Each potion costs 5 gold. You can afford " + (gold / 5) + " potions, with " + (gold % 5) + " gold left.");
        }
        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        Debug.Log("The Dining Hall");
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        Debug.Log("All the food has rotted and decayed. The insects and vermin are having a feast. A swarm of ants are gathered around a tapestry.");
        Debug.Log("You approach the tapestry and move it aside, revealing a dark tunnel. Seeing no other way out, you enter the tunnel and move onto the next room");

        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.
        Debug.Log("The Exit Room");
        rooms_entered += 1;
        if (rooms_entered % 3 == 0)
        {
            Debug.Log("The room has a faint red glow, unclear of where it's coming from.");
        }
        Debug.Log("The tunnel has lead you to a hidden room. A room seemingly made for emergency evacuations, but why would people need to escape a dungeon in such haste?");
        Debug.Log("You notice a vault in the corner of the room. It's locked and requires a key to open.");
        if (has_key == true)
        {
            Debug.Log("You use your key to unlock the vault. Inside, there is 200 gold and a note. You take the gold and the note, intending to read it later.");
            gold += 200;
        }
        else
        {
            Debug.Log("Unfortunately, you don't have a key that matches the vault, so all you can do is move on.");
        }
        Debug.Log("You see a ladder leading to a trap door on the ceiling. You open the trap door and find yourself outside the dungeon.");

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
    }
}
