﻿using UnityEngine;
using System.Collections;

public class SpellDB : MonoBehaviour {
	// TODO scale this up!
	// NOTICE: Still has a coupling with the WizardState
	 public enum AttackID{
		fireball,
		morefireball,
		bigfireball,
		morebigfireball,
		iceball,
		moreiceball,
		bigiceball,
		morebigiceball,
		meteor,
		reflect,
		swap,
		iceBurst,
		None
	};

	static public string[] attackIDnames = {
		"fireball", 
		"morefireball",
		"bigfireball",
		"morebigfireball",
		"iceball",  
		"moreiceball", 
		"bigiceball", 
		"morebigiceball", 
		"meteor", 
		"reflect", 
		"swap",
		"iceBurst", 
		"None"
	};

	
	// public GameObject meteor_;
	static public GameObject fireball;
	static public GameObject iceball;
	static public GameObject meteor;
	static public GameObject reflector;
	static public GameObject swap;
	static public GameObject iceBurst;
	static public GameObject Bigfireball;

	void Awake()
	{
		Debug.Log("INIT: Create Reference to Spells");

		InitSpells ();
	}
	// May take some time
	void InitSpells () {

		fireball = Resources.Load ("MagicSpells/Fireball") as GameObject;
		Bigfireball = Resources.Load ("MagicSpells/BigFireball") as GameObject;

		meteor = Resources.Load ("MagicSpells/meteorController") as GameObject;
		iceball = Resources.Load ("MagicSpells/Iceball") as GameObject;
		reflector = Resources.Load ("MagicSpells/Reflector") as GameObject;
		// aerolite = Resources.Load ("MagicSpells/Aerolite") as GameObject;

		swap = Resources.Load ("MagicSpells/Swapper") as GameObject;
		iceBurst = Resources.Load ("MagicSpells/IceBurst/IceBurst") as GameObject;
	}
}
