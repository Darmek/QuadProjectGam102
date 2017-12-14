using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBegin : MonoBehaviour {

    public GameObject reginald;
    public GameObject rebel;
    public ScriptPiece script;
    public ScriptPiece script2;
    public ScriptPiece script3;
    public ScriptPiece script4;
    public ScriptPiece script5;
    public int scriptCount = 0;
    bool cutScene1;
    public bool cutScene2;
    public bool cutScene3;
    public bool cutScene4;
    public bool cutScene5;
    bool cutScene2Once;
    bool cutScene3Once;
    bool cutScene4Once;
    bool cutScene5Once;


    void Start()
    {
        rebel.SetActive(true);
        reginald.SetActive(true);
        cutScene1 = true;
        cutScene2 = false;
        cutScene3 = false;
        cutScene4 = false;
        cutScene5 = false;
        cutScene2Once = false;
        cutScene3Once = false;
        cutScene4Once = false;
        cutScene5Once = false;
        diologueFeed1();
    }

    public void ContinueDiologue()
    {
        
        if (cutScene1 && scriptCount < 2)
            diologueFeed1();
        if (cutScene2 && scriptCount < 5 && !cutScene2Once)
            diologueFeed2();
        if (cutScene3 && scriptCount < 1 && !cutScene3Once)
            diologueFeed3();
        if (cutScene4 && scriptCount < 14 && !cutScene4Once)
            diologueFeed4();
        if (cutScene5 && scriptCount < 13 && !cutScene5Once)
            diologueFeed5();
        scriptCount++;
    }

    void diologueFeed1()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script.script[scriptCount]);
        if (scriptCount == 1)
            cutScene1 = false;
    }

    public void diologueFeed2()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script2.script[scriptCount]);
        if (scriptCount == 4)
            cutScene2Once = true; 
    }

    public void diologueFeed3()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script3.script[scriptCount]);
        if (scriptCount == 0)
            cutScene3Once = true;
    }

    public void diologueFeed4()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script4.script[scriptCount]);
        if (scriptCount == 13)
        {
            rebel.SetActive(false);
            reginald.SetActive(false);
            cutScene4Once = true; 
        }  
    }

    public void diologueFeed5()
    {
        GetComponentInChildren<DialogueManager>().ShowBox(script5.script[scriptCount]);
        if (scriptCount == 5)
            FindObjectOfType<TalkToFather>().enableRebel();
        if (scriptCount == 11)
            FindObjectOfType<TalkToFather>().disableFather();
        if (scriptCount == 12)
            cutScene5Once = true;
    }
}
