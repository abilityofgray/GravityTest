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

            LoadSavedData();
            
        }
        else {

            ResetBallHit();

        }
        


    }

    public void UpdateBallHit() {

        GetBallHitToText();

    }

    public void ResetBallHit() {

        gameSettings.BallHit = 0;
        GetBallHitToText();

    }

    //TODO: refactor to separeta class
    public void LoadSavedData() {

        gameSettings.BallHit = PlayerPrefs.GetFloat("BallHit");
        GetBallHitToText();

    }

    void GetBallHitToText() {

        ballHit.text = "BallHit : " + gameSettings.BallHit.ToString();

    }
}
