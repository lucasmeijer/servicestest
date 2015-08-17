using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUILayout.Button ("HELLO")) {


			Gender gender = Gender.Female;
			Analytics.SetUserGender(gender);

			int birthYear = 2014;
			Analytics.SetUserBirthYear(birthYear);

			int totalPotions = 5;
			int totalCoins = 100;
			string weaponID = "Weapon_102";
			UnityEngine.Analytics.Analytics.CustomEvent ("gameOver", new System.Collections.Generic.Dictionary<string, object> {
				{ "potions", totalPotions },
				{ "coins", totalCoins },
				{ "activeWeapon", weaponID }
			});

		}
	}
}
