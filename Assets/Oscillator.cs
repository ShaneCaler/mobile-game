using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour {

    [SerializeField] Vector3 movementVector;
    [SerializeField] float oscillationSpeed = 2f;

    Vector3 startingPos;

    // Use this for initialization
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movementFactor = (Mathf.Sin(Time.time * oscillationSpeed)) / 2f + 0.5f;

        Vector3 offset = movementVector * movementFactor;

        transform.position = startingPos + offset;
    }
}
