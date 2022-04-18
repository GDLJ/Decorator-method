using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDecorator3 : Decorator
{
    public GameObject title3;
    public override void Build()
    {
        base.Build();
        title3 = Object.Instantiate(Resources.Load("title3") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
