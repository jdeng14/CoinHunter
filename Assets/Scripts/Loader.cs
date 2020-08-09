using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader: MonoBehaviour
{
    public enum Scene
    {
        MazeScene,

    }
    public void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
