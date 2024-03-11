using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CandyController : MonoBehaviour
{
    private Collider2D candyCollider;
    private Renderer candyRenderer;
    public float distanceFromRopeEnd = 0.6f;
    public static int currentSceneIndex;

    void Start()
    {
        candyCollider = GetComponent<Collider2D>();
        candyRenderer = GetComponent<Renderer>();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StarController.starCount = 0;
    }

    public void ConnectRopeEnd(Rigidbody2D endRigidbody)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = endRigidbody;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceFromRopeEnd);
    }

    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "frog")
        {
            candyCollider.enabled = false;
            candyRenderer.enabled = false;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(5);
        }

        if (collision.gameObject.name == "ground" || collision.gameObject.name == "ground2")
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }

}
