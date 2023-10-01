using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbcDef : MonoBehaviour
{
    int healthPoint = 100;
    void Something(int dmg)
    {
        healthPoint -= dmg;
        if (healthPoint < 1)
        {
            print("hmmmm");
        }
        else if (healthPoint < 50)
        {
            print("asd");
        }
        else
        {
            print("dads");
        }
    }
    private void Update()
    {
        Something(10);
    }

}
