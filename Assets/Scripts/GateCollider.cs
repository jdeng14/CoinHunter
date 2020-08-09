using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GateCollider : MonoBehaviour
{
    private bool tutorialover;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(35f);
        tutorialover = true;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("crushObj") && tutorialover)
        {
            SceneManager.LoadScene(1);
        }
    }
}
