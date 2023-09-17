using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tp2;   
    private void OnCollisionEnter(Collision collision)
    {
       print("Collide");
       collision.gameObject.transform.position = tp2.transform.position + new Vector3(0,0,2);
    }   
}
