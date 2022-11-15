using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour
{
    [SerializeField] private mobileTouchController input;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 myDirection;
    private void Move(Vector3 direction)
    {
        
        _rigidbody.velocity = myDirection * moveSpeed * Time.deltaTime;
    }

    public void FixedUpdate()
    {
        myDirection = new Vector3(input._direction.x, 0, input._direction.y);
        Move(myDirection);
    }
}