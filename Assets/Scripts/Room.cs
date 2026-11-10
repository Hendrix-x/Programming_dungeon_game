using UnityEngine;

// CLASSES HOMEWORK (file 3 of 6). Files: Item.cs, Inventory.cs, Room.cs, Enemy.cs, Player.cs, DungeonGame.cs
// Fill in every TODO.

/// <summary>
/// One room in the dungeon. A Room remembers its own data (name, description,
/// how much gold it holds, whether it has been visited) and may hold an enemy.
/// </summary>
public class Room
{
    // Declare a member variable for each thing a room remembers, choosing a type
    // that fits:
    //   - the room's name
    //   - a short description of the room
    //   - how much gold is found here (0 for none)
    //   - whether the player has visited it yet
    // TODO: declare those member variables here.
    public string roomName;
    public string roomDescription;
    public int roomGold;
    public bool roomVisited;


    // EVERY room has an Enemy member variable, but most rooms are empty, so it
    // may be null (null means "there is no enemy in this room"). This member
    // variable is required.
    // TODO: declare an Enemy member variable (it may be null).

    private Enemy roomEnemy;

    public Room(string inputName, string inputDescription, int inputGold = 0)
    {
        roomName = inputName;
        roomDescription = inputDescription;
        roomGold = inputGold;
        roomVisited = false;
        //roomEnemy = inputEnemy;
    }

    /// <summary>
    /// Prints the room's name. The first time the room is entered it also prints
    /// the description and marks the room as visited.
    /// </summary>
    public void Enter()
    {
        Debug.Log(roomName);
        if (!roomVisited)
        {
            Debug.Log(roomDescription);
            roomVisited = true;
        }
    }

    /// <summary>
    /// Reports whether this room has already been visited.
    /// </summary>
    /// <returns>True if the room has been entered before.</returns>
    public bool HasBeenVisited()
    {
        return roomVisited;
    }

    /// <summary>
    /// Reports whether an enemy is waiting in this room.
    /// </summary>
    /// <returns>True if the room's Enemy is not null.</returns>
    public Enemy GetEnemy()
    {
        return roomEnemy;
    }
}
