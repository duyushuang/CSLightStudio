﻿using System;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using Object = UnityEngine.Object;//如果发生名字冲突可以这样写
class State1 : IState
{
    public StateMgr mgr
    {
        get;
        private set;
    }


    GameObject root = null;
    public void OnInit()
    {
        root = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

        for (int i = 0; i < 10; i++)
        {
            GameObject sub = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            sub.transform.parent = root.transform;
            sub.transform.localPosition = new Vector3(i, 0, 0);
            sub.GetComponent("Transform");
        }
    }
    int clicktag = 1;
    public void OnExit()
    {
        Object.Destroy(root);
    }

    public void OnUpdate()
    {
        if (clicktag == 1)
        {

            root.transform.Rotate(Vector3.up, 15.0f);
        }
    }

    public void ClickEvent(int tag)
    {
        clicktag = tag;
    }
}
