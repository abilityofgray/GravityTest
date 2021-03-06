﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (SpriteRenderer))]
public class Platform : MonoBehaviour
{

    public Color[] colors;


    int touchCount;
    Color defaultColor;
    SpriteRenderer spriteRender;

    void Start()
    {

        spriteRender = GetComponent<SpriteRenderer>();
        defaultColor = spriteRender.color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Player>()) {

            //color change by random
            //spriteRender.color = colors[Random.Range(0, colors.Length)];

            GameController.instance.gameSettings.BallHit++;
            GameUI.instance.UpdateBallHit();

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

    public void ResetToDefaultColor() {

        spriteRender.color = defaultColor;

    }
}
