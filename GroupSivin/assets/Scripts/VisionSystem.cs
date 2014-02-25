﻿using UnityEngine;
using System.Collections;

public class VisionSystem : MonoBehaviour {

    public bool atRecyclingPlant = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        CheckIfAtRecyclingPlant();
        
	}

    void CheckIfAtRecyclingPlant()
    {
        Debug.DrawLine(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y));
        atRecyclingPlant = Physics2D.Linecast(new Vector2(this.transform.position.x, this.transform.position.y), new Vector2(this.transform.position.x - 0.3f, this.transform.position.y), 1 << LayerMask.NameToLayer("RecyclingPlant"));

        if (Input.GetKey(KeyCode.Space) && atRecyclingPlant)
        {
			PlayerMovement.ResetSpeed();
            PlayerScore.ChangeSafeScore();
        }

    }
}
