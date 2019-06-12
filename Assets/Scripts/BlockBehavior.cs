using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherObject = collision.gameObject;
        Debug.Log($"Collision {otherObject.tag}");

        if(otherObject != null && otherObject.tag == "Item")
        {
            Animator animator = otherObject.GetComponent<Animator>();
            animator.SetBool("Finish", true);
            AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
            Destroy(otherObject, info.length - 0.5f);
        }

    }
}
