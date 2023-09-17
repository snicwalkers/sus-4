using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingfireball : MonoBehaviour
{
    public int speed = 1;
    void Update()
    {
        transform.Translate(0, 0, speed *Time.deltaTime);
    }
}
