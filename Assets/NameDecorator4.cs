using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameDecorator4 : Decorator
{
    public GameObject name4;
    public override void Build()
    {
        base.Build();
        name4 = Object.Instantiate(Resources.Load("name4") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
