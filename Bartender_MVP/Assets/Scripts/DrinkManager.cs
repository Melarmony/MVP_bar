using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    private Dictionary<int, DrinkInfo> npcDrinks = new Dictionary<int, DrinkInfo>();

    public void AssignDrink(int npcID, DrinkInfo drinkInfo)
    {
        npcDrinks.Add(npcID, drinkInfo);
    }

    public bool IfHasDrink(int npcID)
    {
        return npcDrinks.ContainsKey(npcID);
    }

    public DrinkInfo GetDrinkInfo(int npcID) 
    {
        return npcDrinks.TryGetValue(npcID, out var drinkInfo) ? drinkInfo : null;
    }

    public void RemoveDrink(int npcID)
    {
        npcDrinks.Remove(npcID);
    }
}
