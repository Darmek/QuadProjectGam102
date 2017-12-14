﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkToReginald : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<PlayerController>().leaveCastle = true;
        other.gameObject.GetComponent<ScriptBegin>().cutScene2 = true;
        other.gameObject.GetComponent<ScriptBegin>().scriptCount = 0;
        other.gameObject.GetComponent<ScriptBegin>().ContinueDiologue();
    }
}