using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CannonController))]
public class TurretController : MonoBehaviour
{
    private Transform target = null;

    private List<GameObject> turrets = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTarget(Transform target)
    {
        this.target = target;

        foreach(GameObject turret in turrets)
        {
            // set target of every turret individually
        }
    }
}
