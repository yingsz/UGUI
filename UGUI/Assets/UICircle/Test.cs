using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(() =>
        {
            Debug.Log("click");
        });
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
