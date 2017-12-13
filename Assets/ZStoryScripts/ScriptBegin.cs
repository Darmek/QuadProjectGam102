using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBegin : MonoBehaviour {

    public ScriptPiece script;
    public ScriptPiece script2;
    public int scriptCount = 0;
    bool cutScene1 = true;
    public bool cutScene2 = false;


    void Start()
    {
        diologueFeed1();
    }

    public void ContinueDiologue()
    {
        scriptCount++;
        if (cutScene1 && scriptCount < 2)
            diologueFeed1();
        if (cutScene2 && scriptCount < 4)
            diologueFeed2();
    }

    void diologueFeed1()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script.script[scriptCount]);
        if (scriptCount == 2)
            cutScene1 = false;
    }

    public void diologueFeed2()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script2.script[scriptCount]);
        if (scriptCount == 4)
            cutScene1 = false;
    }
}
