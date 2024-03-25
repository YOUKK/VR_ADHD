using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.G))
		{
                animator.SetBool("IsGrab", true);
        }

		if (Input.GetKeyUp(KeyCode.G))
		{
            animator.SetBool("IsGrab", false);
        }
    }
}
