using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
        //transform.position += Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
        //Moves object left or right based on input
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    }
}
