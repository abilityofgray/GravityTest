using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    //By default, make change in GameSettings ScriptbleObject;
    private float forceToMove;
    Rigidbody2D rigidBody2D;

    public GameSettings gameSettings;

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
            rigidBody2D.AddForce(-moveVector * gameSettings.GetPlayerLeanForce, ForceMode2D.Force);

        }

    }

    public void PlayerToStartPos() {

        transform.position = gameSettings.StartPosPlayer;
        forceToMove = gameSettings.GetPlayerLeanForce;
        rigidBody2D.velocity = Vector2.zero;

    }

    public void PlayerSetGravity(float gravity) {

        Vector2 gravityVector = new Vector2(0, -gravity);
        Physics2D.gravity = gravityVector;

    }
}
