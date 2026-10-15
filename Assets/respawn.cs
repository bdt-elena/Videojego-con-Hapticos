using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{

    public GameObject[] vidas;
    private int life;
    
    void Start()
    {
        life = vidas.Length;
    }

    void Update()
    {

        if (life < 1)
        {
            Destroy(vidas[0].gameObject);
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(life < 2){

            Destroy(vidas[1].gameObject);
           
        }
        else if (life < 3)
        {
            Destroy(vidas[2].gameObject);
            
        }

    }

    public void PlayerDamaged()
    {

        life--;
    }
  
}
