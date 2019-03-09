using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDialogueOnReachTarget : MonoBehaviour
{
    public DialoguerDialogues DialogueName;
    DialogueManager dialogueMgr;

    public StudentManager studentManager;
    public int TargetCount = 0;

    void Start()
    {
        dialogueMgr = GameManager.Inst().GetComponent<DialogueManager>();
        if (!dialogueMgr) Debug.LogError("Need Dialogue Manager Component on GameManager!!");

        if (studentManager == null)
        {
            Debug.LogError("No Student Manager provided");
        }
        else if (studentManager != null)
        {
            studentManager.onStudentManagerChange += onCountChange;
        }
    }

    void OnDestroy()
    {
        if (studentManager != null)
        {
            studentManager.onStudentManagerChange -= onCountChange;
        }
    }

    void onCountChange(int amount)
    {
        if (studentManager.GetCurrCount() == TargetCount)
        {
            dialogueMgr.PlayDialogue(DialogueName);
        }
    }
}
