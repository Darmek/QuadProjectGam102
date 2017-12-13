using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToReginald : MonoBehaviour
{
    bool firstCollide = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponentInChildren<DialogueManager>().ShowBox("Reginald: You're dismissed, for now.");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (firstCollide)
        {
            other.gameObject.GetComponent<ScriptBegin>().cutScene2 = true;
            firstCollide = false;
        }
        other.gameObject.GetComponent<ScriptBegin>().scriptCount = 0;
        other.gameObject.GetComponent<ScriptBegin>().diologueFeed2();
    }
}