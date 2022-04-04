using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager _playerManager;
    public GameObject Player;
    public Camera mainCamera;
    public Vector2 _MoveInput;
    public float _Accel;

    void Awake()
    {
        if(PlayerManager._playerManager == null)
        {
            _playerManager = this;
        }
        else
        {
            Destroy(this);
        }

        Player = this.gameObject;
    }

    public void OnMove(InputValue value)
    {
        _MoveInput = value.Get<Vector2>();
    }

    public void OnAccel(InputValue value)
    {
        _Accel = value.Get<float>();
    }

}
