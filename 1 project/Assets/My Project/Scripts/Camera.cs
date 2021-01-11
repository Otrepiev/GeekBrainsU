using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 offset;  

    void Start () 
    {        
        offset = transform.position - _target.transform.position;
    }

    void LateUpdate () 
    {        
        transform.position = _target.transform.position + offset;
    }
}