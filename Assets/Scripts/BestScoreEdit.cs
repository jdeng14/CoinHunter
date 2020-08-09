using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScoreEdit : MonoBehaviour
{
    private string scoretext;
    public UnityEngine.UI.Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = PlayerPrefs.GetString("BestScore", "Error");
        scoreText.text = scoretext;
    }
}
