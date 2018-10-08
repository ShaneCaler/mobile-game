using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, speed * Time.deltaTime);
    }
}
