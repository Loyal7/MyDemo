﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wait for me, I don't want to let you down
//love you into disease, but no medicine can.
//Created By HeXiaoTao
public class AttackCombolTwo : BaseState
{


    SetState _setState;
    private float time;
    public AttackCombolTwo(SetState setState)
    {
        time = 0;
        _setState = setState;
        Debug.Log("连接状态 第二击");

    }
    public void AnimationChange()
    {
        time += Time.deltaTime;
        Debug.Log(time);
        if (time >= 1.5f)
            Config.PlayerState.SetState(PlayerState.PLAYERSTATE.ATTACKSTANDY);
        switch (Config.PlayerState.State)
        {
            case PlayerState.PLAYERSTATE.ATTACKSTANDY:
                _setState.SetNewState(new AttackStandyState(_setState));
                //TODO 播放动画
                break;
            case PlayerState.PLAYERSTATE.ATTACK_THREE:
                break;
            case PlayerState.PLAYERSTATE.DIE:
                break;
            case PlayerState.PLAYERSTATE.HIT:
                break;
            default:
                break;
        }
    }

    public void Update()
    {
        //Debug.Log
    }
}
