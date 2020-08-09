using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool pressed;
    public Animator animator;

    public void OnPointerDown(PointerEventData eventData)
    {
		animator.SetBool("Hitting", true); //Sets the animator condition "Hitting" to true
        pressed = true; 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        animator.SetBool("Hitting", false); //Sets the animator condition "Hitting" to true
        pressed = false;
    }
}
