using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{

    public GameController.GameState gameState;

    void Start()
    {

        GetComponent<Button>().onClick.AddListener(LevelInit);

    }

    void LevelInit() {

        GameController.instance.LevelInit(gameState);

    }
}
