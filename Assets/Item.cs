using UnityEngine;

public class Item {

    public enum ItemType
    {
        Weapon,
        Potion
    }

    private ItemType type;

    public ItemType Type
    {
        get { return type; }
    }


    private string name;
    public string Name {
        get { return name; }
    }
	// Use this for initialization

    public Item(string name, ItemType type)
    {
        //Debug.Log("Hallo ik ben een constructor");
        this.name = name;
        this.type = type;
    }
   
	void Start () {
        Debug.Log("Hallo ik ben start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
