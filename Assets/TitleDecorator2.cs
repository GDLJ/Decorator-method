using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDecorator2 : Decorator
{
    public GameObject title2;
    public override void Build()
    {
        base.Build();
        title2 = Object.Instantiate(Resources.Load("title2") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
