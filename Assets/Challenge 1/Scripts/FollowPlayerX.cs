using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject Target;
    public float damping = 1;
    private Vector3 offset;

    void Start()
    {
        offset = Target.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //var currentAngleX = transform.eulerAngles.x;
        //var desiredAngleX = Target.transform.eulerAngles.x;
        //var angleX = Mathf.Lerp(desiredAngleX, currentAngleX, Time.deltaTime * damping);
        ////var rotationX = Quaternion.Euler(angleX, 0, 0);

        //var currentAngleY = transform.eulerAngles.y;
        //var desiredAngleY = Target.transform.eulerAngles.y;
        //var angleY = Mathf.LerpAngle(currentAngleY, desiredAngleY, Time.deltaTime * damping);

        //var rotation = Quaternion.Euler(angleX, 0, 0);
        ////print(rotationY);

        //transform.position = Target.transform.position - (rotation * offset);

        //transform.LookAt(Target.transform);
        
        var currentRotation = transform.rotation;
        currentRotation.z = 0;
        var desiredRotation = Target.transform.rotation;

        var newRotation = Quaternion.Lerp(currentRotation, desiredRotation, Time.deltaTime * damping);
        newRotation.z = 0;
        transform.rotation = newRotation;
        transform.position = Target.transform.position - (newRotation * offset);
        //transform.LookAt(Target.transform);

    }
}
