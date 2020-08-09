using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;

public class ThirdPersonController : MonoBehaviour
{
    public Joystick LeftJoystick;
    public FixedButton button;
    public FixedTouchField TouchField; //Image in the UI
    public ThirdPersonUserControl Control; //Unity Standard Asset third person controller
    public CoinEditor coin;
    public Text coinText;
    public AudioSource coinsound;

    protected float CameraAngle; //Quaternion that holds the rotation of the camera angle
    public float CameraAngleSpeed; //inspector float that controls how much the camera angle is changed per frame
    
    // Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>(); //Gets the third person controller
        coinText = GameObject.Find("Coins").GetComponent<UnityEngine.UI.Text>();
        coin = coinText.GetComponent<CoinEditor>();
    }

    // Update is called once per frame
    void Update()
    {
        Control.Hinput = LeftJoystick.Direction.x; //Sets the hroizontal input of the unity standard asset controller to the x direction of the joystick
        Control.Vinput = LeftJoystick.Direction.y; //Sets the vertical input of the unity standard asset controller to the y direction of the joystick

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed; //Changes the x component of the Quaternion by the touch distance in the touchfield and magnifies this by the camera angle speed

        Camera.main.transform.position = transform.position
                                         + Quaternion.AngleAxis(CameraAngle, Vector3.up)
                                         * new Vector3(0, 1.8f, -2f);
        //Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up); //Camera control controlled by player rotation
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position //transform of the player
                                                                    + Vector3.up * 1.2f //(0,1 * float,0)
                                                                    - Camera.main.transform.position, //Camera's transform
                                                                                                Vector3.up); 

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinsound.Play();
            other.gameObject.SetActive(false);
            coin.IncrementCoins();
        }
    }
}

