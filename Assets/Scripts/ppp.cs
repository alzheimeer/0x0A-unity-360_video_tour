using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppp : MonoBehaviour
{

    private bool kas = false;
    public void info()
    {
        if (kas == false)
        {
            gameObject.SetActive(true);
            kas = true;
        }
        else
        {
            gameObject.SetActive(false);
            kas = false;
        }
    }
}
