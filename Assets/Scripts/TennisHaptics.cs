using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisHaptics : MonoBehaviour
{

    public SerialHandler serialHandler;
    private int parameter_int;
    private string parameter_str;
    private Vector3 tmp;

    // Start is called before the first frame update
    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
        tmp = GameObject.Find("Racket").transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

        tmp.x = Mathf.Abs(tmp.x) % 180;
        parameter_int = (int)tmp.x;
        parameter_str = parameter_int.ToString();
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Racket"))
        {
            serialHandler.Write(parameter_str);
        }
    }

    void OnDataReceived(string message)
    {
        var data = message.Split(
                new string[] { "\n" }, System.StringSplitOptions.None);
        if (data.Length < 2) return;

        try
        {
        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }

}
