using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour
{
    public int Experience;
    public GameObject _gameObject;
    public bool Attracted;

    public float speed = 2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<ExpPlayer>().TakeExp(Experience);
            Destroy(_gameObject);
        }
    }

    public void ActivateAttraction()
    {
        Attracted = true;
    }

    void Update()
    {
        if(Attracted)
        {
            float pourcentage = Time.deltaTime * speed / Vector3.Distance(transform.position, PlayerManager._playerManager.Player.transform.position);
            transform.position = Vector3.Lerp(transform.position, PlayerManager._playerManager.Player.transform.position, pourcentage);
        }
    }
}
