using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject fireball;
    public Transform atttackpoint;
    public float CD = 10f;
    public float wait = 0;
    public bool canShoot = true;
    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            canShoot = false;
            wait = CD;
            GameObject ball = Instantiate(fireball, atttackpoint.position, atttackpoint.rotation);
            Destroy(ball, 1);
        }

        if (wait > 0)
        {
            wait -= Time.deltaTime;
        }
        else { canShoot = true; }

    }
}
