using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    public PlayerInputActions _playerInputActions;
    private InputAction _move;
    private Vector2 _movementVector = new();
    
    private void Awake()
    {
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Enable();
    }   
    private void FixedUpdate()
    {
        _movementVector = _playerInputActions.Player.Move.ReadValue<Vector2>().normalized;
        
        if (_movementVector != Vector2.zero)
        {
            Move();
        }
    }

    private void Move()
    {
        transform.position += new Vector3(_movementVector.x, _movementVector.y, 0) * Time.deltaTime * _speed;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, Mathf.Atan2(_movementVector.y, _movementVector.x) * Mathf.Rad2Deg), 0.1f);
    }
}
