using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class motherShipScript : MonoBehaviour
{
    public GameObject[] spawnPoints;
    private int randomInt;
    public GameObject enemy;
    public int numberOfStartingEnemies;
    public GameObject Thanos;
    
    

    public int numberOfEnemyForRoom;

    private void Start()
    {
        spawnEnemies(numberOfStartingEnemies);
        spawnThanos();
    }
    // Start is called before the first frame update

    void spawnEnemies(int numberOfEnemies)
    {
        for (int x = 1; x <= numberOfEnemies; x++)
        {
            randomInt = Random.Range(0, spawnPoints.Length); //chooses random number to choose spawn point
            Instantiate(enemy, spawnPoints[randomInt].transform.position, Quaternion.identity);
        }
    }

    public void EnemyDown()
    {
        numberOfEnemyForRoom--;
        StartCoroutine("respawn");
    }

    public void ThanosDown()
    {
        StartCoroutine("respawnThanos");
    }

    IEnumerator  respawn()
    {
        yield return new WaitForSecondsRealtime(2f);
        spawnEnemies(1);
        numberOfEnemyForRoom++;
        Debug.Log("Respawd");
    }
    
    IEnumerator  respawnThanos()
    {
        yield return new WaitForSecondsRealtime(20f);
        spawnThanos();
        Debug.Log("Respawd Thanos");
    }

    private void spawnThanos()
    {
        randomInt = Random.Range(0, spawnPoints.Length); //chooses random number to choose spawn point
        Instantiate(Thanos, spawnPoints[randomInt].transform.position, Quaternion.identity);
    }
}
