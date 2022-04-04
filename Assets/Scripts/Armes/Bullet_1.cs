using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_1 : MonoBehaviour
{
    public float speed;
    public float Dammage;
    public Vector3 Direction;

    void Update()
    {
        transform.position += Direction * speed * Time.deltaTime;    
    }

    public void AtSpawn(GameObject Target)
    {
        transform.LookAt(Target.transform ,Vector3.up);
        Direction = Target.transform.position - transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ennemi")
        {
            other.gameObject.GetComponent<HpSystemMonster>().TakeDammage(Dammage);
            Destroy(gameObject);
        }
    }
}
