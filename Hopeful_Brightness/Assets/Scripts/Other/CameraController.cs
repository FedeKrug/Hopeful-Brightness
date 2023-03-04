using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _offsetX, _offsetY;

    void Awake()
    {
        
    }

   
    void LateUpdate()
    {
        this.transform.position = new Vector3(_target.position.x + _offsetX, _target.position.y + _offsetY, transform.position.z);
    }
}
