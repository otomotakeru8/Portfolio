using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MapConstant;

public class CameraManager : MonoBehaviour
{
    Vector3 m_lateRaycastHitPoint;

    float m_cameraDownLimit = 7;
    float m_cameraUpLimit = 10;

    [SerializeField]
    float m_dragRatio;
    [SerializeField]
    float m_scrollRatio;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(center, transform.position.y, center - 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.GetMouseDrag() == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            foreach (RaycastHit raycastHit in Physics.RaycastAll(ray, 60f))
            {
                if (raycastHit.collider.name == "CameraScrollPlate")
                {
                    if (m_lateRaycastHitPoint == default)
                    {
                        m_lateRaycastHitPoint = raycastHit.point;
                    }
                    transform.Translate(new Vector3((m_lateRaycastHitPoint.x - raycastHit.point.x) / m_dragRatio, 0, (m_lateRaycastHitPoint.z - raycastHit.point.z) / m_dragRatio), Space.World);
                }
            }
        }
        if (InputManager.GetMouseDrag() == false)
        {
            m_lateRaycastHitPoint = default;
        }

        float scroll = Input.mouseScrollDelta.y * m_scrollRatio;
        if (scroll > 0)
        {
            if (transform.position.y > m_cameraDownLimit)
            {
                transform.Translate(transform.forward * scroll, Space.World);
            }
        }
        else
        {
            if (transform.position.y < m_cameraUpLimit)
            {
                transform.Translate(transform.forward * scroll, Space.World);
            }
        }
    }
}
