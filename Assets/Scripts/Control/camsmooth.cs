using UnityEngine;
using System.Collections;

public class camsmooth : MonoBehaviour {
 
	public Transform target;
	public Transform cam;
	public float Smoothtm;
	public float Distance;
	public float Undplayer;
	public float ZDist;
	private Vector3 velocity;
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 tergetpos = new Vector3 (target.transform.position.x+Distance, target.transform.position.y+Undplayer, target.transform.position.z+ZDist);
		cam.transform.position = Vector3.SmoothDamp (cam.transform.position, tergetpos, ref velocity, Smoothtm);

	}
}
