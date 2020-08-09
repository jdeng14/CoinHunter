using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public string text;
    public bool gameover;
    private float startTime;
    public string minutes;
    public string seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        //Initialzation of text
        startTime = Time.time;
        minutes = "1";
        seconds = "59.9";
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        //if((1 - ((int)t / 60)) != 0 && (59.9f - (t % 60)) != 0.0f)
        //{
        //    minutes = (1 - ((int)t / 60)).ToString();
        //    seconds = (59.9f - (t % 60)).ToString("f1");
        //}
        if((minutes != "0") || (seconds != "0.0"))
        {
            minutes = (1 - ((int)t / 60)).ToString();
            seconds = (59.9f - (t % 60)).ToString("f1");

            text = minutes + ":" + seconds;
        }
        else
        {
			//SceneManager.LoadScene(8);
			gameover = true;
        }
        timerText.text = text;
    }
}
