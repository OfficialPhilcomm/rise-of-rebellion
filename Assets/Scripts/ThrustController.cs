using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustController : MonoBehaviour
{
    public static readonly int THRUST_NONE = 0;
    public static readonly int THRUST_FULL = 1;

    public float maxThrust = 10f;
    private float thrust = 0f;
    private float targetThrust = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.y);
        Vector3 moveVector = new Vector3(0, 0, 0);
        /*transform.Rotate(0, steer * Time.deltaTime, 0);

        float diff = targetSteer - steer;
        steer += diff * 0.002f;

        if (diff < 0.02f)
        {
            steer = targetSteer;
        }*/
    }

    public void Thrust(int thrustPower)
	{
        if(thrustPower == THRUST_NONE)
		{
            targetThrust = 0f;
            return;
		}
        if(thrustPower == THRUST_FULL)
		{
            targetThrust = maxThrust;
            return;
		}
        throw new NotImplementedException("Thrust power not known");
	}
}
