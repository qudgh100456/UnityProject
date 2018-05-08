using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public int m_fMoveSpeed=10;
    public int m_fRotSpeed=10;
    Player m_cPlayer;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
     
            InputProcess();
    }
    void InputProcess()
    {
        float MoveSpeed = Input.GetAxis("Vertical") * m_fMoveSpeed;
         float RotSpeed = Input.GetAxis("Horizontal") * m_fRotSpeed;

       
            
            transform.Translate(0, 0, MoveSpeed);
        
        // Rotate around our y-axis
        transform.Rotate(0, RotSpeed, 0);
    }
}
