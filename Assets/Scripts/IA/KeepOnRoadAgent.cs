using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class KeepOnRoadAgent : Agent
{
    public override void OnActionReceived(ActionBuffers actionBuffers)

    {
     
        Debug.Log("teste");
       
       
    }

    public override void CollectObservations(VectorSensor sensor)
    {
      
        Debug.Log("teste out");
        sensor.AddObservation(transform.position);
    }

}
