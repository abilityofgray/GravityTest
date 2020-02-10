using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSettings : ScriptableObject
{

    [Header("Player Setup")]
    //by default
    [SerializeField]
    float playerLeanForce = 25.5f;

    [Header("Planet Setup")]
    public Color[] skyColors;

    

    float planetGravity;
    float ballHit;
    Vector3 startPosPlayer;
    

    public float PlanetGravity {

        get { return planetGravity; }
        set { planetGravity = value; }

    }

    public float BallHit {

        get { return ballHit; }
        set { ballHit = value; }

    }

    public Vector3 StartPosPlayer
    {

        get { return startPosPlayer; }
        set { startPosPlayer = value; }

    }

    public float GetPlayerLeanForce {

        get { return playerLeanForce; }

    }
}
