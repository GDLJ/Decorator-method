using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameDecorator1 : Decorator
{
    public GameObject name1;
    public override void Build()
    {
        base.Build();
        name1 = Object.Instantiate(Resources.Load("name1") as GameObject, GameObject.FindWithTag("canvas").transform);
    }
}
