using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public bool isUp = false;

    private void Update()
    {
        if (isUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, top.position, 0.5f * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, bottom.position, 0.4f *Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            isUp = !isUp;
        }
        
    }
}
