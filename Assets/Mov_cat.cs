using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mov_cat : MonoBehaviour
{
    public int healt;
    private Rigidbody2D myRB;
    public float velocidad = 1f;
    public float velocidadm = 1f;

  
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }
   
    void FixedUpdate()
    {

        if (healt <= 0)
        {
          
        }

        myRB.AddForce(Vector2.left * velocidad);

        float limitedSpeed = Mathf.Clamp(myRB.velocity.x, -velocidadm, velocidadm);
        myRB.velocity = new Vector2(limitedSpeed, myRB.velocity.y);

    }

    public void Takedamage(int damage)
    {
        healt -= damage;
        Debug.Log("Damage Taken !");
        Destroy(gameObject);
    }

}
