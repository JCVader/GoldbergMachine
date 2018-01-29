using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.material = null;
        other.GetComponent<Rigidbody>().mass = 0.05f;
        Debug.Log("Material disabled");


    }

}
