using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCtrl : MonoBehaviour
{
    public enum STATE
    {
        CREATE,IDLE,WALK,ROLL,ATTACK,DEAD
    }

    public STATE state = STATE.CREATE;

    public Animator Ani;

    public Arrow arrow;

    public float RollDist = 5.0f;
    public float RollSpeed = 0.04f;
    public float StartRollSpeed = 0.1f;
    Vector3 CharPos = Vector3.zero;
    Vector3 TargetPos = Vector3.zero;

    public GameObject ArrowObj;
    public Transform ArrowMuzzlePos;

    LayerMask CharLayer;

    struct MoveData
    {
        public Vector3 TargetPosition;
        public Vector3 CurrentPosition;
        public float MoveDist;
        public Vector3 MoveDir;
        public float RotY;
        public Vector3 CurrentRot;
    }

    public Camera m_MainCamera;
    public LayerMask m_CastLayer;
    public float m_MoveSpeed = 10.0f;
    public float m_MoveSmooth = 10.0f;
    public float m_RotSmooth = 10.0f;
    public float m_RotSpeed = 50f;

    MoveData m_MoveData;

    public bool m_SmoothMove = false;
    public bool m_SmoothRot = false;

    private void Start()
    {
        Ani = GetComponent<Animator>();
    }

    private void Update()   
    {
        StateProcess();
    }

    void ChangeState(STATE s)
    {
        if (state == s) return;
        state = s;

        switch(s)
        {
            case STATE.CREATE:
                break;
            case STATE.IDLE:
                break;
            case STATE.WALK:
                ReadyMove();
                break;
            case STATE.ROLL:
                StartCoroutine(Roll());
                break;
            case STATE.ATTACK:
                BowAttack();
                break;
            case STATE.DEAD:
                Dead();
                break;
        }
    }

    void StateProcess()
    {
        switch (state)
        {
            case STATE.CREATE:
                ChangeState(STATE.IDLE);
                break;
            case STATE.IDLE:
                if (Input.GetMouseButton(0))
                {
                    Picking();
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    Ani.SetTrigger("LookAround");
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    ChangeState(STATE.ROLL);
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    ChangeState(STATE.ATTACK);
                }

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Ani.SetTrigger("Hit");
                }

                if (Input.GetKeyDown(KeyCode.W))
                {
                    ChangeState(STATE.DEAD);
                }
                break;
            case STATE.WALK:
                Moving();
                break;
            case STATE.ROLL:
                break;
            case STATE.ATTACK:
                break;
            case STATE.DEAD:
                break;
        }
        Rotating();
    }

    IEnumerator Roll()
    {
        Ani.SetTrigger("Roll");

        CharPos = this.transform.localPosition;
        TargetPos.z = CharPos.z + RollDist;
        float TempStartRollSpeed = StartRollSpeed;

        while (TargetPos.z - CharPos.z > 0.1f)
        {
            CharPos.z += Time.smoothDeltaTime + RollSpeed + StartRollSpeed;
            this.transform.localPosition = CharPos;
            StartRollSpeed /= 1.01f;
            yield return null;
        }
        StartRollSpeed = TempStartRollSpeed;

        ChangeState(STATE.IDLE);
    }

    void BowAttack()
    {
        Ani.SetTrigger("BowAttack");
    }

    void BowFire()
    {
        GameObject obj = Instantiate(ArrowObj) as GameObject;
        arrow = obj.GetComponent<Arrow>();
        //obj.transform.SetParent(ArrowMuzzlePos.transform);
        obj.transform.position = ArrowMuzzlePos.position;
        arrow.OnFire();
    }

    void Dead()
    {
        Ani.SetTrigger("Death");
    }

    void Picking()
    {
        Ray ray = m_MainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 30.0f, m_CastLayer))
        {
            Vector3 pos = transform.position;
            pos.x = hit.point.x;
            pos.z = hit.point.z;
            m_MoveData.TargetPosition = pos;

            if ((m_CastLayer & (1 << LayerMask.NameToLayer("Ground"))) != 0)
            {
                ChangeState(STATE.WALK);
            }
        }
    }

    void ReadyMove()
    {
        m_MoveData.MoveDir = m_MoveData.TargetPosition - transform.position;
        m_MoveData.MoveDir.Normalize();
        m_MoveData.MoveDist = Vector3.Distance(transform.position, m_MoveData.TargetPosition);
        m_MoveData.CurrentPosition = transform.position;

        m_MoveData.RotY = Mathf.Acos(Vector3.Dot(transform.forward, m_MoveData.MoveDir)) * (180.0f / Mathf.PI);

        if (Vector3.Dot(transform.right, m_MoveData.MoveDir) < 0f)
        {
            m_MoveData.RotY = -m_MoveData.RotY;
        }

        m_MoveData.CurrentRot = transform.localRotation.eulerAngles;
    }


    void Moving()
    {
        Ani.SetBool("Walk", true);

        if (Input.GetMouseButton(0))
        {
            ChangeState(STATE.IDLE);
            Picking();
        }

        float delta = m_MoveSpeed * Time.smoothDeltaTime;
        if (m_MoveData.MoveDist - delta < 0.0f)
        {
            delta = m_MoveData.MoveDist;
        }
        m_MoveData.MoveDist -= delta;

        m_MoveData.CurrentPosition += m_MoveData.MoveDir * delta;
        if (m_SmoothMove)
        {
            transform.position = Vector3.Lerp(transform.position, m_MoveData.CurrentPosition, Time.smoothDeltaTime * m_MoveSmooth);
        }
        else
        {
            transform.position = m_MoveData.CurrentPosition;
        }

        if (Vector3.Distance(transform.position, m_MoveData.CurrentPosition) < 0.01f)
        {
            if (m_MoveData.MoveDist < 0.01f)
            {
                Ani.SetBool("Walk", false);
                ChangeState(STATE.IDLE);
            }
        }
    }

    void Rotating()
    {
        float delta = m_RotSpeed * Time.smoothDeltaTime;

        if (m_MoveData.RotY > 0f)
        {
            if (m_MoveData.RotY - delta < 0.0f)
            {
                delta = m_MoveData.RotY;
            }
            m_MoveData.RotY -= delta;
        }
        else if (m_MoveData.RotY < 0f)
        {
            if (m_MoveData.RotY + delta > 0.0f)
            {
                delta = -m_MoveData.RotY;
            }
            m_MoveData.RotY += delta;
            delta = -delta;
        }
        else
        {
            delta = 0f;
        }

        if (m_SmoothRot)
        {
            m_MoveData.CurrentRot.y += delta;
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(m_MoveData.CurrentRot), Time.smoothDeltaTime * m_RotSmooth);
        }
        else
        {
            this.transform.Rotate(Vector3.up, delta);
        }
    }
}

//this.transform.LookAt(V1,V2) == this.transform.LookAt(바라볼목표, 자신의 업벡터)
//Invoke("Restore", 0.1f); == 0.1초 뒤에 Restore라는 함수 호출 
//GameObject.SendMessage == 해당 게임 오브젝트에 있는 특정 함수를 호출하기 위해 사용
//DX11 랜더링은 버텍스 쉐이더와 픽셀 쉐이더가 한 쌍을 이루어야 작동함