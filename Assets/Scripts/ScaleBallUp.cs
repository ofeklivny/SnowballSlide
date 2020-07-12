using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBallUp : MonoBehaviour
{

    public Rigidbody rb;
    public float sizeMultiplier = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector3.zero)
        {
            transform.localScale *= (sizeMultiplier * rb.velocity.magnitude);
        }
    }
}
