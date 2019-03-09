using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDecreaseCountAfterTime : MonoBehaviour
{
    public int AmountToRemove = 1;
    public float TimeToWait = 0.1f;
    StudentManager studentManager = null;

    void OnCollisionEnter2D(Collision2D coll)
    {
        studentManager = coll.collider.GetComponent<StudentManager>();
        if (studentManager == null)
        {
            Debug.LogError("No Student Manager provided");
        }
        else
        {
            StartCoroutine(decreaseCountAterTime(TimeToWait));
        }
    }

    IEnumerator decreaseCountAterTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        studentManager.DecreaseCount(AmountToRemove);
    }

    void Update()
    {

    }
}
