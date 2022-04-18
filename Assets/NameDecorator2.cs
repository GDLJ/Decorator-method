using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameDecorator2 : Decorator
{
    public GameObject name2;
    public override void Build()
    {
        base.Build();
        name2 = Object.Instantiate(Resources.Load("name2") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
