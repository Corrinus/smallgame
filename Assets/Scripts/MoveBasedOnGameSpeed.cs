using UnityEngine;
using System.Collections;

public class MoveBasedOnGameSpeed : MonoBehaviour {

    public Vector3 direction = Vector3.forward;

	// Use this for initialization
	void Start () {
        //transform.position += Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
        //Moves object left or right based on input
        transform.position += transform.rotation*(direction.normalized * GameManager.instance.gameSpeed * Time.deltaTime);
    }
}
