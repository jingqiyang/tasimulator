using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStudent : MonoBehaviour {

    public GameObject[] objects;
    public StudentManager studentManager;

    public void SpawnRandom()
    {
        GameObject obj = Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)]) as GameObject;

        //if generated placeholder, then destroy object and update count
        if (obj.name == "empty(Clone)")
        {
            if (studentManager == null)
            {
                Debug.LogError("No Student Manager provided");
            }
            else
            {
                studentManager.DecreaseCount(1);
                Destroy(obj);
            }
            return;
        }

        //reset position at zero relative to parent
        obj.transform.parent = transform;
        obj.transform.position += transform.position;
    }

	// Use this for initialization
	void Start ()
    {
        SpawnRandom();
	}
}
