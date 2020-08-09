using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialScoreEditor: MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public int score;
    public GameObject maze;
    public MazeSpawner mazespawner;
    public int goalnum;
    public string scorestr;
    public string goalnumstr;
    public string difficulty;
    private Timer timer;
    private int bestscore;
    private float besttime;
    private float currenttime;
    private float currentmin;
    private float currentsec;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scorestr = score.ToString();
        scoreText.text = "CONTAINERS: " + scorestr + " / 5";
        
    }
    public void IncrementScore()
    {
        score++;
    }
}
