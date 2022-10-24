using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileAtk : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] magicMissiles;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake() 
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();   
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.E) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("shoot");
        cooldownTimer = 0;
        
        magicMissiles[FindMissile()].transform.position = firePoint.position;
        magicMissiles[FindMissile()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

    private int FindMissile()
    {
        for (int i = 0; i < magicMissiles.Length; i++)
        {
            if(!magicMissiles[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
