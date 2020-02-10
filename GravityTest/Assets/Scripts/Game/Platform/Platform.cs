using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (SpriteRenderer))]
public class Platform : MonoBehaviour
{

    public Color[] colors;

    int touchCount;

    SpriteRenderer spriteRender;

    void Start()
    {

        spriteRender = GetComponent<SpriteRenderer>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Player>()) {


            //color change by random
            //spriteRender.color = colors[Random.Range(0, colors.Length)];

            //color change by elements sequential
            if (touchCount >= colors.Length - 1)
            {

                touchCount = 0;

            }
            else
            {

                touchCount++;

            }
            
            spriteRender.color = colors[touchCount];
            
        }

    }
}
