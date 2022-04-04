using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform transformPlayer;
    public float smoothTime = 0.3F;

    private Vector3 Velocity = Vector3.zero;
    private Vector3 InitialPos;

    void Start()
    {
        transformPlayer = PlayerManager._playerManager.transform;
        InitialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transformPlayer.position;
        newpos += InitialPos;
        
        transform.position = Vector3.SmoothDamp(transform.position, newpos, ref Velocity, smoothTime, Mathf.Infinity);
    }
}
