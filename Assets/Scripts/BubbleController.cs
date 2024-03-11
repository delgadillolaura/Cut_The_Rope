using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleController : MonoBehaviour
{
    private Rigidbody2D bubbleRB;
    public float gravityScaleValue = 0.1f;
    public GameObject candy;
    private Renderer bubbleRenderer;


    void Start()
    {
        bubbleRB = GetComponent<Rigidbody2D>();
        bubbleRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "candy")
        {
            liftBubble();
        }
    }

    public void destroyBubble()
    {
        bubbleRenderer.enabled = false;
        candy.GetComponent<Rigidbody2D>().gravityScale = 1f;
        Destroy(this);
    }

    private void liftBubble()
    {
        bubbleRB.gravityScale = -gravityScaleValue;
        candy.GetComponent<Rigidbody2D>().velocity = new Vector2(bubbleRB.velocity.x, 0);
        candy.GetComponent<Rigidbody2D>().transform.position = transform.position;
        candy.GetComponent<Rigidbody2D>().gravityScale = bubbleRB.gravityScale;
    }
}
