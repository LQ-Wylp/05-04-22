using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSystem : MonoBehaviour
{
    private float HealthRemaning;
    public float MaxHealth;

    // Start is called before the first frame update
    void Start()
    {
        HealthRemaning = MaxHealth;
    }

    public void TakeDammage(float dommage)
    {
        HealthRemaning -= dommage;
        if(HealthRemaning <= 0)
        {
            Debug.Log("T'es mort");
        }
    }
}
