using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateColonists : MonoBehaviour 
{

	public string nameFile, professionFile, raceFile, natureFile;
	public static List<string> allNames, allProfessions, allRaces, allNatures;
	
	
	void Awake() {
		if(allNames == null) {
			TextAsset nameAsset = (TextAsset)Resources.Load(nameFile);
			allNames = nameAsset.text.Split('\n').ToList();
		}
		if(allProfessions == null) {
			TextAsset profAsset = (TextAsset)Resources.Load(professionFile);
			allProfessions = profAsset.text.Split('\n').ToList();
		}
		if(allRaces == null) {
		TextAsset raceAsset = (TextAsset)Resources.Load(raceFile);	
		allRaces = raceAsset.text.Split('\n').ToList();
		}
		if(allNatures == null) {
			TextAsset natureAsset = (TextAsset)Resources.Load(natureFile);
			allNatures = natureAsset.text.Split('\n').ToList();
		}
	}
	public static List<string> PassName {
		get { return allNames; } }
	public static List<string> PassProf {
		get { return allProfessions; } }
	public static List<string> PassRace {
		get { return allRaces; } }
	public static List<string> PassNature {
		get { return allNatures; } }
}
