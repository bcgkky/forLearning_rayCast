﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject,2f);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * 80 * Time.deltaTime);
    }
}
