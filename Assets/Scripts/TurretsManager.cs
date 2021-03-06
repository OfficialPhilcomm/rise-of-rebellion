﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurretsManager : MonoBehaviour
{
    public TurretData turretData;
    public GameObject turretPrefab;

    public Transform target = null;

    private List<GameObject> turrets = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        InitializeTurrets();
        SetTarget(target);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializeTurrets()
    {
        foreach (Vector3 position in turretData.positions)
        {
            GameObject turret = Instantiate(turretPrefab, transform.position + position, Quaternion.identity);
            turret.transform.parent = gameObject.transform;
            turrets.Add(turret);
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;

        foreach (GameObject turret in turrets)
        {
            // set target of every turret individually
            turret.GetComponent<TurretController>().SetTarget(target);
        }
    }
}
