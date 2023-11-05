using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すｘ方向の範囲
    private float posRange = 3.4f;
    //Unityちゃんのゲームオブジェクト
    private GameObject unitychan;
    //Unityちゃんの位置を取得
    private int unitychanPos;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのゲームオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんの位置情報を取得
        this.unitychanPos = Mathf.RoundToInt(unitychan.transform.position.z);

        /*
        //一定の距離ごこにアイテムを生成
        for (int i = startPos; i < goalPos; i += 15)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //コーンをX軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {
                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //60％コイン配置:30％車配置:10％何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車の生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        //過去のUnityちゃんの位置と現在のUnityちゃんの位置の差が１５以上かどうか
        if((unitychan.transform.position.z - unitychanPos) >= 15)
        {
            //アイテムを生成する位置をスタート地点からにする　＋　ゴール近くまでアイテムを生成する
            if(unitychan.transform.position.z + 50 >= startPos && unitychan.transform.position.z + 35 <= goalPos)
            {
                //どのアイテムを出すのかをランダムに設定
                int num = Random.Range(1, 11);
                if (num <= 2)
                {
                    //コーンをX軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychanPos + 50);
                    }
                }
                else
                {
                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);
                        //アイテムを置くZ座標のオフセットをランダムに設定
                        int offsetZ = Random.Range(-5, 6);
                        //60％コイン配置:30％車配置:10％何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab);
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, (unitychanPos + 50) + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車の生成
                            GameObject car = Instantiate(carPrefab);
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, (unitychanPos + 50) + offsetZ);
                        }
                    }
                }
            }
            //過去のUnityちゃんの位置を更新
            this.unitychanPos = Mathf.RoundToInt(unitychan.transform.position.z);
        }
    }
}