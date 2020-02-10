using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;

    public enum GameState {

        LevelEarth,
        LevelMoon,
        LevelJupiter,
        MainMenu,

    }

    public GameState gameState;

    
    // Start is called before the first frame update
    void Start()
    {

        if (instance == null) instance = this;
        else { Destroy(this); }

        gameState = GameState.MainMenu;

        

    }

    
}
