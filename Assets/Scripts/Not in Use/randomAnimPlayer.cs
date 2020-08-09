using UnityEngine;
using System.Collections;

public class randomAnimPlayer : MonoBehaviour {
	void Start(){


		int animNumber = Random.Range (1, 3);
		if (animNumber == 1) {
			GetComponent<Animation>().Play ("death01");
				} 
		else {
			GetComponent<Animation>().Play ("death02");	
		}
	}

}
