using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball2MovementGFX1 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddTorque(new Vector3(xSpeed, 0, ySpeed) * (ballSpeed * Time.deltaTime));
        }
    }
}

