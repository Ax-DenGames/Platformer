using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	#region publicparams
	public Rigidbody _rig;
	public Collider rigColl;
	public float LRSpeed;
	public float jumpForce;
	public float rayDistance;
	#endregion

	#region private
	private bool isGround=false;
	#endregion
	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
		/*RaycastHit hit;
		if(Physics.Raycast(_rig.transform.position, -Vector3.up, out hit, rayDistance))
		{
			if(hit.collider.tag=="Ground")
			{
				isGround=true;
			}
			else if(hit.collider.tag==null){
				isGround=false;
			}
		}*/
		Debug.Log (isGround);
		//Debug.DrawRay (_rig.transform.position, -Vector3.up*rayDistance, Color.red);

		if (Input.GetKeyDown (KeyCode.Space)) {
		if(isGround)
			{
				_rig.AddForce (new Vector3(0, jumpForce, 0));
				isGround=false;
				Debug.Log(isGround);
			}
		}
		if (Input.GetKey (KeyCode.A)) {
			LeftMove();
		}
		if(Input.GetKey(KeyCode.D)) {
			RightMove();
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Ground") {
			isGround = true;
		} 
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == null) {
			isGround=false;
		}
	}
	public void LeftMove()
	{
		_rig.transform.position += new Vector3 (0, 0, -Time.deltaTime * LRSpeed);
	}

	public void RightMove()
	{
		_rig.transform.position += new Vector3 (0, 0, Time.deltaTime * LRSpeed);
	}
}
