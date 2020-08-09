using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    public int scene;

    public void SceneSwitcher()
    {
        SceneManager.LoadScene(scene);
    }
}
