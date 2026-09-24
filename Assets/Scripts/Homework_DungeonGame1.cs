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
        int agility = 50;
        float defense = 1.5f; // max defense should be 3
        int gold = 15;
        bool has_key = false;
        int goblin_health = 50;
        int goblin_attack = 20;
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
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        Debug.Log("Next to the torch is a shelf with a scant few shillings of gold.");
        Debug.Log("Any gold is better than no gold, so you take the 5 gold.");
        gold += 5;
        Debug.Log("You now have " + gold + " gold.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("The sound of your footsteps awakens the goblin, you grab the rusty sword and fight.");
        goblin_health = 0;
        health -= goblin_attack;
        Debug.Log("Your battle is victorious, but not without struggle. You took " + (goblin_attack  / defense) + " damage.");
        Debug.Log("You have " + health + " hp left.");
        Debug.Log("You move into the next room.");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        Debug.Log("The Flooded Passage");
        // no semicolon
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        // no problems
        Debug.Log("You see something moving in the water, but can't tell what. Snakes rise out of the water and prepare to strike.");
        Debug.Log("You makes haste toward the exit, evading the snakes' strikes.");
        agility += 6;
        Debug.Log("Your quick escape has improved your agility. Your agility is now at " + agility + ".");
        Debug.Log("You move into the next room.");
        // no problems

        Debug.Log("The shopping corner");
        Debug.Log("You find what looks like a shop containing some potions and jarred foods, but there doesn't seem to be anyone running the shop. There's just a worm on the table.");
        Debug.Log("Oh, the worm is running the shop. The worm offers you some health potions and food to buy.");
        Debug.Log("Each potion costs 5 gold. You can afford " + (gold / 5) + " potions, with " + (gold % 5) + " gold left.");
        Debug.Log("");

        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        Debug.Log("The Dining Hall");
        Debug.Log("All the food has rotted and decayed. The insects and vermin are having a feast. A swarm of ants are gathered around a tapestry.");
        Debug.Log("You approach the tapestry and move it aside, revealing a dark tunnel. Seeing no other way out, you enter the tunnel and move onto the next room");

        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.
        Debug.Log("The Exit Room");
        Debug.Log("The tunnel has lead you to a hidden room. A room seemingly made for emergency evacuations, but why would people need to escape a dungeon in such haste?");
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
    }
}
