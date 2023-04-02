using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

interface IInteractable
{
    public void Interact();
}

public class Interact : MonoBehaviour
{

    public bool isInRange;
    public KeyCode InteractKey;
    public UnityEvent interactAction;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isInRange)
        {
            if (Input.GetKeyDown(InteractKey))
            {
                interactAction.Invoke();
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("player is now in range");

        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("player is now not in range");

        }


    }

}