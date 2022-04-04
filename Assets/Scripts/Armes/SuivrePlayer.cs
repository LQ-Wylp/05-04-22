using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuivrePlayer : MonoBehaviour
{
    void Update()
    {
        transform.position = PlayerManager._playerManager.Player.transform.position;
    }
}
