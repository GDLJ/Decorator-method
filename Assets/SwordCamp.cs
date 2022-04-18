using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCamp : Camp
{
    public GameObject sword;
    public override void Build()
    {
       sword =  Object.Instantiate(Resources.Load("sword") as GameObject); 
    }
} 
