using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dommageable : MonoBehaviour
{
    public float Dommage;
    public GameObject _gameObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<HpSystemPlayer>().TakeDammage(Dommage);
            Destroy(_gameObject);
        }
    }
}
