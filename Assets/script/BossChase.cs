using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChase : MonoBehaviour
{
    public GameObject Player;
    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, Player.gameObject.transform.position, 2 * Time.deltaTime);
    }
}
