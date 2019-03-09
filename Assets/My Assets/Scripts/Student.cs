using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour
{

    //bool activated = false;
    //public delegate void ActivationHandler(bool activated);
    //public event ActivationHandler onActivate;

    //public void Activate()
    //{
    //    if (gameMgr.isPaused) return;
    //    activated = !activated;
    //    if (onActivate != null) onActivate(activated);
    //}
    public int StressLevel;
    public string Name;
    public DialoguerDialogues DialogueName;
    DialogueManager dialogueMgr;

    // Use this for initialization
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
