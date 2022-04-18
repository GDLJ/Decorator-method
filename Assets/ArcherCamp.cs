using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCamp : Camp
{
    public GameObject archer;
    public override void Build()
    {
        archer = Object.Instantiate(Resources.Load("archer") as GameObject);
    }
    
}
