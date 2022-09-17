using System;
using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using UnityEngine;

public class MotherShipToCall : MonoBehaviour
{
    public motherShipScript MotherShip;

    public Health EnemyHealth;
    // Start is called before the first frame update
    void Start()
    {
        MotherShip = (GameObject.Find("Mother ship Room 2")).GetComponent<motherShipScript>() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth.getHeathAmmount() <= 0f)
        {
            MotherShip.EnemyDown(); // tells the that its down
            
        }
    }
    
    
}
