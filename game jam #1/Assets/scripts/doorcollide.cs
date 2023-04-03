using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorcollide : MonoBehaviour
{
   
    void Start()
    {
        
    }


    //change this to home 2 for home 2
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))

            
        { 

                SceneManager.LoadScene("home1");

        }


    }

    
    void Update()
    {
        
    }
}
