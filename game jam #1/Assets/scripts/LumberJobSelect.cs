using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LumberJobSelect : MonoBehaviour
{
    public void jobSelect()
    {
        SceneManager.LoadScene("LumberLife");
    }
}
