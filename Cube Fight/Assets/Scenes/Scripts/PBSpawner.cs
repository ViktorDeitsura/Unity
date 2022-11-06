using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBSpawner : MonoBehaviour
{
    public GameObject[] enemy;
    public Transform[] spawnPoint;
    public int delay;
    public int playerBotLimit;
    public static GameObject[] playerBotArr;

    private int rand;
    private int randPosition;

    void Start()
    {
        if ( delay < 5 ) {
            delay = 20;
        }
        if ( playerBotLimit < 2 ) {
            playerBotLimit = 2;
        } else if ( playerBotLimit >= 12 ) {
            playerBotLimit = 12;
        }
        spawn();
    }


    void Update()
    {

    }

    private void spawn()
    {
        if ( enemy.Length < playerBotLimit ) {
            rand = Random.Range( 0, enemy.Length );
            randPosition = Random.Range( 0, spawnPoint.Length );
            Instantiate( enemy[rand], spawnPoint[randPosition].transform.position, Quaternion.identity );
            playerBotArr = GameObject.FindGameObjectsWithTag("playerBot");
        }
        Invoke( "spawn", delay );
    }

    public void RegisterPlayerBot()
    {

    }
}
