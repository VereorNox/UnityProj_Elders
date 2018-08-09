using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulationCounter : MonoBehaviour {

	public Text PopulationText;
	public Hashtable Colonists;
	public Colonist unga = new Colonist("unga","human","NEET",100);
	public Colonist orca = new Colonist("Orcina", "Orc","Hunter",150);

	void Update () {
		Colonists = new Hashtable();
		Colonists.Add(1, unga);
		Colonists.Add(2, orca);
		PopulationText.text = "Population: "+Colonists.Count;
	}
}
