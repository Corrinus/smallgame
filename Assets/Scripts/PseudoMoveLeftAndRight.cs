using UnityEngine;
using System.Collections;

public class PseudoMoveLeftAndRight : MonoBehaviour {

    public float modifier = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Renderer>().material.mainTextureOffset += Vector2.right * Input.GetAxis("Horizontal") * GameManager.instance.gameSpeed * Time.deltaTime * modifier;
    }
}
