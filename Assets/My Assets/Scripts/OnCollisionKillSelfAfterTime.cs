using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionKillSelfAfterTime : MonoBehaviour
{
    public float TimeToWait = 0.1f;

    void OnCollisionEnter2D(Collision2D coll)
    {
        StartCoroutine(killAfterTime(TimeToWait));
    }

    IEnumerator killAfterTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }

    void Update()
    {

    }
}
