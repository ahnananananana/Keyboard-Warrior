﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hDragonBossAI : hMonsterAI
{
    public GameObject target;
    public bool m_IsMet;
    private Vector3 m_PreTargetPos;
    [SerializeField]
    private Transform m_FlamePos;

    protected override void InitBTS()
    {
        m_PreTargetPos = target.transform.position;

        hSelectorNode subRoot = new hSelectorNode(new List<hBTSNode>());
        m_RootNode.children.Add(subRoot);


        hDecorationNode isEncounter = new hDecorationNode(IsEncounter);

        hSequenceNode encounter = new hSequenceNode();
        isEncounter.child = encounter;

        hActionNode scream = new hDoAnimation(this, "Scream", target.transform);

        hDoAction setMet = new hDoAction(() => { m_IsMet = true; return NodeState.SUCCESS; });

        encounter.children.Add(scream);
        encounter.children.Add(setMet);


        hDecorationNode isDead = new hDecorationNode(IsDead);
        hActionNode dead = new hDoAnimation(this, "Die");
        isDead.child = dead;


        hSequenceNode pattern1 = new hSequenceNode();

        hActionNode findPlayer = new hFindAction(this, target);

        hDecorationNode isTargetMoved = new hDecorationNode(IsTargetMoved);
        hActionNode moveTo = new hMoveAction(this, target.transform, target.transform, m_AttackRange);
        isTargetMoved.child = moveTo;

        hActionNode clawAttack = new hDoAnimation(this, "Claw Attack");

        pattern1.children.Add(findPlayer);
        pattern1.children.Add(isTargetMoved);
        pattern1.children.Add(clawAttack);


        subRoot.children.Add(isEncounter);
        subRoot.children.Add(isDead);
        subRoot.children.Add(pattern1);


        /*hActionNode findPlayer = new hFindAction(this, target);

        hActionNode moveTo = new hMoveAction(this, target.transform, null, m_AttackRange);
        hDecorationNode isTargetMoved = new hDecorationNode(moveTo, IsTargetMoved);

        hActionNode clawAttack = new hDoAnimation(this, "Claw Attack");

        hSequenceNode subRoot = new hSequenceNode(new List<hBTSNode>() { findPlayer, isTargetMoved, clawAttack });
        m_RootNode.children.Add(subRoot);*/
    }

    private bool IsTargetMoved()
    {
        if (m_PreTargetPos != target.transform.position)
        {
            m_PreTargetPos = target.transform.position;
            return false;
        }
        return true;
    }

    private bool IsEncounter()
    {
        if (m_IsMet)
            return false;

        return true;
    }

    private bool IsDead()
    {
        if (character.m_state == Character.STATE.DEAD)
            return true;
        return false;
    }

    protected override void Dead()
    {
        throw new System.NotImplementedException();
    }

}
