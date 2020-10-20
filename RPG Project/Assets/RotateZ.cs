using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZ : MonoBehaviour
{
    public float speed = 0.1f;
    public Vector3 axisOfRotation = new Vector3(0f, 0f, 1f);
    public float angle = 0f;

    // Update is called once per frame
    void Update()
    {
        angle += (speed * Time.deltaTime);
        transform.localRotation = Quaternion.AngleAxis( angle, axisOfRotation);
    }
}
