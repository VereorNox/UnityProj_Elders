using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EventReader : MonoBehaviour, IPointerClickHandler {
    public string txtFile;
    public Text EventText;
     public string[] lineByLine;
    public float letterPause;
    bool CoRunning;
    Coroutine co;
    int i = 0;
    // Use this for initialization
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load(txtFile);
        lineByLine = txtAssets.text.Split('\n');
        EventText.text = "...";
    }

    public void OnPointerClick(PointerEventData eventData)
        {
        string lineRead = lineByLine[i];
        if (CoRunning == true) {
            StopCoroutine(co);
            CoRunning = false;
            EventText.text = lineRead;
            i++;
            }
        else if (CoRunning == false) {
            EventText.text = null;
            co = StartCoroutine(TypeText());
            }

        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
        }

    IEnumerator TypeText()
        {
            const float waitTime = 3f;
            float counter = 0f;
            CoRunning = true;
            int index = 0;
            string text = lineByLine[i];
            
            while (counter < waitTime) {
                while (index < text.Length)
                {
                    index++;
                    EventText.text = text.Substring(0, index) + "<color=#FFFFFF00>" +
                                            text.Substring(index, text.Length - index) + "</color>";
                    yield return new WaitForSeconds(letterPause);
                }
                
                counter += Time.deltaTime;
                yield return null;
            }
                CoRunning = false;
                i++;
        }
}