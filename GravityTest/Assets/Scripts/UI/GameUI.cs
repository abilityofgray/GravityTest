using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public static GameUI instance = null;

    // Start is called before the first frame update
    public TextMeshProUGUI ballHit;
    public RawImage background;

    void Start()
    {

        if (instance == null) instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
