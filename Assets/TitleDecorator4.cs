using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDecorator4 : Decorator
{
    public GameObject title4;
    public override void Build()
    {
        base.Build();
        title4 = Object.Instantiate(Resources.Load("title4") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
