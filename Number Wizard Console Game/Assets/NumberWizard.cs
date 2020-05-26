using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max, min, guess = 500, tries = 0;

    // Use this for initialization
    void Start () {
        
    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = max;

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number higher than: " + guess);
        Debug.Log("Push up: Higher, Push down: Lower, Push Enter: Correct ");
        max += 1;
    }



    // Update is called once per frame
    void Update () {



        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("UP Arrow was clicked.");
            min = guess;
            guess = (guess + max) / 2;
            tries++;
            Debug.Log("Is your number :" + guess + "?");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("Down Arrow");
            max = guess;
            guess = (guess + min) / 2;
            tries++;
            Debug.Log("Is your number :" + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Guessed in " + tries + " tries" + "\n Press R to start again.");
        } else if (Input.GetKeyDown(KeyCode.R)) {
            StartGame();
            Debug.Log("Game Restarted.");
        }
    }
}
