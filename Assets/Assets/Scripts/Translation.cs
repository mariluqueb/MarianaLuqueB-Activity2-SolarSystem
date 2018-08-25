using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation : MonoBehaviour {

    public Transform translationPivot;
    public float translationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.RotateAround(translationPivot.position, Vector3.up, translationSpeed * Time.deltaTime);	
	}
}
