using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSettings : ScriptableObject
{

    float planetGravity;
    float ballHit;
    public Color[] skyColors;

    public float PlanetGravity {

        get { return planetGravity; }
        set { planetGravity = value; }

    }

    public float BallHit {

        get { return ballHit; }
        set { ballHit = value; }

    }
    
}
