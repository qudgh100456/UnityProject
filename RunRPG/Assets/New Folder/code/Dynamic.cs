using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamic : MonoBehaviour {
    public float m_fMoveSpeed;
    public int m_fRotSpeed;
    public int maxfMoveSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InputProcess();
        if (m_fMoveSpeed < maxfMoveSpeed && m_fMoveSpeed > 10 ) //입력없는 상태일때 스피드 감소
        {
            m_fMoveSpeed -= 0.4f; 
        }
     }

    void InputProcess()
    {
        float fMoveDist = m_fMoveSpeed * Time.deltaTime;
        float fRotAngle = m_fRotSpeed * Time.deltaTime;

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * fMoveDist);
                if (m_fMoveSpeed <= maxfMoveSpeed) //w키 누른상태  점차적 스피드 증가
                    m_fMoveSpeed += 0.8f;
           
        }
    
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * m_fRotSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -m_fRotSpeed);
        }
        
       
    }
}
