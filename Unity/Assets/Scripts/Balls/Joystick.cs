﻿using UnityEngine;
{

    Transform mTrans;

    private Vector3 _deltaPos;

    private Vector3 deltaPosition;
    float distance;

    [HideInInspector]

    [HideInInspector]
    [SerializeField]
    void Awake()

        EventTriggerListener.Get(gameObject).onDown = OnMoveStart;


    // Use this for initialization
    void Start()
    {
        mTrans = transform;

    // Update is called once per frame
    void Update()
        if (distance >= MoveMaxDistance)       //如果大于可拖动的最大距离
        {
            transform.localPosition = vec;
        {

    void OnDrag(GameObject go, Vector2 delta)
        mTrans.localPosition += new Vector3(_deltaPos.x, _deltaPos.y, 0);

    void OnDragOut(GameObject go)

    void OnMoveStart(GameObject go)