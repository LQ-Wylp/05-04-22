using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_3 : MonoBehaviour
{
    public float Dammage;
    public float Duration;
    private float InitDuration;
    private Vector3 InitialSize;
    public float TauxScale;

    void Start()
    {
        InitDuration = Duration;
        InitialSize = transform.localScale;
    }

    void Update()
    {
        Duration -= Time.deltaTime;

        float ScaleValue = (1 - (Duration / InitDuration));
        float ScaleValueX = ScaleValue * TauxScale * InitialSize.x;
        float ScaleValueZ = ScaleValue * TauxScale * InitialSize.z;
        
        transform.localScale = new Vector3(ScaleValueX , InitialSize.y, ScaleValueZ);

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
