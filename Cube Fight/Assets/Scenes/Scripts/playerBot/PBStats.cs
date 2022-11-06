using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBStats : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int enemyKills;
    public int bonusDamage;
    public int speed;

    void Start()
    {
        enemyKills = 0;
        maxHealth = Random.Range( 50, 250 );
        health = maxHealth;
        speed = Random.Range( 0, 7 );
    }

    void Update()
    {
        if ( health <= 0 ) {
            Destroy( gameObject );
        }
    }


}
