using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour
{
    public bool PuedoSaltar;
    Rigidbody2D myRB;
    public float JumpForce = 20f, Radio = 0.5f;
    public Transform Pie;
    public LayerMask SueloLayer;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        PuedoSaltar = Physics2D.OverlapCircle(Pie.position, Radio, SueloLayer);
        if (PuedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRB.velocity = new Vector2(myRB.velocity.x, JumpForce * 10);


            }
        }
    }
}
