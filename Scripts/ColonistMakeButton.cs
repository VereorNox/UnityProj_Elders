using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;

public class ColonistMakeButton : MonoBehaviour
{
	public Button makeButton;
	static Colonist newColonist;
	


	void Start () {
		makeButton = GameObject.Find("Button").GetComponent<Button>();
		makeButton.onClick.AddListener(Clicking);
		GameObject.Find("Button").GetComponentInChildren<Text>().text = "Make Colonist";
	}

	void Clicking()
	{
		newColonist = new Colonist();
		PopulationCounter.ListUpdater();
		newColonist = null;
	}
	
	public static Colonist PassColonist 
		{
			get { return newColonist; }
		}
		
}


