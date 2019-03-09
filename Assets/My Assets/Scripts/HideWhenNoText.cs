using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideWhenNoText : MonoBehaviour {

    private GameObject nameplate;
    private GameObject charname;
    private string nametext;

	//// Use this for initialization
	void Start () {
        nameplate = gameObject.transform.Find("Nameplate").gameObject;
        charname = nameplate.transform.Find("CharacterName").gameObject;
        nametext = charname.GetComponent<Text>().text;
	}
	
	// Update is called once per frame
	void Update () {
        nameplate = gameObject.transform.Find("Nameplate").gameObject;
        charname = nameplate.transform.Find("CharacterName").gameObject;
        nametext = charname.GetComponent<Text>().text;

        if (nametext == "")
        {
            nameplate.SetActive(false);
        }
        else {
            nameplate.SetActive(true);
        }
	}
}
