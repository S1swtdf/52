using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform pos;
    public GameObject obk;
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = pos.transform.position;
    }
}
