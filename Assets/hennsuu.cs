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
         これはEnsyu71の外のvxに代入している。

        そのうえでDebug.Log(vx);をすると、その真上のint vx = 5;を持ってきてくれる
         */
    }

    public void Proc()
    {
        
        float fw = 3.14f;
        string str = "こんにちは";
        bool bl = true;
        
        Debug.Log(a);
        Debug.Log(fw);
        Debug.Log(str);
        Debug.Log(bl);
    }

    public void Ensyu72()
    {
        Debug.Log(vx);//中にないから外に一つ出て探してきてくれる。優しい。
    }

    public void Ensyu74()
    {
        vx += 10;//外のint vx = 20;に+10するっていう処理になる。 多分連打したら値がずっと増える。
        Debug.Log(vx);
    }

}
