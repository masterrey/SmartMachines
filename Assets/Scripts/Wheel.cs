using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public GameObject visual;
    WheelCollider fWheel;
    // Start is called before the first frame update
    void Start()
    {
        fWheel = GetComponent<WheelCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos;
        Quaternion rot;
        fWheel.GetWorldPose(out pos,out  rot);

        visual.transform.position = pos;
        visual.transform.rotation = rot;
    }
}
