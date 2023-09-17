using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed = 30;
    }    

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed = 10;
    }
}
