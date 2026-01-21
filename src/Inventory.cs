using System.Resources;

class Inventory
{
// fields
private int maxWeight;
private Dictionary<string, Item> items;
// constructor
public Inventory(int maxWeight)
{
this.maxWeight = maxWeight;
this.items = new Dictionary<string, Item>();
}
// methods
public bool Put(string itemName, Item item)
{
// TODO implementeer:
// Check het gewicht van het Item
// Is er genoeg ruimte in de Inventory?
// Past het Item?
//drop
// Zet Item in de Dictionary
// Return true/false voor succes/mislukt
return false;
}

public Item Get(string itemName)
{
// TODO implementeer:
//take
// Zoek Item in de Dictionary
// Verwijder Item uit Dictionary (als gevonden)7 / 12
// Return Item of null
    return null;
    }
    public int TotalWeight()
{
int total = 0;
// TODO implementeer:
// Loop door alle items
// Tel alle gewichten op
return total;
}
public int FreeWeight()
{
// TODO implementeer:
// Vergelijk MaxWeight en TotalWeight()
    int freeWeight = maxWeight - TotalWeight();
    return freeWeight;
}
}