using System;
using UnityEngine;

// CLASSES HOMEWORK (file 2 of 6). Files: Item.cs, Inventory.cs, Room.cs, Enemy.cs, Player.cs, DungeonGame.cs
// Fill in every TODO. This is the same Inventory you built in class.

/// <summary>
/// Holds the items the player is carrying and knows how to work with them: add
/// an item, find one by name, and list everything in the pack.
/// </summary>
public class Inventory
{
    // The inventory has to hold several Item objects, and remember how many of
    // its slots are actually filled. Think about how you held many of something
    // before (an array), and declare the item storage and a count here.
    // TODO: declare the items (an array of Item) and a count member variable.

    private Item[] storage = new Item[8];

    /// <summary>
    /// Adds an item to the next open slot, and records that one more slot is used.
    /// </summary>
    /// <param name="item">The item to store.</param>
    public void Add(Item item)
    {
        bool stored = false;
        for (int i  = 0; i < storage.Length; i++)
        {
            if (storage[i] == null)
            {
                storage[i] = item;
                stored = true;
                Debug.Log("You put the " + item.Name + " in your inventory.");
                break;
            }
        }
        if (stored == false)
        {
            Debug.Log("Whoops! You have no room in your inventory.");
        }
    }

    /// <summary>
    /// Looks through the filled slots for an item with the given name.
    /// </summary>
    /// <param name="name">The item name to search for.</param>
    /// <returns>The matching Item, or null when nothing matches.</returns>
    public Item FindByName(string name)
    {
        Item locate = null;
        for(int n = 0; n < storage.Length; n++)
        {
            //return null;
            if (storage[n].Name == name)
            {
                locate = storage[n];
                break;
            }
            
        }
        return locate;
    }

    /// <summary>
    /// Prints every item currently being carried.
    /// </summary>
    public void ShowAll()
    {
        foreach (Item i in storage)
        {
            if (i != null)
            {
                Debug.Log(i.Name);
            }
        }
    }
}
