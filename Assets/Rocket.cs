using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {


    Rigidbody rigidBody;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ProcessInput();

    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) // can thrust while rotating, which is why this if statement is separated
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }

            rigidBody.AddRelativeForce(Vector3.up);
        }
        else
        {
            audioSource.Stop();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward); // vector3.forward = z axis
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward); // clockwise
        }
    }
}
