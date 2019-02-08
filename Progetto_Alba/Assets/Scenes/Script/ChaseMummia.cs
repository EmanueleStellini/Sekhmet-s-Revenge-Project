﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMummia : MonoBehaviour {

    public Transform player;
    static Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);

        if (Vector3.Distance(player.position, this.transform.position)<10 && angle <= 180)
        {
            direction.y = 0.0f;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            anim.SetBool("isIdle", false); 
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.03f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                if(direction.magnitude < 2)
                {
                    anim.SetBool("isNeckbite", true);
                    anim.SetBool("isAttacking", false);
                    anim.SetBool("isWalking", false);
                }
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking",false);
                anim.SetBool("isNeckbite", false);
            }

        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isNeckbite", false);
        }

	}
}
