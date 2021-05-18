using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisHaptics : MonoBehaviour
{

    public SerialHandler serialHandler;
    private byte[] parameter = new byte[1];
    private Vector3 tmp;
    OVRGrabbable ovrGrabbable;
    GameObject racket;

    // Start is called before the first frame update
    void Start()
    {
        racket = GameObject.Find("GameStage/Racket");
        ovrGrabbable = racket.GetComponent<OVRGrabbable>();
        //Debug.Log("TennisHaptics racket" + racket.name);
        tmp = racket.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        tmp = racket.transform.localEulerAngles;
        tmp.x = Mathf.Abs(tmp.x) % 180;
        parameter[0] = (byte)tmp.x;

        if(ovrGrabbable.isGrabbed)
        {
            serialHandler.Write(parameter);
        }
        //Debug.Log("TennisHaptics tmp" + tmp);

    }


    //void OnDataReceived(string message)
    //{
    //    var data = message.Split(
    //            new string[] { "\n" }, System.StringSplitOptions.None);
    //    if (data.Length < 2) return;

    //    try
    //    {
    //    }
    //    catch (System.Exception e)
    //    {
    //        Debug.LogWarning(e.Message);
    //    }
    //}

}
