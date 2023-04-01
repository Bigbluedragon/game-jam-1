using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmerJobSelect : MonoBehaviour
{
    public void jobSelect()
    {
        SceneManager.LoadScene("FarmerLife");
    }
}
