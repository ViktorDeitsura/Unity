using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovieLight : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent playerBot;

    void Start()
    {
        playerBot = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        SeekTarget();
    }

    private void SeekTarget()
    {
        bool trueTarget = false;
        int arrNum = 0;
        if ( PBSpawner.playerBotArr.Length >= 2 ) {
            while ( !trueTarget ) {
                if ( PBSpawner.playerBotArr[arrNum].transform.position != playerBot.transform.position ) {
                    playerBot.SetDestination( PBSpawner.playerBotArr[arrNum].transform.position );
                    trueTarget = true;
                }
                arrNum++;
            }
        }
    }
}
