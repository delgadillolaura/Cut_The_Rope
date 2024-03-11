using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCutterController : MonoBehaviour
{
    public BubbleController bubble;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.tag == "link")
                {
                    Destroy(hit.collider.gameObject);
                    DestroyRope(hit);
                }

                if(hit.collider.tag == "bubble")
                {
                    Destroy(hit.collider.gameObject);
                    bubble.destroyBubble();
                }
            }
        }
    }

    void DestroyRope(RaycastHit2D hit)
    {
        Transform parentTransform = hit.transform.parent;
        if (parentTransform != null)
        {
            int childCount = parentTransform.childCount;

            for (int i = 0; i < childCount; i++)
            {
                Transform child = parentTransform.GetChild(i);
                Destroy(child.gameObject);
            }
        }
        else
        {
            Debug.LogWarning("GameObject has no parent.");
        }
    }

}