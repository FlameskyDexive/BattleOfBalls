﻿using UnityEngine;
using System.Collections;
using ETModel;
using UnityEngine.UI;

public class PlayerMoveControl : MonoBehaviour
{

    public float moveSpeed = 0.05f;
    public delegate void MoveDelegate();
    // private Text name;

    // Use this for initialization
    void Awake()

        moveEnd = OnMoveEnd;
        
    }
    {

    }

    void OnMoveStart()

    // Update is called once per frame
    private float angle;
    private Vector3 curPos = new Vector3();
        {
            Vector3 vecMove = mJoystick.MovePosiNorm * Time.deltaTime * moveSpeed;
            //Log.Debug($"--position--{mJoystick.MovePosiNorm.ToString()}");
            //Debug.Log(Time.time);
            //if (Mathf.Abs(vecMove.x) > 0.01f || Mathf.Abs(vecMove.y) > 0.01f)
            {
                //animator.SetBool("Run", true);
                angle = Mathf.Atan2(mJoystick.MovePosiNorm.x, mJoystick.MovePosiNorm.z) * Mathf.Rad2Deg - 10;
                _mTransform.localRotation = Quaternion.Euler(Vector3.back * angle);
                //this.transform.position += (transform.forward * moveSpeed) ;
                //Log.Debug($"--position--{vecMove.ToString()}");
                curPos.x = this.transform.position.x + mJoystick.MovePosiNorm.x * this.moveSpeed / 10;
                curPos.y = this.transform.position.y + mJoystick.MovePosiNorm.y * this.moveSpeed / 10;
                //this.transform.position += mJoystick.MovePosiNorm * this.moveSpeed / 10;
                this.transform.position = this.curPos;
                /*if (animator.GetCurrentAnimatorStateInfo(0).IsName("Run"))
                {
                    cc.SimpleMove(transform.forward * moveSpeed);
                }*/
            }
            //else
            {
                //animator.SetBool("Run", false);
            }
        }


        if (!_turnBase)