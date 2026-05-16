using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("TriggerColorChange");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("TriggerScaling");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("TriggerSpinning");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("TriggerHovering");
        }
    }
}