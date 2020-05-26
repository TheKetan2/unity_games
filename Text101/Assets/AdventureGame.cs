using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
   // [SerializeField] Text newTextComponent;

	// Use this for initialization
	void Start () {
       // newTextComponent.text = ("This is title");
        textComponent.text = ("This is story text component");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
