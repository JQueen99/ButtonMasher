using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; // sound that plays when button clicks


	// Use this for initialization
	void Start () {

        Debug.Log("Start function called");
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start function called");
    }

    private void OnMouseDown() // Function for when mouse is clicked
    {
        Debug.Log("Mouse down function");
        // Activates clicksound when buton is clicked

        clickSound.Play();

    } // End of OnMouseDown
} // End of ButtonMasher class


