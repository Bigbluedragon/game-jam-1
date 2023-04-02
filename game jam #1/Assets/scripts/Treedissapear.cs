using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Treedissapear : MonoBehaviour


{
    public Triangle.gameObject;
    

    //replace traingle with tree
   

    public bool isAlive;

    public void killTree()
    {
        Traingle.gameObject.SetActive(false);
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
