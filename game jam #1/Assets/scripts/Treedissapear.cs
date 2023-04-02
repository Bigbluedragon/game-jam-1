using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treedissapear : MonoBehaviour


{

    //replace traingle with tree
    public GameObject Triangle;

    public bool isAlive;

    public void killTree()
    {
        Triangle.SetActive(false);
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
