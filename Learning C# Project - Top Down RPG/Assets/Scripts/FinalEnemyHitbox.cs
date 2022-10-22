using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyHitbox : Collidable
{
    // Damage
    public int damage = 1;
    public float pushForce = 5;

    public GameObject smallGreekGoblinEnemy;
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
            
            GameObject greekBoss = GameObject.Find("GreekBoss");
            Boss boss = greekBoss.GetComponent<Boss>();
            boss.hitpoint++;
            Instantiate(smallGreekGoblinEnemy, Vector3.zero, Quaternion.identity);
            GameManager.instance.ShowText("+ hp", 25, Color.green, transform.position, Vector3.up * 30, 1.0f);
            coll.SendMessage("ReceiveDamage", dmg);
        }
    }
}