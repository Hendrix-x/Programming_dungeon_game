using Unity.Burst.Intrinsics;
using Unity.VisualScripting;
using UnityEngine;

// CLASSES HOMEWORK (file 5 of 6). Files: Item.cs, Inventory.cs, Room.cs, Enemy.cs, Player.cs, DungeonGame.cs
// Fill in every TODO.

/// <summary>
/// The hero the player guides through the dungeon. A Player tracks its own
/// stats, carries an Inventory of items, and can act on enemies.
/// </summary>
public class Player
{
    // Write a member variable for each stat the hero needs, choosing a type that
    // fits the description:
    //   - the player's name
    public string name = "Knight";
    //   - how much health the player has
    public int health;
    //   - how much damage the player deals when attacking
    public int damage;
    //   - how much of a hit the player can absorb (defense)
    public int defense;
    //   - how hard the player is to hit (armor class)
    public int agility;
    //   - how much gold the player has collected so far
    public int gold_collected;
    //   - the most health the player can have (used to cap resting)
    public int health_cap;
    // TODO: declare those member variables here.
    public Player(string name1, int health1, int damage1, int defense1, int agility1, int gold1, int cap1)
    {
        name = name1;
        health = health1;
        damage = damage1;
        defense = defense1;
        agility = agility1;
        gold_collected = gold1;
        health_cap = cap1;
    }



    // The player carries an INVENTORY. The Inventory class you wrote (in
    // Inventory.cs) holds everything picked up, including the key, so there is
    // no separate "has the key" flag any more. Give the player one Inventory and
    // create it here so the player starts with an empty pack.
    // TODO: declare an Inventory member variable and set it to a new Inventory.
    public Inventory backpack = new Inventory();


    /// <summary>
    /// Adds the given amount of gold to the player's total.
    /// </summary>
    /// <param name="amount">How much gold to add.</param>
    public void CollectGold(int amount)
    {
        gold_collected += amount;
        Debug.Log("You collected " + amount + " gold. You now have " + gold_collected + " gold in your inventory.");
    }

    /// <summary>
    /// Lowers the player's health by the given amount (never below zero), then
    /// reports the hero's condition.
    /// </summary>
    /// <param name="amount">How much damage to take.</param>
    public void TakeDamage(int amount)
    {
        if (amount < health)
        {
            health -= amount;
        }
        else
        {
            health = 0;
        }
    }

    public void Heal()
    {
        health += 10;
    }
    public void Heal(int addedHealth)
    {
        health += addedHealth;
    }

    /// <summary>
    /// Works out the hero's condition from current health.
    /// </summary>
    /// <returns>"Healthy", "Wounded", or "Critical".</returns>
    public string HealthStatus()
    {
        return "";
        if (health >= 70)
        {
            return "Your condition is still strong enough to continue going";
        }
        else if (health >= 50)
        {
            return "Your health could be better, but still with the strength to go on.";
        }
        else if (health >= 30)
        {
            return "You are in a quite rough state. It's compelling to stop right here, but not now.";
        }
        else if (health >= 10)
        {
            return "Everything hurts, you can be keep yourself up, but for some reason, you continue to push on.";
        }
    }

    public void IndicateHealth()
    {
        if (HealthStatus() != "")
        {
            Debug.Log(HealthStatus());
        }
    }

    /// <summary>
    /// Reports whether the player still has health left.
    /// </summary>
    /// <returns>True while health is above zero.</returns>
    public bool IsAlive()
    {
        return health > 0;
    }

    /// <summary>
    /// Picks up an item: adds it to the inventory and applies its effects (its
    /// attack and defense bonuses are added to the player's stats).
    /// </summary>
    /// <param name="item">The item being picked up.</param>
    public void PickUp(Item item)
    {
        backpack.Add(item);
    }

    /// <summary>
    /// Reports whether the player is carrying an item with the given name (use
    /// this to check for the key). Let the Inventory do the searching.
    /// </summary>
    /// <param name="itemName">The item name to look for.</param>
    /// <returns>True if the inventory holds a matching item.</returns>
    public bool HasItem(string itemName)
    {
        return backpack.FindByName(itemName) != null;
    }

    /// <summary>
    /// Rests, healing the player a little each turn, up to full health.
    /// </summary>
    /// <param name="turns">How many turns to rest. Defaults to 3 when left out.</param>
    public void Rest(int turns = 3)
    {
        while (health < health_cap || turns > 0)
        {
            health += 3;
            turns -= 1;
        }
    }

    /// <summary>
    /// Prints the player's current stats, then lists the items in the inventory.
    /// </summary>
    public void ShowStatus()
    {
        Debug.Log("Your player:");
        Debug.Log("Name: " + name);
        Debug.Log("Health: " + health);
        Debug.Log("Strength: " + damage);
        Debug.Log("Armor: " + defense);
        Debug.Log("Agility: " + agility);
        Debug.Log("Gold: " + gold_collected);
        Debug.Log("Your inventory: ");
        backpack.ShowAll();
    }
}
