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

    public GameObject ArrowObj;
    public GameObject CrashEffect;

    public float DeleteEffectTime = 2.5f;
    public float Range = 15.0f;
    public float MoveSpeed = 0.1f;

    Vector3 StartPos;
    Vector3 ArrowPos;
    Vector3 TargetPos;

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
                StartCoroutine(Effect());
                Damage();
                break;
            case STATE.OUT:
                Out();
                break;
        }
    }

    public void MoveToTarget()
    {
        this.transform.parent = null;

        Ray ray = new Ray();
        ray.origin = ArrowPos;
        ray.direction = TargetPos - ArrowPos;
        ray.direction.Normalize();
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, StartPos.z, CastLayer))
        {
            transform.localPosition = hit.point;
            ChangeState(STATE.CRASH);
        }
        else
        {
            ArrowPos.z += MoveSpeed + Time.smoothDeltaTime;
            this.transform.position = ArrowPos;

            if (ArrowPos.z >= TargetPos.z)
            {
                ChangeState(STATE.OUT);
            }
        }
    }

    void Out()
    {
        Destroy(gameObject);
    }

    IEnumerator Effect()
    {
        GameObject obj = Instantiate(CrashEffect);
        obj.transform.position = this.transform.position;
        yield return null;
        /*
        float fTime = 0.0f;
        while (true)
        {
            fTime += Time.smoothDeltaTime;

            if (DeleteEffectTime <= fTime)
            {
                Debug.Log("삭제");
                Destroy(obj);
                yield return null;
            }
        }
        */
    }

    void Damage()
    {
        Destroy(gameObject);
    }

    public void OnFire()
    {
        ArrowPos = this.transform.position;
        StartPos = ArrowPos;
        TargetPos = ArrowPos;
        TargetPos.z += Range;
        ChangeState(STATE.MOVE);
    }
}