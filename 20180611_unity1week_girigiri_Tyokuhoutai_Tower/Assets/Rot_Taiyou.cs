using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot_Taiyou : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float deg = 0;
	void Update () {
        transform.rotation = Quaternion.Euler(Vector3.right * deg);
        deg += 0.01f;
	}
}
