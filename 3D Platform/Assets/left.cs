using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour
{
    Animator animator;
    int isLeftHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isLeftHash = Animator.StringToHash("isLeft");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isLeftHash);
        bool spacePressed = Input.GetKey("a");

        if (!isRunning && spacePressed)
        {
            animator.SetBool(isLeftHash, true);
        }

        if (isRunning && !spacePressed)
        {
            animator.SetBool(isLeftHash, false);
        }
    }
}
