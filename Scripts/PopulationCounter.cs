using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PopulationCounter : MonoBehaviour, IPointerClickHandler {

	public static Text PopulationText;
	public static List<Colonist> Colonists = new List<Colonist>();
	public static Text PopulationMenu;

	

	void Start () {
		PopulationText = GameObject.Find("PopulationCounter").GetComponent<Text>();
		PopulationMenu = GameObject.Find("Population Menu").GetComponent<Text>();
		Colonists = new List<Colonist>();
		Colonists.Add(new Colonist());
		Colonists.Add(new Colonist());	
		PopulationText.text = "Population: "+Colonists.Count;
		foreach(Colonist colonist in Colonists) {
			PopulationMenu.text += "\n"+colonist.cName+" the "+colonist.cRace+" "+colonist.cProfession;
		}

	}

	public static void ListUpdater () {
		if(ColonistMakeButton.PassColonist != null) {
			Colonists.Add(ColonistMakeButton.PassColonist);
		}
		PopulationMenu.text = "Population Menu";
		foreach(Colonist colonist in Colonists) {
			PopulationMenu.text += "\n"+colonist.cName+" the "+colonist.cRace+" "+colonist.cProfession;
		}
		PopulationText.text = "Population: "+Colonists.Count;
	}

	public void OnPointerClick(PointerEventData pointerEventData) {
		if(PopulationMenu.GetComponent<Text>().enabled == false) {
			PopulationMenu.GetComponent<Text>().enabled = true;
		} else {
			PopulationMenu.GetComponent<Text>().enabled = false;
		}
		Debug.Log("This worked?");
		
	}
}
