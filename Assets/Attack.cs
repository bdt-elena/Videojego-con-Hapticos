using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    Rigidbody2D myRB;
    Animator my_anim;
    private bool bonk;
    public GameObject Bonk;
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackpos;
    public LayerMask whatIsEnemies;
    public float attackrange;
    public int damage;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        my_anim = GetComponent<Animator>();
    }
    
    void FixedUpdate()
    {
        if (startTimeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                bonk = true;
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackpos.position, attackrange, whatIsEnemies);

                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Mov_cat>().Takedamage(damage);
                    Destroy(Instantiate(Bonk, attackpos.position, Quaternion.identity), 1f);
                }

            }
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            startTimeBtwAttack -= Time.deltaTime;
        }

        float move = Input.GetAxis("Horizontal");

        HandleBonk();
        ResetValues();

        if (!this.my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk")) //Si está atacando no correrá
        {
         
        }
        else if (my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk"))//Si ataca la velocidad es 0
        {

        }
    }
    private void HandleBonk()
    {
        if (bonk && !this.my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk"))
        {
            my_anim.SetTrigger("Bonk");
        }
    }
    private void ResetValues()
    {
        bonk = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackpos.position, attackrange);
    }
}
