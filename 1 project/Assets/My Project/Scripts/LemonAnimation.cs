using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A))
        {
            _animator.SetBool("IsWalking", !_animator.GetBool("IsWalking"));
        }

        
    }
}
