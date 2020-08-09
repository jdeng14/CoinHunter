using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScoreEditor : MonoBehaviour
{
    private string scoretext;
    public UnityEngine.UI.Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = PlayerPrefs.GetString("CurrentScore", "Error");
        scoreText.text = scoretext;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
