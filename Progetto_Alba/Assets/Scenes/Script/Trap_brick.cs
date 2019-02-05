using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_brick : MonoBehaviour {

    private GameObject[] bricks;
    private Rigidbody fisic;
    private GameObject character;
    private Collider characterCollider;

    public string boh = "669";

	// Use this for initialization
	void Start () {

        character = GameObject.Find("FPSController");
        characterCollider = character.GetComponent<Collider>();

        bricks = GameObject.FindGameObjectsWithTag("Brick");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other == characterCollider)
        {
            for (int i=0; i<bricks.Length; i++)
            {
                fisic = bricks[i].GetComponent<Rigidbody>();
                fisic.useGravity = true;
            }
        }
        
    }
}
