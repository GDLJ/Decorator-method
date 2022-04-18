using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory 
{
    Camp camp = null;
    TitleDecorator1 td1 = null;
    TitleDecorator2 td2 = null;
    TitleDecorator3 td3 = null;
    TitleDecorator4 td4 = null;
    NameDecorator1 nd1 = null;
    NameDecorator2 nd2 = null;
    NameDecorator3 nd3 = null;
    NameDecorator4 nd4 = null;
    public Camp CreatCamp(string keyword)
    {
        switch (keyword)
        {
            case ("sword"):
                camp = new SwordCamp();
                td1 = new TitleDecorator1();
                nd1 = new NameDecorator1();
                td1.Setcamp(camp);
                nd1.Setcamp(td1);
                nd1.Build();
                break;

            case ("axe"):
                camp = new AxeCamp();
                td2 = new TitleDecorator2();
                nd2 = new NameDecorator2();
                td2.Setcamp(camp);
                nd2.Setcamp(td2);
                nd2.Build();
                break;

            case ("archer"):
                camp = new ArcherCamp();
                td3 = new TitleDecorator3();
                nd3 = new NameDecorator3();
                td3.Setcamp(camp);
                nd3.Setcamp(td3);
                nd3.Build();
                break;

            case ("assassin"):
                camp = new AssassinCamp();
                td4 = new TitleDecorator4();
                nd4 = new NameDecorator4();
                td4.Setcamp(camp);
                nd4.Setcamp(td4);
                nd4.Build();
                break;
        }
        return camp;
    }
}
