class Player
{
    
// auto property
public Room CurrentRoom { get; set; }
public int health;

// constructor
public Player()
{
CurrentRoom = null;
health = 100;
}

}