using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Database : ScriptableObject
{
	public Item[] items;
}

[System.Serializable]
public class Item
{
	public Sprite sprite;
	public string itemName;

	public Item(Item clone){
		this.sprite = clone.sprite;
		this.itemName = clone.itemName;
	
	}
}
