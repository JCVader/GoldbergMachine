using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    [Tooltip("Fizyka zwolni jak dany gameobject ruszy się o taką odległość")]
    [Range(0f, 1f)]
    public float distanceTreshold = 0.1f;
    Vector3 startPosition;

    void Awake()
    {
        startPosition = transform.position;
        SpiddUp();
    }

    void Update()
    {
        if (HasMoved())
            SlowDown();
    }

    private void SpiddUp()
    {
        Time.timeScale = 5;
        Debug.Log("Setting timescale to 10 until " + gameObject.name + " will move \n", this);
    }

    private void SlowDown()
    {
        Time.timeScale = 1;
        Debug.Log(gameObject.name + " moved more than " + distanceTreshold + "m\n", this);
        enabled = false;
    }

    private bool HasMoved()
    {
        return Vector3.Distance(transform.position, startPosition) > distanceTreshold;
    }
}