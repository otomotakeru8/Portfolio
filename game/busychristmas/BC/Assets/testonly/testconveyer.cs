using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class testconveyer : MonoBehaviour
{
    // Start is called before the first frame update

    //trueの時はモードに関係なく動作します,trueの時は動かすことができません
    [SerializeField] bool EditModeUpdate;

    //コンベアの向きを変えられます
    enum Direction{ MAE, USIRO, MIGI, HIDARI }
    [SerializeField] Direction direction = Direction.MAE;
    //動作方法を変更できます
    enum Type{ VELOCITY, TRANSFORM, ADDVELOCITY }
    [SerializeField] Type type = Type.TRANSFORM;

    //コンベアの長さを調節できます
    [SerializeField] float ConveyerLength;
    //コンベアの幅を調節できます
    [SerializeField] float ConveyerWide;

    //このポジションにコンベアが固定されます
    Vector3 AnchorPosition;
    //VELOCITY選択時この変数が適応されます
    [SerializeField] float VelocityValue;
    //TRANSFORM選択時この変数が適応されます
    [SerializeField] float TranslateValue;
    //ADDVELOCITY選択時この変数が適応されます
    [SerializeField] float AddVelocityValue;

    Rigidbody rb;
    bool ceck;

    void Start()
    {
        if (EditModeUpdate == true)
        {
            AnchorPosition = transform.position;
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
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

            if (type == Type.VELOCITY)
            {
                switch (direction)
                {
                    case Direction.MAE:
                        rb.velocity = new Vector3(0, 0, VelocityValue);
                        break;
                    case Direction.USIRO:
                        rb.velocity = new Vector3(0, 0, -VelocityValue);
                        break;
                    case Direction.MIGI:
                        rb.velocity = new Vector3(VelocityValue, 0, 0);
                        break;
                    case Direction.HIDARI:
                        rb.velocity = new Vector3(-VelocityValue, 0, 0);
                        break;
                }
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (EditModeUpdate == true)
        {
            if (type == Type.TRANSFORM)
            {
                switch (direction)
                {
                    case Direction.MAE:
                        collision.transform.Translate(0, 0, TranslateValue,Space.World);
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

            if (type == Type.ADDVELOCITY)
            {
                switch (direction)
                {
                    case Direction.MAE:
                        collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(collision.gameObject.GetComponent<Rigidbody>().velocity.x, collision.gameObject.GetComponent<Rigidbody>().velocity.y, AddVelocityValue);
                        collision.gameObject.GetComponent<testonly.Player>();
                        break;
                    case Direction.USIRO:
                        collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -AddVelocityValue);
                        break;
                    case Direction.MIGI:
                        collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(AddVelocityValue, 0, 0);
                        break;
                    case Direction.HIDARI:
                        collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-AddVelocityValue, 0, 0);
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

    public void A()
    {

    }
}
