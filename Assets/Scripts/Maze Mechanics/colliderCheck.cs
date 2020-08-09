using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class colliderCheck : MonoBehaviour
{

    public GameObject crushPrefab;
    public TotalScoreEditor score;
    public Text scoreText;
    public Image button;
    public FixedButton fixedButton;
    public bool destroyed;

    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<UnityEngine.UI.Text>();
        score = scoreText.GetComponent<TotalScoreEditor>();
        button = GameObject.Find("Button").GetComponent<UnityEngine.UI.Image>();
        fixedButton = button.GetComponent<FixedButton>();
        destroyed = false;
    }

    void OnTriggerStay(Collider other) 
	{
        if (fixedButton.pressed)
        {
            if (other.gameObject.tag == "crushObj")
            {
                if (!destroyed){
                    KillSelf();
                    destroyed = true;
                }
            }
        }
	}
	void KillSelf(){

        StartCoroutine(Kill());
	}
    IEnumerator Kill()
    {
        yield return new WaitForSeconds(.3f);
        GameObject wreckClone = (GameObject)Instantiate(crushPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
        score.IncrementScore();
    }
}
