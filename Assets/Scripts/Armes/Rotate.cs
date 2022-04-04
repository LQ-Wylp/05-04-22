using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float Speed;

    public bool InYAxis;
    public bool InZAxis;
    public bool IsEnemy1;
    void Update()
    {
        if (InYAxis == true)
        {
            //Arme

            transform.Rotate(0, 1 * Speed * Time.deltaTime, 0, Space.World);
        }
        if (InZAxis == true)
        {

            //Roue
            transform.Rotate( 0, 0, -1 * Speed * Time.deltaTime, Space.Self);
        }
        if (IsEnemy1 == true)
        {

            //Roue
            transform.Rotate(0, 1 * Speed * Time.deltaTime, 0, Space.Self);
        }
    }
}
