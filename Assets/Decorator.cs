using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : Camp
{
    protected Camp camp;
    public void Setcamp(Camp camp)
    {
        this.camp = camp;
    }
    public override void Build()
    {
        if (camp != null)
        {
            camp.Build();
        }
    }
}
