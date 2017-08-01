using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

    private List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () {
        Item newItem = new Item("Sword", Item.ItemType.Weapon);
        Item newItem2 = new Item("Potion", Item.ItemType.Potion);
        AddItem(newItem);
        AddItem(newItem2);

        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(items[i].Name);
        }
	}
	
	// Update is called once per frame
	void AddItem (Item item) {
        items.Add(item);
	}
}
