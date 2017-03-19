﻿using Assets.Scripts.Entities.ApplicationObjects;
using Assets.Scripts.Enums;
using UnityEngine;

namespace Assets.Scripts.Interfaces.Managers.Combat
{
    public interface ICombatManager : IBaseManager
    {
        int GetAttackSequence();
        void EnableAttackerActions();
        void DisableAttackerActions();
        void DisableAttackerActions(float freezeTime);
        void IncreaseSequenceWaitForAction();
        bool CanAttack();
        bool GetHasCastAction();
        void SetTargets(BaseAppObject[] targets);
        BaseAppObject[] GetTargets();
        void SetIsAttacking(bool isAttacking);
        bool GetIsAttacking();
        bool GetIsDefending();
        void SetIsDefending(bool isDefending);
        bool GetIsBlocking();
        void SetIsBlocking(bool isBlocking);
        void SetParryingTarget(BaseAppObject target);
        BaseAppObject GetParryingTarget();
        DirectionEnum[] GetBlockingDirections();
    }
}
