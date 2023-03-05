using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//マップ上に転がっている時だけ実体化
//プレイヤーに持たれている時はメッシュだけ
//机に置かれているアイテムも実体化する必要ない

public class Itam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Releasevelocity()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
