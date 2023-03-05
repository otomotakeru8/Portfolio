using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic2Script : MonoBehaviour
{
    public GameObject m_thunderBrock;
    [SerializeField]
    int m_randomRrange;
    [SerializeField]
    float m_dethTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Destroy), m_dethTime);
    }

    // Update is called once per frame
    void Update()
    {
        //ランダムで上下左右にずれる
        int r = Random.Range(1, m_randomRrange);
        if (r == 1)
        {
            transform.Translate(0, 0.05f, 0);
        }
        if (r == 2)
        {
            transform.Translate(0, -0.05f, 0);
        }
        if (r == 3)
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (r == 4)
        {
            transform.Translate(-0.05f, 0, 0);
        }
        //移動
        transform.Translate(0, 0, 0.1f);
        //軌道をオブジェクトで残す(m_thunderBrock)
        Instantiate(m_thunderBrock, transform.position, transform.rotation);
    }
    private void Destroy()
    {
        Destroy(gameObject);
    }

    public void Stordestime()
    {
        m_dethTime += 0.25f;
    }
}
