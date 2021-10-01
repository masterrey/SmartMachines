using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCar : MonoBehaviour
{
    public float acell = 0;
    public float turn = 0;

   public bool playerControl = false;
    public WheelCollider[] wheelColliders;
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerControl)
        {
            
            acell = Input.GetAxis("Vertical");
            turn = Input.GetAxis("Horizontal");
        }

        for (int i = 0; i < wheelColliders.Length; i++)
        {
            if (i <= 1)
            {
                wheelColliders[i].steerAngle = 30 * turn;
            }
            wheelColliders[i].motorTorque = 500 * acell;
            
        }
    }
}
