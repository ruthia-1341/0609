using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hennsuu : MonoBehaviour
{
    int a = 10;
    int vx = 20;

    public void Ensyu71()
    {
        int vx = 5;
        Debug.Log(vx);
        vx = 10;
        Debug.Log(vx);
        /*this vx = 10;
         �����Ensyu71�̊O��vx�ɑ�����Ă���B

        ���̂�����Debug.Log(vx);������ƁA���̐^���int vx = 5;�������Ă��Ă����
         */
    }

    public void Proc()
    {
        
        float fw = 3.14f;
        string str = "����ɂ���";
        bool bl = true;
        
        Debug.Log(a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Ensyu72()
    {
        Debug.Log(vx);//���ɂȂ�����O�Ɉ�o�ĒT���Ă��Ă����B�D�����B
    }

    public void Ensyu74()
    {
        vx += 10;//�O��int vx = 20;��+10������Ă��������ɂȂ�B �����A�ł�����l�������Ƒ�����B
        Debug.Log(vx);
    }

}
