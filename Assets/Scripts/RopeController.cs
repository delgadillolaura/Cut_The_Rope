using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public int links = 7;
    public CandyController candy;

    void Start()
    {
        GenerateRope();
    }

    void GenerateRope()
    {
        Rigidbody2D previousRB = hook;

        for(int i = 0; i < links; i++) 
        {
            GameObject link = Instantiate(linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;

            if (i < links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            } else
            {
                candy.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
}
