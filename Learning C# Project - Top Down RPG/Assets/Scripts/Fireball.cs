using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Collidable
{
    Rigidbody2D FireballRb;
    public int damagePoint = 3;
    public float pushForce = 2.0f;

    protected override void Start()
    {
        FireballRb = GetComponent<Rigidbody2D>();
    }

    protected override void Update()
    {
        if (FireballRb.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 180, transform.rotation.z);
        
        }
    }
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.tag == "Fighter")
        {
            if (coll.name == "Player")
                return;

            // Create a new damage object, then we'll send it to the fighter we've hit
            Damage dmg = new Damage
            {
                damageAmount = damagePoint,
                origin = transform.position,
                pushForce = pushForce
            };
            
            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}
