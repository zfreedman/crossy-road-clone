using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public  GameObject      chick = null;
    public  float           colliderDistCheck = 1;
    public  bool            isDead = false;
    public  bool            isIdle = true;
    public  bool            isJumping = false;
    public  bool            isMoving = false;
    public  bool            jumpStart = false;
    public  ParticleSystem  particle = null;
    public  float           moveTime = 0.4f;
    public  float           moveDistance = 1;

    private bool            isVisible = false;
    private Renderer        localRenderer = null; 

	// Use this for initialization
	void Start () {
         
	}
	
	// Update is called once per frame
	void Update () {
        CanMove();
	}

    void CanIdle ()
    {

    }

    void CanMove ()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKeyDown(KeyCode.UpArrow)) move += transform.forward;
        else if (Input.GetKeyDown(KeyCode.DownArrow)) move -= transform.forward;
        else if (Input.GetKeyDown(KeyCode.RightArrow)) move += transform.right;
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) move -= transform.right;
        if (move != Vector3.zero) Move(move);
    }

    void CheckIfCanMove ()
    {

    }

    public void GotHit ()
    {

    }

    void IsVisible ()
    {

    }

    void Move (Vector3 move)
    {
        LeanTween.move(this.gameObject, transform.position + move, moveTime);
    }

    void MoveComplete ()
    {

    }

    void SetMove ()
    {

    }

    void SetMoveForwardState ()
    {

    }
}
