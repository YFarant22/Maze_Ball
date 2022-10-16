using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trap_event : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "ball")
        {
            print("Detected");
        }
    }
}
