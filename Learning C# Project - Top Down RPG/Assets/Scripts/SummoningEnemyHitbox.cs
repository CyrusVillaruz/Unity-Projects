using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummoningEnemyHitbox : Collidable
{
    // Damage
    public int damage = 1;
    public GameObject smallBatEnemy;
    public float pushForce = 5;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.tag == "Fighter" && coll.name == "Player")
        {
            // Create a new damage object before sending it to the player
            Damage dmg = new Damage
            {
                damageAmount = damage,
                origin = transform.position,
                pushForce = pushForce
            };
            
            Instantiate(smallBatEnemy, Vector3.zero, Quaternion.identity);
            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
