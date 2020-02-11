using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static GameUI instance = null;

    public TextMeshProUGUI ballHit;
    public RawImage background;
    public RectTransform mainMenu;

    public GameSettings gameSettings;
    public bool ResetBallHitAtStart;

    void Start()
    {

        if (instance == null) instance = this;

        if (!ResetBallHitAtStart)
        {

            UpdateBallHit();

        }
        else {

            ResetBallHit();

        }
        

    }

    public void UpdateBallHit() {

        ballHit.text = "BallHit : " + gameSettings.BallHit.ToString();

    }

    public void ResetBallHit() {

        gameSettings.BallHit = 0;
        ballHit.text = "BallHit : " + gameSettings.BallHit.ToString();

    }
}
