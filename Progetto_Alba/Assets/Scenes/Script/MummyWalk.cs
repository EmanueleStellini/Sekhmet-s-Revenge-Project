using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyWalk : MonoBehaviour {

    private Animator MyAnimation;
    private BoxCollider MyTrigCollider;
    private GameObject MyCharacter;
    private Collider CharacterCollider;

	// Use this for initialization
	void Start () {
        MyAnimation = GetComponent<Animator>();
        MyTrigCollider = GetComponent<BoxCollider>();

        MyCharacter = GameObject.Find("FPSController");
        CharacterCollider = MyCharacter.GetComponent<Collider>();
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if(other == CharacterCollider)
        {
            MyAnimation.Play("Zombie Run");
        }
    }





}
