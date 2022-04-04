using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombe : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            GameObject LastBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            LastBullet.gameObject.SetActive(true);

            Destroy(this.gameObject);
        }
    }
}
