using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aimant : MonoBehaviour
{
    public Exp[] AllExp;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            AllExp = FindObjectsOfType<Exp>();
            for(int i = 0; i < AllExp.Length; i++)
            {
                AllExp[i].ActivateAttraction();
            }
            Destroy(gameObject);
        }
    }
}
