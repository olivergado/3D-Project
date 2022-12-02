using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStatController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("w");
        
        if (!isRunning && forwardPressed)
        {
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && !forwardPressed)
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
