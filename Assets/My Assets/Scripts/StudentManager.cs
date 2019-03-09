using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentManager : MonoBehaviour
{
    public int InitialCount = 0;
    int currCount;

    void Awake()
    {
        ChangeCount(InitialCount);
    }

    void ChangeCount(int amount)
    {
        currCount = amount;
        if (onStudentManagerChange != null) onStudentManagerChange(currCount);

        //Debug.Log(name + " has a current score of " + currCount);
    }

    public void SetScore(int amount)
    {
        ChangeCount(amount);
    }

    public void IncreaseCount(int amount)
    {
        ChangeCount(currCount + amount);
    }

    public void DecreaseCount(int amount)
    {
        ChangeCount(currCount - amount);
    }

    public int GetCurrCount()
    {
        return currCount;
    }

    public delegate void StudentManagerChangeHandler(int amount);
    public event StudentManagerChangeHandler onStudentManagerChange;
}
