using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
            Destroyメソッドで対象のGameObjectを削除します。
            メソッドは機能をまとめた物です。
            定義方法はUpdate,Startなどと同じように作成できます。
        */
        Destroy(gameObject);
    }
}
