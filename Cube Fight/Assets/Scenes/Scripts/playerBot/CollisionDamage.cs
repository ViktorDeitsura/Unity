using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    private int delay = 1;
    private GameObject enemyObj;
    private int health;


    private void OnCollisionEnter( Collision other )
    {
        enemyObj = other.gameObject;
        health = enemyObj.GetComponent<PBStats>().health;
        TakingDamage();
    }

    private void TakingDamage()
    {
        int enemyKills = GetComponent<PBStats>().enemyKills;
        int bonusDamage = enemyKills * 5;
        int damage = collisionDamage + bonusDamage;
        health -= damage;
        if ( enemyObj != null ) {
            enemyObj.GetComponent<PBStats>().health = health;
        }
        if ( health <= 0 ) {
            GetComponent<PBStats>().enemyKills++;
            PBSpawner.playerBotOnScreen--;
            return;
        }
        Invoke( "TakingDamage", delay );
    }
}
