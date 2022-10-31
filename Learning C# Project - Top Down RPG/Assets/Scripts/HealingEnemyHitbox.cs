using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEnemyHitbox : Collidable
{
    // Damage
    public int damage = 1;
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
            
            GameObject breadBoss = GameObject.Find("BreadBoss");
            Boss boss = breadBoss.GetComponent<Boss>();
            boss.hitpoint++;
            GameManager.instance.ShowText("+ hp", 25, Color.green, transform.position, Vector3.up * 30, 1.0f);
            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
