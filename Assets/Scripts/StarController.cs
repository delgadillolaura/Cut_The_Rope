using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    public GameObject destinationObject;
    private Collider2D starCollider;
    private Animator starAnimator;
    public static int starCount = 0;

    void Start()
    {
        starCollider = GetComponent<Collider2D>();
        starAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "candy")
        {
            MoveStarToCounter(destinationObject);
            starCount++;
        }
    }

    void MoveStarToCounter(GameObject counterObject)
    {
        starAnimator.SetTrigger("isDisappearing");
        Vector2 newPosition = counterObject.transform.position;
        transform.position = newPosition;
    }
}
