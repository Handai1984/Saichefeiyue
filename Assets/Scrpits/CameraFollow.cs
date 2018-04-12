using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //public Transform target;

   

    //private void LateUpdate()
    //{
    //    Quaternion a = Quaternion.Euler(0, 0, 90);
    //    print(target.rotation.z);
    //    print(a);
    //    this.transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    //    transform.LookAt(target);
    //}
    public Transform target;
    public float distance;
    public float targetHeight;
    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        var angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
    }

    void LateUpdate()
    {
        if (!target)
            return;

        y = target.eulerAngles.y;

        // ROTATE CAMERA:  
        Quaternion rotation = Quaternion.Euler(x, y, 0);
        transform.rotation = rotation;

        // POSITION CAMERA:  
        Vector3 position = target.position - (rotation * Vector3.forward * distance + new Vector3(0, -targetHeight, 0));
        position.z = transform.position.z;
        transform.position = position;
    }
}
