using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameController.GameState gameState;

    Button button;

    void Start()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(LevelInit);

    }

    void LevelInit() {

        switch (gameState) {

            case GameController.GameState.LevelEarth:
                break;
            case GameController.GameState.LevelMoon:
                break;
            case GameController.GameState.LevelJupiter:
                break;
            case GameController.GameState.MainMenu:
                break;

        }


    }
}
