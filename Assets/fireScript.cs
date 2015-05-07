using UnityEngine;
using System.Collections;

public class fireScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate (.5f, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "wall") 
		{
			Debug.Log("gone!");
			Destroy(this.gameObject);
		}
	}
}
