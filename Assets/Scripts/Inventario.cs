using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour {

	public Database Db;
	public Image item;
	public GameObject button;

	void Start (){



		for (int i = 0; i < Db.items.Length; i++) 
		
		{

			GameObject objTemp = Instantiate( button);
			objTemp.GetComponent<Buttons> ().Indice = i;
			objTemp.GetComponentInChildren<Text> ().text = Db.items [i].itemName;
			objTemp.GetComponent<Buttons> ().MyManager = this;
			objTemp.transform.SetParent(transform);

		}

	}

	public void SetItemImage(int indice)
	{

		item.sprite = Db.items [indice].sprite;

	}
}
