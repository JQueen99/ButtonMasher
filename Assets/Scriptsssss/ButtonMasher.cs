using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    public AudioSource clickSound; // sound that plays when button clicks
    public TextMesh scoreText; // display player score
    public TextMesh timerText; // display time left

    private int score = 0; // Numerical value of player score
    

    public float gameLength; // How long game lasts
    public float timeRemaining = 0;

	// Use this for initialization
	void Start () {

        Debug.Log("Start function called");


        timeRemaining = gameLength;

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start function called");

        timeRemaining = timeRemaining - Time.deltaTime;



        timerText.text =  (Mathf.CeilToInt (timeRemaining)).ToString();

    }

    private void OnMouseDown() // Function for when mouse is clicked
    {
        Debug.Log("Mouse down function");
        // Activates clicksound when buton is clicked

        clickSound.Play();

        // increase score by 1
        score = score +1;

        // update text

        scoreText.text = score.ToString();



    } // End of OnMouseDown
} // End of ButtonMasher class


