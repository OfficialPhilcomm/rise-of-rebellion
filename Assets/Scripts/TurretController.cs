using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CannonController))]
public class TurretController : MonoBehaviour
{
    private Transform target;

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
    }
}
