using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.transform.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
