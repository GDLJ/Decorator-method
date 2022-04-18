using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameDecorator3 : Decorator
{
    public GameObject name3;
    public override void Build()
    {
        base.Build();
        name3 = Object.Instantiate(Resources.Load("name3") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
