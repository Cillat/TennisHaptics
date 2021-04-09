using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var v = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y;
        Vector3 velocity = new Vector3(0, 0, v);
        velocity = transform.TransformDirection(velocity);
        velocity *= 5f;
        transform.localPosition += velocity * Time.fixedDeltaTime;


        var h = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).x;
        transform.Rotate(0, h * 3f, 0);
    }
}





