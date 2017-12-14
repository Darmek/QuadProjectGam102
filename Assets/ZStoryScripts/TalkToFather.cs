using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToFather : MonoBehaviour {

    public GameObject rebel;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<ScriptBegin>().cutScene5 = true;
        other.gameObject.GetComponent<ScriptBegin>().scriptCount = 0;
        other.gameObject.GetComponent<ScriptBegin>().ContinueDiologue();
    }

    public void enableRebel()
    {
        rebel.SetActive(true);
    }

    public void disableFather()
    {
        gameObject.SetActive(false);
    }
}
