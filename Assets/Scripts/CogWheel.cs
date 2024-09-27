using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogWheel : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 20f;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);
        Vector3 point = new Vector3(0, 0, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        transform.RotateAround(transform.localPosition, axis, Time.deltaTime * rotationSpeed);

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
