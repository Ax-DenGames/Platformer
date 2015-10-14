using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Controller : MonoBehaviour ,IPointerDownHandler, IPointerUpHandler
{

	#region publicparams
	bool _btn;
    public Button[] Buttons = new Button[2];
	public Rigidbody _rig;
	public Collider rigColl;
	public float LRSpeed;
	public float jumpForce;
	public float rayDistance;
    #endregion

    #region private
    private bool isGround = false;
    private LRMove _MoveDir;
	#endregion
	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log (isGround);
		//Debug.DrawRay (_rig.transform.position, -Vector3.up*rayDistance, Color.red);
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

    //Move funcrions
    public void LeftMove()
	{
		_rig.transform.position += new Vector3 (0, 0, -Time.deltaTime * LRSpeed*10);
	}
    	public void RightMove()
	{
		_rig.transform.position += new Vector3 (0, 0, Time.deltaTime * LRSpeed);
	}
    public void Jump() {
        if (isGround)
        {
            _rig.AddForce(new Vector3(0, jumpForce, 0));
            isGround = false;
            Debug.Log(isGround);
        }
    }
    //End Move Functions


    public void OnPointerUp(PointerEventData eventData)
    {
        _btn = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _btn = true;
    }
}


public enum LRMove{
  Left, Right
}