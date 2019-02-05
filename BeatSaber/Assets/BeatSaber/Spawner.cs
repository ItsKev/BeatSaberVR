﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] private GameObject[] cubes;
    [SerializeField] private Transform[] points;
    [SerializeField] private float beat = (60/140)*2;
    private float timer;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timer > beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, 3)], points[Random.Range(0, 4)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= beat;
        }

        timer += Time.deltaTime;
	}
}
