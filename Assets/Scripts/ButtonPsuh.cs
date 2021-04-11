using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPsuh : MonoBehaviour
{
    private GameObject tennisBall;
    // Start is called before the first frame update
    void Start()
    {
        tennisBall = GameObject.Find("TennisBall");
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(tennisBall, new Vector3(0.0f, 2.0f, -5.0f), Quaternion.identity);
    }
}