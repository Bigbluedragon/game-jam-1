using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class Treedissapear : MonoBehaviour


{
    public GameObject Triangle;


    //replace traingle with tree
    private float health = 3f;
    public Sprite OneHp;
    public Sprite ZeroHp;
    public Sprite TwoHp;
    public int count;
    public TMP_Text text;


    public bool isAlive;

    public void HurtTree()
    {

        if (health == 0f)
        {
            Triangle.gameObject.SetActive(false);
            count += 5;
            PlayerPrefs.SetInt("amount", count);
            text.text = "coins " + count;
        }
        if (health == 2f)
        {
            Triangle.GetComponent<SpriteRenderer>().sprite = OneHp;
            health = health - 1f;
            
        }
        if (health == 1f)
        {
            Triangle.GetComponent<SpriteRenderer>().sprite = ZeroHp;
            health = health - 1f;

        }
        if (health == 3f)
        {
            Triangle.GetComponent<SpriteRenderer>().sprite = TwoHp;
            health = health - 1f;

        }
        
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
