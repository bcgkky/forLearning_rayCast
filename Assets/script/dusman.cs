using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    int saglik;
    void Start()
    {
        saglik = 100;
    }

    public void DarbeAl(int darbegucu)
    {
        if (saglik <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            saglik -= darbegucu;
        }
    }
}
