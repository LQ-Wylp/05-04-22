using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    public float Duration;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer > Duration)
        {
            Destroy(gameObject);
        }
    }
}
