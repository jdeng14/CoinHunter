using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalScoreEditor: MonoBehaviour
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
        timer = GetComponent<Timer>();
        score = 0;
        mazespawner = maze.GetComponent<MazeSpawner>();
        bestscore = PlayerPrefs.GetInt("bestscore", 0);
        besttime = PlayerPrefs.GetFloat("besttime", 999999f);
    }

    // Update is called once per frame
    void Update()
    {
        goalnum = mazespawner.getGoalnum();
        scorestr = score.ToString();
        goalnumstr = goalnum.ToString();
        scoreText.text = "CONTAINERS: " + scorestr + " / " + goalnumstr;
        if(score == goalnum)
        {
			PlayerPrefs.SetString("EndScore", "YOU WIN!");
			EndGame();
		}
        else if(timer.gameover == true)
		{
			EndGame();

		}
    }
    public void IncrementScore()
    {
        if(timer.text != "GameOver")
        {
            score++;
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(8);
    }

    public void EndGame()
	{
		StartCoroutine(End());
		if (goalnum <= 3)
		{
			difficulty = "EASY";
		}
		else if (goalnum <= 5)
		{
			difficulty = "MEDIUM";
		}
		else
		{
			difficulty = "HARD";
		}

		currentmin = (1f - (float.Parse(timer.minutes)));
		currentsec = (59.9f - float.Parse(timer.seconds));
		currenttime = currentmin * 100f + currentsec;
		PlayerPrefs.SetString("CurrentScore", "SCORE: " + difficulty + " " + scorestr + "/" + goalnumstr +
			" TIME: " + currentmin.ToString() + ":" + currentsec.ToString("f1"));
		if ((score > bestscore) || ((score == bestscore) && (currenttime < besttime)))
		{
			PlayerPrefs.SetString("BestScore", "BEST: " + difficulty + " " + scorestr + "/" + goalnumstr +
			" TIME: " + currentmin.ToString() + ":" + currentsec.ToString("f1"));
			PlayerPrefs.SetInt("bestscore", score);
			PlayerPrefs.SetFloat("besttime", currenttime);
		}
	}
}
