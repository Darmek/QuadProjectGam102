using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    bool dActive;
	
	// Update is called once per frame
	void Update () {
		if (dActive && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponentInParent<Rigidbody2D>().constraints = ~RigidbodyConstraints2D.FreezePosition;
            GetComponentInParent<PlayerController>().enabled = true;
            dBox.SetActive(false);
            dActive = false;
            GetComponentInParent<ScriptBegin>().ContinueDiologue();
        }
	}

    public void ShowBox(string dialogue)
    {
        
        dActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        GetComponentInParent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponentInParent<PlayerController>().enabled = false;
    }
}
