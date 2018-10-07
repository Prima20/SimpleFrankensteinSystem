using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFrankenstein : MonoBehaviour {
    //Apply this script to every component like face, hair, body etc
    //Every component must have a SpriteRenderer component

    //Component to build;
    public Sprite[] component;

    //Variable for gameobject SpriteRenderer component
    private SpriteRenderer spriteComponent;

	// Use this for initialization
	void Start () {
        //Apply component to SpriteRenderer
        spriteComponent = GetComponent<SpriteRenderer>();
        spriteComponent.sprite = component[Random.Range(0, component.Length)];
	}

}
