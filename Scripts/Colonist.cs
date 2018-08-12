using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonist
{

	public string cName, cRace, cProfession;
	public int health, curse;
	public List<string> allNames = GenerateColonists.PassName;
	public List<string> allProfessions = GenerateColonists.PassProf;
	public List<string> allRaces = GenerateColonists.PassRace;

	void Setup(string n, string r, string p, int h) 
	{
		cName = n;
		cRace = r;
		cProfession = p;
		health = h;
		curse = 0;
	}

	public Colonist() 
	{
		int rName = Random.Range(0, allNames.Count);
		int rProf = Random.Range(0, allProfessions.Count);
		int rRace = Random.Range(0, allRaces.Count); 		 
		Setup((string)allNames[rName],(string)allRaces[rRace],(string)allProfessions[rProf], 100); 	
	}
}