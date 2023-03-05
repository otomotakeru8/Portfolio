using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BeltConveyorScript: MonoBehaviour
{
    //trueの時はモードに関係なく動作します,trueの時は動かすことができません
    [SerializeField] bool EditModeUpdate;

    //アイテムを中央にそろえます
    [SerializeField] bool CatchItem;

    //コンベアの向きを変えられます
    enum Direction { MAE, USIRO, MIGI, HIDARI }
    [SerializeField] Direction direction = Direction.MAE;

    //コンベアの長さを調節できます
    [SerializeField] float ConveyerLength;
    //コンベアの幅を調節できます
    [SerializeField] float ConveyerWide;

    //このポジションにコンベアが固定されます
    Vector3 AnchorPosition;

    //translateの移動量
    [SerializeField] float TranslateValue;

    bool ceck;

    void Start()
    {
        if (EditModeUpdate == true)
        {
            AnchorPosition = transform.position;
        }
    }

    void Update()
    {
        //EditModeUpdateがtrueに変わった時
        if (ceck == false && EditModeUpdate == true) AnchorPosition = transform.position;
        ceck = EditModeUpdate;
        if (EditModeUpdate == true)
        {
            //コンベアの向きと大きさを適応します
            switch (direction)
            {
                case Direction.MAE:
                    transform.localScale = new Vector3(ConveyerWide, 1, ConveyerLength);
                    break;
                case Direction.USIRO:
                    transform.localScale = new Vector3(ConveyerWide, 1, ConveyerLength);
                    break;
                case Direction.MIGI:
                    transform.localScale = new Vector3(ConveyerLength, 1, ConveyerWide);
                    break;
                case Direction.HIDARI:
                    transform.localScale = new Vector3(ConveyerLength, 1, ConveyerWide);
                    break;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (CatchItem == true)
        {
            if (collision.gameObject.tag == "Item")
            {
                switch (direction)
                {
                    case Direction.MAE:
                        if (Mathf.Abs(collision.transform.position.x - AnchorPosition.x) >= 0.1)
                        {
                            if (collision.transform.position.x < AnchorPosition.x)
                            {
                                collision.transform.Translate(TranslateValue, 0, 0, Space.World);
                            }
                            if (collision.transform.position.x > AnchorPosition.x)
                            {
                                collision.transform.Translate(-TranslateValue, 0, 0, Space.World);
                            }
                        }
                        if (Mathf.Abs(collision.transform.position.x - AnchorPosition.x) < 0.1)
                        {
                            collision.transform.Translate(0, 0, TranslateValue, Space.World);
                        }
                        break;
                    case Direction.USIRO:
                        if (Mathf.Abs(collision.transform.position.x - AnchorPosition.x) >= 0.1)
                        {
                            if (collision.transform.position.x < AnchorPosition.x)
                            {
                                collision.transform.Translate(TranslateValue, 0, 0, Space.World);
                            }
                            if (collision.transform.position.x > AnchorPosition.x)
                            {
                                collision.transform.Translate(-TranslateValue, 0, 0, Space.World);
                            }
                        }
                        if (Mathf.Abs(collision.transform.position.x - AnchorPosition.x) < 0.1)
                        {
                            collision.transform.Translate(0, 0, -TranslateValue, Space.World);
                        }
                        break;
                    case Direction.MIGI:
                        if (Mathf.Abs(collision.transform.position.z - AnchorPosition.z) >= 0.1)
                        {
                            if (collision.transform.position.z < AnchorPosition.z)
                            {
                                collision.transform.Translate(0, 0, TranslateValue, Space.World);
                            }
                            if (collision.transform.position.z > AnchorPosition.z)
                            {
                                collision.transform.Translate(0, 0, -TranslateValue, Space.World);
                            }
                        }
                        if (Mathf.Abs(collision.transform.position.z - AnchorPosition.z) < 0.1)
                        {
                            collision.transform.Translate(TranslateValue, 0, 0, Space.World);
                        }
                        break;
                    case Direction.HIDARI:
                        if (Mathf.Abs(collision.transform.position.z - AnchorPosition.z) >= 0.1)
                        {
                            if (collision.transform.position.z < AnchorPosition.z)
                            {
                                collision.transform.Translate(0, 0, TranslateValue, Space.World);
                            }
                            if (collision.transform.position.z > AnchorPosition.z)
                            {
                                collision.transform.Translate(0, 0, -TranslateValue, Space.World);
                            }
                        }
                        if (Mathf.Abs(collision.transform.position.z - AnchorPosition.z) < 0.1)
                        {
                            collision.transform.Translate(-TranslateValue, 0, 0, Space.World);
                        }
                        break;
                }
            }
            if (collision.gameObject.tag != "Item")
            {
                if (CatchItem == true)
                {
                    switch (direction)
                    {
                        case Direction.MAE:
                                collision.transform.Translate(0, 0, TranslateValue, Space.World);
                            break;
                        case Direction.USIRO:
                                collision.transform.Translate(0, 0, -TranslateValue, Space.World);
                            break;
                        case Direction.MIGI:
                                collision.transform.Translate(TranslateValue, 0, 0, Space.World);
                            break;
                        case Direction.HIDARI:
                                collision.transform.Translate(-TranslateValue, 0, 0, Space.World);
                            break;
                    }
                }
            }
        }

        if (EditModeUpdate == true)
        {
            if (CatchItem == false)
            {
                switch (direction)
                {
                    case Direction.MAE:
                        collision.transform.Translate(0, 0, TranslateValue, Space.World);
                        break;
                    case Direction.USIRO:
                        collision.transform.Translate(0, 0, -TranslateValue, Space.World);
                        break;
                    case Direction.MIGI:
                        collision.transform.Translate(TranslateValue, 0, 0, Space.World);
                        break;
                    case Direction.HIDARI:
                        collision.transform.Translate(-TranslateValue, 0, 0, Space.World);
                        break;
                }
            }
        }
    }

    private void LateUpdate()
    {
        if (EditModeUpdate == true)
        {
            transform.position = AnchorPosition;
        }
    }
}
