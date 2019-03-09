using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlayDialogue : MonoBehaviour {

    public DialoguerDialogues DialogueName;
    DialogueManager dialogueMgr;

    void OnCollisionEnter2D(Collision2D coll)
    {
        dialogueMgr.PlayDialogue(DialogueName);
    }

    void Start()
    {
        dialogueMgr = GameManager.Inst().GetComponent<DialogueManager>();
        if (!dialogueMgr) Debug.LogError("Need Dialogue Manager Component on GameManager!!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
