using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool canTouch = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("Player") && canTouch)
        {
            canTouch = false;
            other.gameObject.GetComponent<Player>().collectCoins();
            Destroy(gameObject);
        }
    }
}
