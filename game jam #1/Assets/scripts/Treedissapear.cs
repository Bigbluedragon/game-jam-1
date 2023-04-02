using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Treedissapear : MonoBehaviour


{
    public GameObject Triangle;
    

    //replace traingle with tree
   

    public bool isAlive;

    public void killTree()
    {
        Triangle.gameObject.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
