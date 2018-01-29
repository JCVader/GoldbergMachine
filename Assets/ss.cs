using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().mass = 10;
    }
}
