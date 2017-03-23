using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	private int indice;

	private Inventario myManager;

	public int Indice {
		get {
			return indice;
		}
		set {
			indice = value;
		}
	}

	public Inventario MyManager {
		get {
			return myManager;
		}
		set {
			myManager = value;
		}
	}

	public void ClickOnMe(){

		myManager.SetItemImage (indice);
		
	}
}
