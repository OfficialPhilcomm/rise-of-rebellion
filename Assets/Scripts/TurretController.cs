using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CannonController))]
public class TurretController : MonoBehaviour
{
    public GameObject laserPrefab;

    private Transform target;

    private float cooldown = 0f;
    private float cooldownMax = 2f;


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
        if(cooldown > 0f)
        {
            cooldown -= Time.deltaTime;
            if(cooldown < 0)
            {
                cooldown = 0;
            }
        } else
        {
            //shoot
            if(target != null)
            {
                Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
                Instantiate(laserPrefab, transform.position, rotation);
                cooldown = cooldownMax;
            }
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
