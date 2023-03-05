using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerMath playermath = new PlayerMath();
    [SerializeField] GameObject m_handPos;

    public void Spawn(Vector3 position)
    {
        transform.position = position;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Look(Quaternion direction)
    {
        transform.rotation = direction;
    }
    public void Move(float speed, float dash)
    {
        Vector3 forward = transform.forward;
        GetComponent<Rigidbody>().velocity = forward * speed * dash;
    }

    public void ItemHold(bool hold, GameObject item, bool latehold)
    {
        GameObject holditem = item;
        if (hold == true && latehold == false)
        {
            Instantiate(holditem, m_handPos.transform.position, transform.rotation, this.transform);
        }
        if (hold == false && latehold == true)
        {
            Destroy(transform.GetChild(5).gameObject);
        }
    }
}
