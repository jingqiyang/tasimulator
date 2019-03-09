using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSelfOnReachTarget : MonoBehaviour
{
    public StudentManager studentManager;
    public int TargetCount = 0;

    void Start()
    {
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
            Destroy(gameObject);
        }
    }
}
