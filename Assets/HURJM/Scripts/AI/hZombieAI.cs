using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hZombieAI : hMonsterAI
{
    protected override void InitBTS()
    {
        /*hActionNode findPlayer = new hActionNode(FindPlayer);
        hActionNode moveToPlayer = new hActionNode(MoveTo);
        hActionNode attack = new hActionNode(Attack);
        hSequenceNode pattern1 = new hSequenceNode(new List<hBTSNode>() { findPlayer, moveToPlayer, attack });

        m_RootNode.children.Add(pattern1);

        m_PreTargetPos = transform.position;*/
        //hDecorationNode moveDeco = new hDecorationNode(moveToPlayer, newPicking);
        //m_Root = new hSelectorNode(new List<hBTSNode>() { moveDeco });
    }

    private Vector3 m_PreTargetPos;

    private NodeState FindPlayer()
    {
        m_Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        m_Des = m_Target.transform.position;
        if (Vector3.Distance(m_Des, m_PreTargetPos) > .01f)//타겟의 위치가 달라진다면
        {
            m_RigidBody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            m_PreTargetPos = m_Des;
            m_Agent.speed = m_Character.m_MoveSpeed.m_CurrentValue;
            m_Agent.SetDestination(m_Des);
            return NodeState.RUNNING;
        }

        return NodeState.SUCCESS;
    }

    private NodeState MoveTo()
    {
        m_Animator.SetFloat("Move", m_Agent.speed);
        if (Vector3.Distance(transform.position, m_Des) < m_AttackRange)
        {
            m_Agent.velocity = Vector3.zero;
            m_Agent.speed = 0f;
            m_Agent.ResetPath();
            return NodeState.SUCCESS;
        }

        return NodeState.RUNNING;
    }

    private NodeState Attack()
    {
        if (!m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            m_RigidBody.constraints = RigidbodyConstraints.FreezeRotation;
            m_Animator.SetTrigger("Attack");
            return NodeState.RUNNING;
        }
        return NodeState.SUCCESS;
    }

    public void GiveDamage()
    {
        if (Vector3.Distance(transform.position, m_Target.transform.position) < m_AttackRange)
        {
            Debug.Log("attack");
            m_Character.DealDamage(m_Target);
        }
    }

    protected override void Dead()
    {
        m_Collider.enabled = false;
        m_Agent.isStopped = true;
        m_Animator.SetTrigger("Dead");
        m_launch = false;
    }
}
