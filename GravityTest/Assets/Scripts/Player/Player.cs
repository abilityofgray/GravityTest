using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    //By default, make change in GameSettings ScriptbleObject;
    private float forceToMove;
    Rigidbody2D rigidBody2D;

    GameSettings gameSettings;

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

    public void PlayerToStartPos() {

        transform.position = gameSettings.StartPosPlayer;
        forceToMove = gameSettings.GetPlayerLeanForce;

    }

    public void PlayerSetGravity() {

        /*
        rigidBody2D.gravityScale;
        rigidBody2D.mass;
        */

    }
}
