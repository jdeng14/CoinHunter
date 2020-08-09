using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneSwapper : MonoBehaviour
{
    public int easy;
    public int medium;
    public int hard;
    public int tutorial;
    public int mediumthresh;
    public int hardthresh;
    private int coins;
    private int firsttime;

    void Start()
    {
        coins = PlayerPrefs.GetInt("coins", 0);
        firsttime = PlayerPrefs.GetInt("firsttime", 0);
    }
    public void SceneSwitcher()
    {
        if(firsttime == 0)
        {
            PlayerPrefs.SetInt("firsttime", 1);
            SceneManager.LoadScene(tutorial);
        }
        else if(coins >= hardthresh)
        {
            SceneManager.LoadScene(hard);
        }
        else if(coins >= mediumthresh)
        {
            SceneManager.LoadScene(medium);
        }
        else
        {
            SceneManager.LoadScene(easy);
        }
    }
}
