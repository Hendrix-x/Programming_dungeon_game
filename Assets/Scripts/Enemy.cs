using UnityEngine;

// CLASSES HOMEWORK (file 4 of 6). Files: Item.cs, Inventory.cs, Room.cs, Enemy.cs, Player.cs, DungeonGame.cs
// Fill in every TODO.

/// <summary>
/// An enemy the player can fight. An Enemy keeps its own combat stats, can take
/// damage, and only gets to attack every so often based on its speed.
/// </summary>
public class Enemy
{
    // Write a member variable for each stat a fight needs, choosing a type that
    // fits the description:
    //   - what the enemy is called
    //   - how much health it has right now
    //   - how much damage it deals when it lands a hit
    //   - how much of a hit it can absorb (its defense)
    //   - how hard it is to hit (its armor class)
    // TODO: declare those member variables here.

    public string name;
    public int health;
    public int damage;
    public int defense;
    public int armorClass;

    // The enemy should NOT attack every single turn. Add a value that controls
    // how often it attacks, based on its speed: 1 means it attacks every turn,
    // 2 means every other turn, 3 means every third turn.
    // TODO: declare the enemy's attack-speed member variable here.

    private int speed;


    public Enemy(string startName, int startHealth, int startDamage, int startDefense, int startArmorClass)
    {
        name = startName;
        health = startHealth;
        damage = startDamage;
        defense = startDefense;
        armorClass = startArmorClass;
    }

    /// <summary>
    /// Lowers this enemy's health by the given amount.
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



    /// <summary>
    /// Reports whether this enemy still has health left.
    /// </summary>
    /// <returns>True while health is above zero.</returns>
    public bool IsAlive()
    {
        return health > 0;
    }

    /// <summary>
    /// Reports whether this enemy gets to attack on the given turn, based on its
    /// attack speed.
    /// </summary>
    /// <param name="turnNumber">The current turn number in the fight.</param>
    /// <returns>True on the turns the enemy is allowed to attack.</returns>
    public bool AttacksOnTurn(int turnNumber)
    {
        // TODO: use the turn number and the enemy's speed to decide.
        return turnNumber % speed == 0;
    }

    /// <summary>
    /// Prints a short line describing this enemy's current state (for example its
    /// name and remaining health).
    /// </summary>
    public void Describe()
    {
        Debug.Log(name + "'s stats:");
        Debug.Log("Health: " + health);
        Debug.Log("Strength: " + damage);
        Debug.Log("Defense: " + defense);
        Debug.Log("Armor Class: " + armorClass);
    }
}
