using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Turret Data")]
public class TurretData : ScriptableObject
{
    public List<Vector3> positions;
}
