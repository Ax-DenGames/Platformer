using UnityEngine;
using System.Collections;

public class CameraMotion : MonoBehaviour {
	public Transform target;
	public Camera cam;
	public float _camDist;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cam.transform.position = new Vector3(target.transform.position.x+_camDist,target.transform.position.y + 1f, 
		                                                                            target.transform.position.z );
	}
}
