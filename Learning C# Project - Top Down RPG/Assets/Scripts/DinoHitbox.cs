using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoHitbox : Collidable
{
    // Damage
    public int damage = 1;
    public float pushForce = 5;

    public GameObject dinoTrainer;
    public GameObject player;

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
            
            coll.SendMessage("ReceiveDamage", dmg);
            dinoTrainer.transform.position = player.transform.position / 0.5f;
        }
    }
}