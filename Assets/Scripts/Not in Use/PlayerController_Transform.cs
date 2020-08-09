using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Transform : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float moveSpeed = 2;

    protected Joystick joystick;

    Animator anim;

    // Update is called once per frame
    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }

    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
        if (input > 0)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }

    private void Turn(float Input)
    {
        transform.Rotate(0, Input * rotationRate * Time.deltaTime, 0);
    }
}
