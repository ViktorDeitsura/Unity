using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovieLight : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent playerBot;
    private GameObject foundObject;
    private GameObject targetObj;

    void Start()
    {
        playerBot = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        if ( PBSpawner.playerBotArr.Length >= 4 ) {
            targetObj = NearPlayerBot();
            playerBot.SetDestination( targetObj.transform.position );
        }
    }

    private GameObject NearPlayerBot()
    {
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach ( GameObject go in PBSpawner.playerBotArr ) {
            float curDistance = Vector3.Distance( go.transform.position, position );
            if ( curDistance < distance && curDistance > 1 ) {
                foundObject = go;
                distance = curDistance;
            }
        }
        return foundObject;
    }
}
