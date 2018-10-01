using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Player {
	public string playerName;
	public int leadership;
	public int health;
	public int agility;
	public int stregth;
	public int talent;
	public enum Rarity{
		BRONZE,
		GOLD,
		DIAMOND,
		LEGEND
	}
	public Rarity rarity;

}

