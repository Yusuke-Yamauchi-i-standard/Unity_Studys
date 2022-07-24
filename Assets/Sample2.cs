using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         *
         * GameObjectを回転させるにはrotationを利用します。
         * rotationはQuaternion型です。
         * 
         * Quaternionは3D空間での計算によく利用されます。
         * 一般的なx,y,zの軸で回転させることをEuler(オイラー)角と言います。
         * Quaternionはかなり特殊で、x,y,zの値をそのまま入れて利用すると失敗します。
         * そこでUnityではQuaternion.Eulerを利用します。
         * このメソッドはEuler角を利用してQuarternionを作成してくれる機能になります。
         * 
         * Quaternionのもう一つの特徴として、回転情報を合わせるには掛け算しか利用できない点です。
         * 誤って足し算は利用しない様にしましょう。
         * 
        */

        transform.rotation *= Quaternion.Euler(0.5f, 0.0f, 0.0f);
        //transform.rotation = transform.rotation * Quaternion.Euler(0.5f, 0.0f, 0.0f);
    }
}
