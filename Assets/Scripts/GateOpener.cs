using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public GameObject gate;
    public bool tutorialover;
    private Vector3 up;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OpenDelayed());
        up = new Vector3 (0f, 0.02f, 0f);
        sound.Pause();
    }

    void Update()
    {
        if(tutorialover && (gate.transform.position.y < 1.50f))
        {
            gate.transform.position += up;
            sound.UnPause();
        }
        else
        {
            sound.Pause();
        }
    }

    IEnumerator OpenDelayed()
    {
        yield return new WaitForSeconds(35f);
        tutorialover = true;
    }
}
