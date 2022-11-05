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
        maxHealth = 100;
        health = maxHealth;
        speed = 1;
    }

    public void TakeHit(int damage)
    {
        bonusDamage = enemyKills * 5;
        damage = damage + bonusDamage;
        health -= damage;

        if ( health <= 0 ) {
            Destroy( gameObject );
        }
    }

}
