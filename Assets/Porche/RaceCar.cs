using UnityEngine;
using System.Collections;

public class RaceCar : MonoBehaviour {

	public	float	speed	=	30;
	public	float	turn	=	90;	

	private Transform tr;

	// Use this for initialization
	void Start () {
		tr = transform;
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");

		if (v != 0) {
			tr.Translate(v * Vector3.forward * speed * Time.deltaTime);
		}

		if (h != 0) {
			tr.Rotate(0, h * turn * Time.deltaTime, 0);
		}

	}
}

// test git whitelist B