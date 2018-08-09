using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectHighlight : MonoBehaviour, IPointerEnterHandler {

	// Use this for initialization
	public void OnPointerEnter(PointerEventData PointerEventData) {
		Debug.Log("This works.");
	}

	public void OnMouseOver() {
		Debug.Log("This fuckign works.");
	}
}
