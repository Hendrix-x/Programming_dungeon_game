using UnityEngine;

// CLASSES HOMEWORK (file 1 of 6). Files: Item.cs, Inventory.cs, Room.cs, Enemy.cs, Player.cs, DungeonGame.cs
// Fill in every TODO. Each class lives in its own file, just like in Unity.

/// <summary>
/// An item the player can find and carry. For now, ONE Item class covers every
/// kind of item by storing the effect each one has (a torch, a sword, a shield,
/// the key, ...). Later we will split this into separate derived classes, one
/// per item type, instead.
/// </summary>
public class Item
{
    // An Item needs to describe itself and the effect it has when carried. Write
    // a member variable for each, choosing a type that fits the description:
    //   - the item's name
    //   - how much it raises the player's attack (0 if it does not, like the sword's +7)
    //   - how much it raises the player's defense (0 if it does not, like the shield's +4)
    // TODO: declare the Item's member variables here.
    public string Name;
    public int AttackBonus;
    public int DefenseBonus;
    public int HealAmount;

    public bool IsKey;

    public Item(string inputName, int inputAttack = 0, int inputDefense = 0, int inputHeal = 0)
    {
        Name = inputName;
        AttackBonus = inputAttack;
        DefenseBonus = inputDefense;
        HealAmount = inputHeal;
    }

    /// <summary>
    /// Prints the item's name and what it does.
    /// </summary>
    public void Describe()
    {
        Debug.Log(Name);
        if (AttackBonus != 0)
        {
            Debug.Log("+ " + AttackBonus + " Attack");
        }
        if (DefenseBonus != 0)
        {
            Debug.Log("+ " + DefenseBonus + " Defense");
        }
        if (HealAmount != 0)
        {
            Debug.Log("+ " + HealAmount + " Health");
        }
    }
}
