using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractExp : MonoBehaviour
{
    public float Range;
    public SphereCollider _Collider;

    void Start()
    {
        ChangeRange();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Exp")
        {
            other.gameObject.GetComponent<Exp>().ActivateAttraction();
        }
    }

    void ChangeRange()
    {
        _Collider.radius = Range;
    }
}
