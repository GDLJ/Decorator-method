using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDecorator1 : Decorator
{
    public GameObject title1;
    public override void Build()
    {
        base.Build();
        title1 = Object.Instantiate(Resources.Load("title1") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
