using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public enum STATE
    {
        CREATE, MOVE, CRASH, OUT
    }

    public STATE state = STATE.CREATE;

    public GameObject Obj_CrashEffect;

    public float fDeleteArrowTime = 2.0f;
    public float fMoveSpeed = 30.0f;
    public float fTime = 0.0f;

    Vector3 V3_Dir;

    public LayerMask CastLayer;

    private void Update()
    {
        StateProcess();
    }

    void StateProcess()
    {
        switch(state)
        {
            case STATE.CREATE:
                break;
            case STATE.MOVE:
                MoveToTarget();
                break;
            case STATE.CRASH:
                break;
            case STATE.OUT:
                break;
        }
    }

    public void ChangeState(STATE s)
    {
        if (state == s) return;

        state = s;

        switch (state)
        {
            case STATE.CREATE:
                break;
            case STATE.MOVE:
                break;
            case STATE.CRASH:
                CreateEffect();
                Damage();
                ChangeState(STATE.OUT);
                break;
            case STATE.OUT:
                Out();
                break;
        }
    }

    public void MoveToTarget()
    {
        Vector3 pos = transform.localPosition;
        float delta = fMoveSpeed * Time.smoothDeltaTime;
        Vector3 target = pos + V3_Dir * delta;

        Ray ray = new Ray();
        ray.origin = pos;
        ray.direction = target - pos;
        ray.direction.Normalize();
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, delta, CastLayer)) // 충돌이 났을 때
        {
            transform.localPosition = hit.point;
            ChangeState(STATE.CRASH);
        }
        else
        {
            transform.localPosition = target;

            fTime += Time.smoothDeltaTime;
            if (fTime >= fDeleteArrowTime)
            {
                ChangeState(STATE.OUT);
            }
        }
    }

    void CreateEffect()
    {
        GameObject obj = Instantiate(Obj_CrashEffect);
        obj.transform.position = this.transform.position;
        obj.transform.rotation = this.transform.rotation;
    }

    void Out()
    {
        Debug.Log("투사체 삭제");
        Destroy(gameObject);
    }

    void Damage()
    {
        Debug.Log("투사체 명중");
    }

    public void OnFire(Vector3 dir)
    {
        V3_Dir = dir;
        ChangeState(STATE.MOVE);
    }
}