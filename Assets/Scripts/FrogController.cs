using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    private Animator frogAnimator;
    private Collider2D frogCollider;

    void Start()
    {
        frogAnimator = GetComponent<Animator>();
        frogCollider = GetComponent<Collider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "candy")
        {
            frogCollider.enabled = false;
            frogAnimator.SetTrigger("isEating");
        }
    }
}
