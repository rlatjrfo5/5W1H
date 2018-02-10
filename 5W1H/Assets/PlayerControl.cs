using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public Animator animator;
    private float directionX = 0;
    private float directionY = 0;
    private bool walking = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(animator)
        {
            float h = Input.GetAxisRaw("Horizontal");
            float v = Input.GetAxisRaw("Vertical");
            walking = true;

            if(h > 0)
            {
                directionX = 1;
                directionY = 0;
            }
            else if(h < 0)
            {
                directionX = -1;
                directionY = 0;
            }
            else if (v > 0)
            {
                directionX = 0;
                directionY = 1;
            }
            else if (v < 0)
            {
                directionX = 0;
                directionY = -1;
            }
            else
            {
                walking = false;
            }

            if(walking)
            {
                transform.Translate(new Vector3(directionX, directionY, 0) * Time.deltaTime * 4.0f);
            }

            animator.SetFloat("DirectionX", directionX);
            animator.SetFloat("DirectionY", directionY);
            animator.SetBool("Walking", walking);
        }
	}
}
