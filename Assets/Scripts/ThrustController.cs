using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustController : MonoBehaviour
{
    public static readonly int THRUST_NONE = 0;
    public static readonly int THRUST_FULL = 1;

    public float maxSpeed = 10f;
    [SerializeField]
    private float speed = 0f;
    private float targetSpeed = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        float diff = targetSpeed - speed;
        speed += diff * 0.007f;

        if (Math.Abs(diff) < 0.02f)
        {
            speed = targetSpeed;
        }
    }

    public void Thrust(int thrustPower)
	{
        if(thrustPower == THRUST_NONE)
		{
            targetSpeed = 0f;
            return;
		}
        if(thrustPower == THRUST_FULL)
		{
            targetSpeed = maxSpeed;
            return;
		}
        throw new NotImplementedException("Thrust power not known");
	}
}
