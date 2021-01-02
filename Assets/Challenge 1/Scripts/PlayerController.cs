using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private bool rotationInputLeft;
    private bool rotationInputRight;
    public float speed = 1;
    private float turnSpeed = 45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rotationInputLeft = Input.GetKey(KeyCode.E);
        rotationInputRight = Input.GetKey(KeyCode.Q);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Rotate(Vector3.right, turnSpeed * verticalInput * Time.deltaTime);

        if (rotationInputLeft)
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
        if (rotationInputRight)
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
