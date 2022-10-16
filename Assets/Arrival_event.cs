using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrival_event : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Ball")
        {
            print("Detected");
        }
    }
}
