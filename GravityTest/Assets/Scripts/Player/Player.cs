using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    //By defaul, make change in GameSettings ScriptbleObject;
    private float forceToMove = 25.5f;
    Rigidbody2D rigidBody2D;

    public float MoveSpeed {

        set { forceToMove = value;}

    }

    Vector3 movePoint;

    private void Start()
    {

        rigidBody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0)) {

            movePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movePoint.z = transform.position.z;
            
            Vector3 moveVector = transform.position - movePoint;
            rigidBody2D.AddForce(-moveVector * forceToMove, ForceMode2D.Force);

        }

    }
}
