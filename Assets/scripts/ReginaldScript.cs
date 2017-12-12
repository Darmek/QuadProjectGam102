using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReginaldScript : MonoBehaviour {

    private string dialogue = "Hello there!";
    private DialogueManager dMan;

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                print("Hi, I'm Reginald!");
                dMan.ShowBox(dialogue);
            }

        }
    } 
}
