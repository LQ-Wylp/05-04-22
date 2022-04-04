using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arme_4 : MonoBehaviour
{
    public GameObject Bullet;
    public float FrequenceTir;
    private float Timer;

    public cdSpell _cdSpell;

    void Update()
    {
        Timer += Time.deltaTime;
        _cdSpell.RefreshVisuel(FrequenceTir , Timer);
        if(Timer > FrequenceTir)
        {
            Timer = 0;
            Shot();
        }
    }

    void Shot()
    {
        GameObject LastBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
        LastBullet.transform.position = new Vector3(transform.position.x, 5.0f, transform.position.z);
        LastBullet.gameObject.SetActive(true);
    }
}
