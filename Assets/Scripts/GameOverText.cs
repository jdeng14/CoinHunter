using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour
{
	private string endtext;
	public UnityEngine.UI.Text endText;
	// Start is called before the first frame update
	void Start()
	{
		endtext = PlayerPrefs.GetString("EndScore", "GAME OVER");
		endText.text = endtext;
	}
}
