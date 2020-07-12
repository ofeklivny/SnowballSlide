using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementGFX : MonoBehaviour
{

    [SerializeField] private float ballSpeed = 1f;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            _rb.AddTorque(new Vector3(xSpeed, 0, ySpeed) * (ballSpeed * Time.deltaTime));
        }
    }
}

