using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minecart : MonoBehaviour
{
    public float waarde1;
    public float waarde2;
    public float waarde3;
    public GameObject railTrackPointA;
    public GameObject railTrackPointB;

    void Awake()
    {
        waarde1 = railTrackPointA.transform.position.z;
        waarde2 = railTrackPointB.transform.position.z;
    }

    void Update()
    {
        transform.position = new Vector3(railTrackPointA.transform.position.x, railTrackPointA.transform.position.y, (Mathf.Lerp(waarde1, waarde2, waarde3)));
        waarde3 += Time.deltaTime;
        if(waarde3 > 1)
        {
            float temp = waarde2;
            waarde2 = waarde1;
            waarde1 = temp;
            waarde3 = 0;
        }
    }
}