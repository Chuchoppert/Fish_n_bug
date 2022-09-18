using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoving : MonoBehaviour
{
    public float SpeedPig;
    public float SpeedRotationPig;
    Rigidbody rb;

    float InputY;
    float InputX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        InputY = Input.GetAxis("Vertical");
        if (InputY != 0)
        {
            Vector3 movedirection = new Vector3(0.0f, 0.0f, -InputY);
            movedirection = transform.TransformDirection(movedirection);
            
            rb.MovePosition(transform.position + movedirection * SpeedPig * Time.deltaTime);
        }

        InputX = Input.GetAxis("Horizontal");
        if(InputX != 0)
        {
            transform.Rotate(new Vector3(0, InputX, 0), SpeedRotationPig * Time.deltaTime);
        }
    }
}
