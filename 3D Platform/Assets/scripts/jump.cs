using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Animator animator;
    int isJumpingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isJumpingHash);
        bool spacePressed = Input.GetKey("space");

        if (!isRunning && spacePressed)
        {
            animator.SetBool(isJumpingHash, true);
        }

        if (isRunning && !spacePressed)
        {
            animator.SetBool(isJumpingHash, false);
        }
    }
}
