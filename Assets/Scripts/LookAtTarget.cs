using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if(target !=null)
        {
            transform.LookAt(target, Vector3.up);
        }
    }
}
