using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour, IPointerDownHandler
{
    public enum Scene
    {
        MazeScene,

    }

    public void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("pressed");
        Load(Scene.MazeScene);
    }

}