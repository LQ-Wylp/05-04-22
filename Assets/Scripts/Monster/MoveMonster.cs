using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMonster : MonoBehaviour
{
    [Header("Option")]
    public bool _MoveActive = true;

    [Header("Controls")]
    public Vector2 _Move;

    [Header("Physics")]
    public float _RotateSpeed;
    public float _Acceleration = 100;
    public float _Friction = 10;
    private Vector3 _Velocity;
    private CharacterController _CharacterController;
    public float _GravityPower = 1;

    void Start()
    {
        _CharacterController = GetComponent<CharacterController>();
        _Velocity = Vector3.zero;
    }

    void Update()
    {
        _Move = PlayerManager._playerManager._MoveInput;

        if(_MoveActive)
        {
            Vector3 move = Vector3.zero;
            move += transform.forward * _Acceleration;

            transform.LookAt( PlayerManager._playerManager.Player.transform ,Vector3.up);

            _Velocity += move * Time.deltaTime;
            _Velocity += Physics.gravity * _GravityPower * Time.deltaTime;

            float VerticalVel = _Velocity.y;
            Vector2 HorizontalVel = _Velocity.xz();
            HorizontalVel -= HorizontalVel * _Friction * Time.deltaTime;
            _Velocity = HorizontalVel.x_y(VerticalVel);

            _CharacterController.Move(_Velocity * Time.deltaTime);
            
            if (_CharacterController.isGrounded)
            {
                _Velocity.y = 0;
            }
        }
    }
}
