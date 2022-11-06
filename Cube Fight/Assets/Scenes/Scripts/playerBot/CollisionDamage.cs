using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;

    void OnCollisionEnter( Collision other )
    {
        print(other.gameObject.name);
    }
}
