using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_4 : MonoBehaviour
{
    public float Dammage;
    public float Duration;

    void Update()
    {
        Duration -= Time.deltaTime;
        if(Duration <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ennemi")
        {
            other.gameObject.GetComponent<HpSystemMonster>().TakeDammage(Dammage);
        }
    }
}
