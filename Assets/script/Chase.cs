using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, player.gameObject.transform.position, 2 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().attacked();
        }
    }
}

        
            