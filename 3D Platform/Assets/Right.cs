using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    Animator animator;
    int isRightHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isRightHash = Animator.StringToHash("isRight");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRight = animator.GetBool(isRightHash);
        bool RightPressed = Input.GetKey("d");

        if (!isRight && RightPressed)
        {
            animator.SetBool(isRightHash, true);
        }

        if (isRight && !RightPressed)
        {
            animator.SetBool(isRightHash, false);
        }
    }
}