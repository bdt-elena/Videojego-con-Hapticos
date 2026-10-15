using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Movimiento : MonoBehaviour
{
    Rigidbody2D myRB;
    bool facing_right = true;
    SpriteRenderer my_render;
    Animator my_anim;
    public float max_speed;
  

    void Start()
    {
        
        myRB = GetComponent<Rigidbody2D>();
        my_render = GetComponent<SpriteRenderer>();
        my_anim = GetComponent<Animator>();

    }

   
 
    void FixedUpdate()
    {
        //if (startTimeBtwAttack <= 0)
        //{
        //    if (Input.GetKey(KeyCode.Mouse0))
        //    {
        //        bonk = true;
        //        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackpos.position, attackrange, whatIsEnemies);

        //        for (int i = 0; i < enemiesToDamage.Length; i++)
        //        {
        //            enemiesToDamage[i].GetComponent<Mov_cat>().Takedamage(damage);
        //            Destroy(Instantiate(Bonk, attackpos.position, Quaternion.identity), 1f);
        //        }

        //    }
        //    timeBtwAttack = startTimeBtwAttack;
        //}
        //else
        //{
        //    startTimeBtwAttack -= Time.deltaTime;
        //}

        float move = Input.GetAxis("Horizontal");
        
        if (move > 0 && !facing_right)
            Flip();
        else if (move < 0 && facing_right)
            Flip();
        //HandleBonk();
        //ResetValues();
        //if (!this.my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk")) //Si está atacando no correrá
        //{
            myRB.velocity = new Vector2(move * max_speed, myRB.velocity.y);
        //}
        //else if (my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk"))//Si ataca la velocidad es 0
        //{

        //}
        
        my_anim.SetFloat("Move_speed", Mathf.Abs (move));

       

    }


    //private void HandleBonk()
    //{
    //    if (bonk && !this.my_anim.GetCurrentAnimatorStateInfo(0).IsTag("Att_Bonk"))
    //    {
    //        my_anim.SetTrigger("Bonk");
    //    }
    //}
    void Flip()
    {
        facing_right = !facing_right;
        my_render.flipX = !my_render.flipX;
    }

    //private void ResetValues() {
    //    bonk = false;
    //}


    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(attackpos.position, attackrange);
    //}
}
