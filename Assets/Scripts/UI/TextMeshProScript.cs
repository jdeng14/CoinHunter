using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMeshProScript : MonoBehaviour
{
	public TextMeshPro textMesh;
	// Start is called before the first frame update
	void Start()
	{
		textMesh = GetComponent<TextMeshPro>();
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        textMesh.SetText("Welcome to THE MAZE");
        yield return new WaitForSeconds(3f);
        textMesh.SetText("Use the LEFT JOYSTICK to move");
        yield return new WaitForSeconds(5f);
        textMesh.SetText("Slide your finger across the SCREEN to move the CAMERA");
        yield return new WaitForSeconds(5f);
        textMesh.SetText("These are the five types of CONTAINERS");
        yield return new WaitForSeconds(3f);
        textMesh.SetText("Inside them contain COINS");
        yield return new WaitForSeconds(3f);
        textMesh.SetText("Tap the BUTTON to destroy the container");
        yield return new WaitForSeconds(5f);
        textMesh.SetText("Move over the COINS to collect");
        yield return new WaitForSeconds(5f);
        textMesh.SetText("You are now ready to explore THE MAZE");
        yield return new WaitForSeconds(3f);
		textMesh.SetText("You will have 2 minutes to collect as many coins as you can");
		yield return new WaitForSeconds(3f);
		textMesh.SetText("Go forth adventurer and claim your gold!");
    }
}
