using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_Rotation : MonoBehaviour
{
    public Vector3 current_rot;

    // Update is called once per frame
    void Update()
    {
        current_rot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") > .2) && (current_rot.z <= 8 || current_rot.z >= 350))
        {
            transform.Rotate(0, 0, (float)0.2);
        }

        if ((Input.GetAxis("Horizontal") < -.2) && (current_rot.z >= 351 || current_rot.z <= 9))
        {
            transform.Rotate(0, 0, (float)-0.2);
        }

        if ((Input.GetAxis("Vertical") > .2)  && (current_rot.x <= 8 || current_rot.x >= 350))
        {
            transform.Rotate((float)0.2, 0, 0);
        }

        if ((Input.GetAxis("Vertical") < -.2) && (current_rot.x >= 351 || current_rot.x <= 9))
        {
            transform.Rotate((float)-0.2, 0, 0);
        }
    }
}
