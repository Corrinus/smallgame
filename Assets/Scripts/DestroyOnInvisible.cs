using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour {

	//Destroy the object once it's not on screen
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
