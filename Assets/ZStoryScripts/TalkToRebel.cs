﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToRebel : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<ScriptBegin>().cutScene4 = true;
        other.gameObject.GetComponent<ScriptBegin>().scriptCount = 0;
        other.gameObject.GetComponent<ScriptBegin>().ContinueDiologue();
    }
}