using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;
using Object = System.Object;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f; // Скорость движения, а в дальнейшем ускорение
    private Vector3 _MoveDirection; // Направление движения
    private Vector3 _inputAxis;

    private Rigidbody _body; 

    private void Start()
    {

        _body = GetComponent<Rigidbody>();

        PlayerInputs.OnInput += Move;
        

    }

    private void Move(Vector3 input)
    {
        _MoveDirection.Set(input.x, 0, input.z);
        
        _body.AddForce(_MoveDirection * _speed);
        
    }
    
    
    private void Update()
    {
        
        transform.LookAt(_MoveDirection + transform.position);

    }
        
    private void LateUpdate()
    {
        if (_MoveDirection == Vector3.zero)
        {
            _body.velocity = Vector3.zero;
        }
    }

}
