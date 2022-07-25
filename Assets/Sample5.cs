using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample5 : MonoBehaviour
{
    /*
        メンバー変数と呼ばれます。
        変数は値を保持するために利用します。
        メンバー変数は通常の変数とほとんど変わりはありません。
        Unityで利用すると、GameObjectはHierarchyに登録されているGameObjectやAssetsにあるprefabを
        ドラッグ&ドロップでセットすることができるボックスが表示されます。
    */
    public GameObject prefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
            Null Check(ヌルチェック)
            対象の変数がnullかどうかを確認し、
            nullだった場合はこの関数から抜けるという命令を与えます。
        */
        if (prefab == null)
        {
            /*
                主に関数から抜けたい時に利用します。
                こちらを通過するとこれ以降の計算やメソッドを通過しなくなります。
            */
            return;
        }
        /*
            GameObjectを生成して、アプリケーション上で利用できる様にします。
            これは入れたGameObjectによって生成されます。
            例えば自分自身をもつgameObjectをprefabの代わりに入れると、
            自分自身を持つgameObjectのクローンが生成されます。
        */
        Instantiate(prefab);
    }


}
