using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colonist {

	public string cName, cRace, cProfession;
	public int health, curse;

	public Colonist(string n, string r, string p, int h)
	{
		cName = n;
		cRace = r;
		cProfession = p;
		health = h;
		curse = 0;
	}


}
