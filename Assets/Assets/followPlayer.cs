using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	public Transform hero;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (hero.position.x, this.transform.position.y, this.transform.position.z);
	
	}
}
