using UnityEngine;
using System.Collections;

public class MoveContr : MonoBehaviour {


    public Rigidbody _rig;
    public float LRSpeed;
    public float jumpForce;
    private bool isGround = false;
    private float hInput;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Move(hInput);

	}

    void Move(float horInput)
    {
        Vector2 myVel = _rig.velocity;
        myVel.x = horInput * LRSpeed;
        _rig.velocity = myVel;
    }

    public void StartMove(float horInput)
    {
        hInput = horInput;
    }

    public void Jump()
    {
        if (isGround)
        {
            _rig.AddForce(new Vector3(0, jumpForce, 0));
            isGround = false;
            Debug.Log(isGround);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }


    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == null)
        {
            isGround = false;
        }
    }
}
