﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshOff : MonoBehaviour
{
    void Awake()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
