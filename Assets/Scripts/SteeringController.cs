using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringController : MonoBehaviour
{
    public static readonly int STEER_NONE = 0;
    public static readonly int STEER_LEFT = 1;
    public static readonly int STEER_RIGHT = 2;

    public float maxSteering = 1f;
    [SerializeField]
    private float steer = 0f;
    private float targetSteer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Steer(STEER_RIGHT);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, steer * Time.deltaTime, 0);

        float diff = targetSteer - steer;
        steer += diff * 0.002f;

        if(Math.Abs(diff) < 0.02f)
        {
            steer = targetSteer;
        }
    }

    public void Steer(int steerDirection)
    {
        if(steerDirection == STEER_NONE)
        {
            targetSteer = 0f;
            return;
        }
        if(steerDirection == STEER_LEFT)
        {
            targetSteer = -maxSteering;
            return;
        }
        if(steerDirection == STEER_RIGHT)
        {
            targetSteer = maxSteering;
            return;
        }
        throw new NotImplementedException("Steer direction not known");
    }
}
