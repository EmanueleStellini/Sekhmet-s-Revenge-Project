using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTrap : MonoBehaviour {

    public float velocity = 10;
    private float velocity_Private;
    private float translation;
    private Vector3 startPosition;
    private Quaternion startRotation;
    public float Idle_Time = 10;
    private float timeStart;


	// Use this for initialization
	void Start () {

        startPosition = transform.position;
        startRotation = transform.rotation;
        timeStart = Time.time;
        velocity_Private = velocity;


    }
	
	// Update is called once per frame
	void Update () {

        translation = velocity_Private * Time.deltaTime;
        transform.Translate(0, translation, 0);

        if ((Time.time - timeStart) > Idle_Time)
        {
            transform.position = startPosition;
            transform.rotation = startRotation;
            velocity_Private = velocity;
            timeStart = Time.time;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        velocity_Private = 0;
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}
