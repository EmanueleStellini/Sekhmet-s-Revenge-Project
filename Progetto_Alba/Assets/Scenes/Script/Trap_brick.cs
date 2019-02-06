using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_brick : MonoBehaviour {

    private GameObject[] bricks;
    private GameObject brickSonor;
    private Rigidbody fisic;
    private GameObject character;
    private Collider characterCollider;
    private AudioSource audioTrap;
    public AudioClip clip;
    private bool alreadyplayed = false;


    public string boh = "669";

	// Use this for initialization
	void Start () {

        character = GameObject.Find("FPSController");
        characterCollider = character.GetComponent<Collider>();

        bricks = GameObject.FindGameObjectsWithTag("Brick");
        brickSonor = GameObject.Find("BrickSonor");
        audioTrap = brickSonor.GetComponent<AudioSource>();

        

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
            if(alreadyplayed == false)
            {
                audioTrap.PlayOneShot(clip, 1);
                alreadyplayed = true;
            }         
            
        }
        
    }
}
