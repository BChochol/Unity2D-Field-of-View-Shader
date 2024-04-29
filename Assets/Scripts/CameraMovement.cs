using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, transform.position.z);
    }
}
