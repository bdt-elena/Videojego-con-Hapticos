using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
 
    public void empezar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
    public void salir()
    {
        Application.Quit();
        Debug.Log("salir");

    }

}
