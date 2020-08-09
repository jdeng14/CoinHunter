using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int coin_count;

    float speed = 4;
    float rotation = 0;
    float rotationspeed = 80;
    float gravity = 8;

    Vector3 moveDirection = Vector3.zero;

    CharacterController controller;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            if (Input.GetKey (KeyCode.W))
            {
                animator.SetInteger("condition", 1);
                moveDirection = new Vector3(0, 0, 1);
                moveDirection *= speed;
                moveDirection = transform.TransformDirection(moveDirection);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetInteger("condition", 0);
                moveDirection = Vector3.zero;
            }
        }
        rotation += Input.GetAxis("Horizontal") * rotationspeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotation, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            coin_count += 1;
        }
    }
}
