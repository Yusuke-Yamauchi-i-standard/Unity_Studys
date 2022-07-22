- - -
# 2022_07_20 勉強会
- - -

## 行ったことの目次

- [2022_07_20 勉強会](#2022_07_20-勉強会)
  - [行ったことの目次](#行ったことの目次)
    - [Unityプロジェクトの立ち上げ方法を学ぶ](#unityプロジェクトの立ち上げ方法を学ぶ)
    - [3D空間にGameObjectを配置する](#3d空間にgameobjectを配置する)
    - [3D空間にMeshなどの特殊なGameObjectの配置する](#3d空間にmeshなどの特殊なgameobjectの配置する)
    - [リソースファイルをUnityで使う準備をする](#リソースファイルをunityで使う準備をする)
    - [マテリアル](#マテリアル)
    - [3D空間にMeshなどの特殊なGameObjectを配置する](#3d空間にmeshなどの特殊なgameobjectを配置する)
    - [3D空間にモデルファイルを展開して配置する](#3d空間にモデルファイルを展開して配置する)
    - [Prefab](#prefab)
    - [GameObjectを操作するScriptを作成する。](#gameobjectを操作するscriptを作成する)
    - [GameObjectにScriptの適用させる](#gameobjectにscriptの適用させる)
    - [Editor上で実行する方法](#editor上で実行する方法)
    - [GameObjectの親子関係(階層構造)](#gameobjectの親子関係階層構造)
    - [キーボードでの操作](#キーボードでの操作)
    - [用語集](#用語集)

### Unityプロジェクトの立ち上げ方法を学ぶ
1. Unity Hubを開く
2. Unity Hub上のボタン「New Project」を押す
3. 以下の内容を設定する。
     - Editor Version
       - ダウンロードしてあるUnityのバージョンを選択します。
     - Template(3D Core)
       - 選択されたテンプレートによってプロジェクトを新規作成します。
       - 基本的には3Dゲームを開発する場合は`3D Core`を選択します。
       - 基本的には2Dゲームを開発する場合は`2D Core`を選択します。
     - Project name
       - 作成するプロジェクト名を指定します。
     - Location
       - 指定したフォルダにプロジェクトファイルを作成します。

### 3D空間にGameObjectを配置する
1. Hierarchyウィンドウ上で右クリックします。
2. 出てきたメニューの中の`Create Empty`を選択します。
3. Hierarchyウィンドウ上に`Game Object`が生成されたことを確認します。

### 3D空間にMeshなどの特殊なGameObjectの配置する
1. Hierarchyウィンドウ上で右クリックします。
2. それぞれのGameObjectによって設定を変えます。
      - `Cube`(四角いオブジェクト)の場合
        1. `3D Object`を展開します。
        2. 展開されたメニューの中から`Cube`を選択します。
      - `Sphere`(球体オブジェクト)の場合
        1. `3D Object`を展開します。
        2. 展開されたメニューの中から`Sphere`を選択します。
      - `Sprite`表示(画像を2Dで表示)の場合
        1. `UI`を展開します。
        2. 展開されたメニューの中から` Image`を選択します。
        3. Hierarchyウィンドウ上から`Image`オブジェクトを選択し、Inspectorウィンドウ上の`Image`項目の`Source Image`に※`Spriteで利用できる画像`をセットします。
3. Hierarchyウィンドウ上にそれぞれのオブジェクトが生成されたことを確認します。
- ※Spriteで利用できる画像の設定方法
  1. Assetsウィンドウに表示されている対象の画像をクリックします。
  2. Inspectorウィンドウ上に表示された画像の詳細設定の中から`Texture Type`をクリックします。
  3. 選択肢の中から`Sprite(2D and UI)`を選択します。
- 上記のオブジェクト以外にも音声を発生するオブジェクトや光を発生させるオブジェクト、動画を発生させるオブジェクトがあります。

### リソースファイルをUnityで使う準備をする
- リソースファイルとは、プロジェクトで扱う外部ファイルのこと
  - 音声ファイル(wavやmp3)
  - 画像ファイル(pngやjpeg)
  - モデルファイル(fbxなど)
  - 動画ファイル(mp4など)
  - etc
1. 対象のファイルのあるフォルダを開きます。
2. 対象のファイルをUnityウィンドウ上のAssetsウィンドウにドラッグ&ドロップを行います。

### マテリアル
- マテリアルはそのまま材質という意味で、描画時に色や質感などを指定する事ができます。
- 生成方法
  1. Assetsウィンドウ上で右クリックします。
  2. メニューから`Create`を展開します。
  3. 項目の中の`Material`を選択します。
  4. Assetsウィンドウ上にMaterialファイルが生成されていることを確認します。
- マテリアルを変更する
  1. Assetsウィンドウ上で付けたいMaterialファイルを選択します。
  2. Inspectorを確認して、Renderを持つ対象のGameObejctを選択します。
  3. 以下の場所にドラッグ&ドロップしてください。
     - Inspectorウィンドウ上の変更したいMaterial
     - Hierarchyウィンドウ上の対象のGameObject
- マテリアルで利用する画像を変更する
  1. Assetsウィンドウ上で付けたい画像ファイルを選択します。
  2. Hierarchyウィンドウ上で画像を変えたいGameObjectを選択します。
  3. Inspectorウィンドウ上でMaterialの選択項目へ移動します。
  4. Albedo項目の左側の四角い場所を確認します。
  5. 対象の画像ファイルをAlbedo項目の左側の四角い場所に対してドラッグ&ドロップを行います。

### 3D空間にMeshなどの特殊なGameObjectを配置する
1. Hierarchy上で右クリックします。
2. それぞれのGameObjectによって設定を変えます。
      - `Cube`(四角いオブジェクト)の場合
        1. `3D Object`を展開します。
        2. 展開されたメニューの中から`Cube`を選択します。
      - `Sphere`(球体オブジェクト)の場合
        1. `3D Object`を展開します。
        2. 展開されたメニューの中から`Sphere`を選択します。
      - `Sprite`表示(画像を2Dで表示)の場合
        1. `UI`を展開します。
        2. 展開されたメニューの中から`Image`を選択します。
        3. `Image`オブジェクトを選択して
3. Inspector ウィンドウ上にそれぞれのオブジェクトが生成されたことを確認します。
- 上記のオブジェクト以外にも音声を発生するオブジェクトや光を発生させるオブジェクト、動画を発生させるオブジェクトがあります。

### 3D空間にモデルファイルを展開して配置する
1. Assetsウィンドウ上にある対象のモデルファイルを選択します。
2. Assetsウィンドウ上の対象のモデルファイルをHierarchyウィンドウ上へドラッグ&ドロップします。
3. Hierarchyウィンドウ上に対象のモデルファイル名のGameObjectが作成されたことを確認します。


### Prefab
- PrefabとはUnityのHierarchy上に配置されたゲームオブジェクトを保存することで生成されるファイルを指します。
- 作成方法
  1. Hierarchyウィンドウ上にあるGameObjectをAssetsウィンドウ上にドラッグ&ドロップします。
  2. Assetsウィンドウ上に対象のGameObject名のファイルが生成されたことを確認します。
  3. Hierarchyウィンドウ上の対象のGameObject名の色が変わったことを確認します。
- 利用方法
  - Assetsウィンドウ上にあるPrefabファイルをHierarchyウィンドウ上またはSceneウィンドウ上に配置することで利用できます。
- 編集する
  - Scene上での編集(Hierarchyウィンドウ上に配置された固定のPrefabの編集方法)
    1. Hierarchyウィンドウ上のPrefabファイルを選択します。
    2. Inspectorウィンドウを操作します。
  - PrefabEdit上での編集(プロジェクト全体のPrefabを編集する)
    1. Assetsウィンドウ上のPrefabをダブルクリックします。
    2. HierarchyウィンドウでScene名の場所がPrefab名に変わったことを確認します。
    3. Inspectorウィンドウを操作します。
    4. HierarchyウィンドウのPrefab名の左隣にある`<`を押します。
    5. HierarchyウィンドウのPrefab名がScene名に戻ったことを確認します。


### GameObjectを操作するScriptを作成する。
- GameObjectの位置を操作するための変数。
  - `Vector3 transform.position`
  - GameObejctを回転操作するための変数。
    - `Quaternion transform.rotate`
  - GameObjectの拡大縮小させるための変数
    - `Vector3 transform.localScale`
  - GameObjectを削除するメソッド
    - `void Object.Destroy(Object _obj,float _delayed)`
  - GameObjectを生成するメソッド
    - `Object Instantiate(Object _obj)`
      - `ヌルチェック`によってエラーを防ぎます。

### GameObjectにScriptの適用させる
1. Assetsウィンドウ上で対象のScriptファイルを選択します。
2. Hierarchyウィンドウ上の付けたいGameObejctを選択します。
3. Assetsウィンドウ上の対象のScriptファイルを以下のいずれかの場所にドラッグ&ドロップします。
   - Hierarchyウィンドウ上の対象のGameObject
   - Inspectorウィンドウ上の一番下にある「Add Component」
4. 対象のGameObjectのInspectorウィンドウ上に対象のScript名の項目が追加されていることを確認します。

### Editor上で実行する方法
1. 画面上部の再生ボタンを押します。
2. 停止させたい場合は再び再生ボタンを押します。
   - この時、実行中に変わった値は全て実行前に戻ります。
3. 一時停止ボタンを押すと再生は止まりますが、それぞれの値はそのままになります。

### GameObjectの親子関係(階層構造)
- GameObjectには親子関係を持たせる事ができます。
- 親子関係になったオブジェクトは以下の様な特徴が与えられます。
  - 親が動くと、子も動きます。
  - 子が動くと、親は動きません。
- 階層構造にする方法
  - 親子関係にする方法は次のとおりです。
    1. Hierarchyウィンドウ上の子とするGameObjectを選択します。
    2. Hierarchyウィンドウ上の親とするGameObjectに対して子とするGameObjectをドラッグ&ドロップします。
    3. 親とするGameObjectから一段下がった場所に子となるGameObjectが存在することを確認します。

### キーボードでの操作
- bool Input.GetKeyDown(KeyCode _key)
  - キーボードやコントローラでのボタンが押された瞬間なのかの確認を行います。
    - KeyCode で 入力確認をしたい値を指定します。
    - 対象のKeyが押し込まれた時のみにtrue(正)が帰る
    - 押し続けても常にtrueが返されるわけではないので注意してください。
    - `if(!Input.GetKeyDown(KeyCode.Space)){return;}`

### 用語集
- 型
  - 値を保持する箱を作成する際にどのように使用するかを指定する言葉になります。
    - bool
      - booleanの略で真偽のみ入れる事ができます。
    - int
      - 整数を入れられます。小数点以下の数値は保持しません。
    - float 
      - 小数点を持ちたい場合はこちらを利用します。
- 変数
  - 値を保持していて、途中で値を変えられる箱を指します。
- 定数
  - 値を保持していて、途中で値を変えられない箱を指します。
- null
  - 値を入れる箱がないことを指します。
- 四則演算子
  - 基本的に計算で利用される文字を指します。
  - +,-,*,/,%
    - %は割り算を行い余りを取得する演算子です。
- 比較演算子
  - 基本的に値を比較する際に利用される文字を指します。
  - ==,!=,<,<=,>,>=
    - `<` は左側の値が右側よりも小さい場合にtrue(真)が取得できます。
    - `>` は左側の値が右側よりも大きい場合にTrue(真)が取得できます。

- `ブロック`
  - 別名で`スコープ`とも言われます。
  - `{}`で囲った部分を言います。

- `if文`
  - 入れられた値が真か偽かで条件を分岐して実行します。
  - 以下が使い方です。
```
if(true or false)
{
  //条件がtrueの時実行します。//
}
//以下は省略可能です。//
//else ifは複数回定義が可能です。//
else if(true or false)
{
  //先頭のifの条件がfalseでこちらの条件がtrueの時実行します。//
}
else
{
  //繋がっているif と else ifが全てfalseだった場合に実行します。//
}
```
- `ヌルチェック`
  - 対象のオブジェクトがnullかをチェックします。
  - 基本的には以下の方法になります。
```
GameObject obj = null;

if(obj == null)return;
```
- `メソッド`
  - メソッドは機能をまとめる機能があります。
  - 定義の差で関数とも呼ばれます。
    - 中で使う変数を呼び出し時に指定する変数を`引数`と言います。
    - 結果として返す値を`戻り値`と言います。
- `return`
  - メソッドから抜けることを指します。
  - 戻り値がある場合は`return val;`の様に記述します。
- [struct Vector3](https://docs.unity3d.com/ja/2020.1/ScriptReference/Vector3.html)
  - 数学の3D空間ベクトル(x,y,z)と同義で使用用途は多岐にわたります。
  - `Vector3`のよく使う定数(定数はそのままで決まった数値を指します。)
    - `Vector3.foward`
      - (0.0.1)の値
    - `Vector3.back`
      - (0.0.-1)の値
    - `Vector3.up`
      - (0.1.0)の値
    - `Vector3.down`
      - (0.-1.0)の値
    - `Vector3.right`
      - (1.0.0)の値
    - `Vector3.left`
      - (-1.0.0)の値
    - `Vector3.one`
      - (1.1.1)の値
    - `Vector3.zero`
      - (0.0.0)の値
- [struct Quaternion](https://docs.unity3d.com/ja/2019.4/ScriptReference/Quaternion.html)
  - 3D空間の回転を司る数値列(x,y,z,w)です。
  - `Quaternion`のよく使うメソッド
    - Quaternion.Euler(x,y,z);
      - x軸,y軸,z軸それぞれの値で回転したQuaternionを取得できる。