using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 6;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 3;
    }  
}
