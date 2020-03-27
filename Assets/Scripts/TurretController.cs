using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CannonController))]
public class TurretController : MonoBehaviour
{
    private Transform target;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Debug.DrawRay(transform.position, target.position - transform.position, Color.green);
            Debug.Log(target.position);
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
