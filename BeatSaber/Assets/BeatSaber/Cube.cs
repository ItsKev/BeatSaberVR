using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    [SerializeField] private CubeSpeed cubeSpeed;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Time.deltaTime * transform.forward * cubeSpeed.Speed;
	}
}
