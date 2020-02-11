using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public GameSettings gameSettings;
    public GameObject respawnPoint;
    
    public enum GameState {

        LevelEarth,
        LevelMoon,
        LevelJupiter,
        MainMenu,

    }

    public GameState gameState;

    Camera mainCamera;
    Player player;
    
    void Start()
    {

        
        if (instance == null) instance = this;
        else { Destroy(this); }
        
        gameState = GameState.MainMenu;

        mainCamera = Camera.main;

        player = FindObjectOfType<Player>();

        respawnPoint.GetComponent<SpriteRenderer>().enabled = false;

        gameSettings.StartPosPlayer = respawnPoint.transform.position;

        LevelInit(gameState);

    }

    public void LevelInit(GameState switchState)
    {

        switch (switchState)
        {

            case GameState.LevelEarth:

                //TODO: refactor to one method
                gameState = switchState;
                GameUI.instance.mainMenu.gameObject.SetActive(false);
                mainCamera.backgroundColor = gameSettings.skyColorEarth;

                player.PlayerToStartPos();
                player.PlayerSetGravity(gameSettings.GravityAccelerationEarth);
                player.GetComponent<Rigidbody2D>().simulated = true;
                
                break;

            case GameState.LevelMoon:

                //TODO: refactor to one method
                gameState = switchState;
                GameUI.instance.mainMenu.gameObject.SetActive(false);
                mainCamera.backgroundColor = gameSettings.skyColorMoon;

                player.PlayerToStartPos();
                player.PlayerSetGravity(gameSettings.GravityAccelerationMoon);
                player.GetComponent<Rigidbody2D>().simulated = true;
                
                break;

            case GameState.LevelJupiter:

                //TODO: refactor to one method
                gameState = switchState;
                GameUI.instance.mainMenu.gameObject.SetActive(false);
                mainCamera.backgroundColor = gameSettings.skyColorJupiter;

                player.PlayerToStartPos();
                player.PlayerSetGravity(gameSettings.GravityAccelerationJupiter);
                player.GetComponent<Rigidbody2D>().simulated = true;
                
                break;

            case GameState.MainMenu:

                gameState = GameState.MainMenu;
                GameUI.instance.mainMenu.gameObject.SetActive(true);

                player.GetComponent<Rigidbody2D>().simulated = false;
                player.PlayerToStartPos();
                
                break;

        }

    }

}
