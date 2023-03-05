using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlayerController : MonoBehaviour
{
    public float idospeed;
    //�ړ��֘A�̃p�����[�^
    [Header("�����̍Œ�l")]
    [SerializeField]
    private float minSpeed = 3.0f;
    [Header("�����̍ō��l")]
    [SerializeField]
    private float maxSpeed = 5.0f;
    [Header("�v���C���[�̕����]���X�s�[�h�̒����l")]
    //0.0f���ƈ�،������ς�炸1.0f���Ɠ��͌シ�����͂��ꂽ�����֌���
    [SerializeField, Range(0.0f, 1.0f)]
    private float turnRate = 0.8f;

    //�ړ����x
    private Vector3 velocity;

    //�L�����N�^�[�R���g���[���[
    private CharacterController controller;

    //Inspector�ɂ�Range�̒l���w��͈̔͂Ɏ��܂�悤��Clamp����
    private void OnValidate()
    {
        this.turnRate = Mathf.Clamp(this.turnRate, 0.0f, 1.0f);
    }

    //�����ݒ�
    void Awake()
    {
        //�L�����N�^�[�R���g���[���[�擾
        this.controller = this.GetComponent<CharacterController>();

        //���x���[���ɐݒ�
        this.velocity = Vector3.zero;

    }

    //�X�V����
    void Update()
    {
        Vector3 vec = this.velocity;
        float Speed = 0.0f;

        //���ɐڒn���Ă��������
        if (this.controller.isGrounded)
        {
            //�Q�[���p�b�h�̃X�e�B�b�N���͒l���擾���Ĉړ��x�N�g�����쐬
            //..���łɐڒn���Ă���̂�Y���̒l�����Z�b�g
            vec = new Vector3(Input.GetAxisRaw("L_Stick_V2"), 0, Input.GetAxisRaw("L_Stick_H2"));

            //���͒l���瓾���x�N�g���̒�����0.1f���z���Ă���Α�����ݒ�
            if (vec.magnitude > 0.1f)
            {
                //�X�e�B�b�N�̓|����ɂ���đ�����ύX
                Speed = Mathf.Lerp(this.minSpeed, this.maxSpeed, vec.magnitude);

                //�����̕ύX
                Vector3 dir = vec.normalized;
                float rotate = Mathf.Acos(dir.z);
                if (dir.x < 0) rotate = -rotate;
                rotate *= Mathf.Rad2Deg;
                Quaternion Q = Quaternion.Euler(0, rotate, 0);
                //�����Ń��f���̌����Ă�����������X�ɕς��悤�ɏ�������
                //���f���̌�����ύX
                this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Q, this.turnRate);
            }

            //�ړ��x�N�g���𐳋K��
            vec = vec.normalized;
        }

        //�ړ����x��ݒ�
        this.velocity.x = vec.x * Speed;
        this.velocity.y = vec.y;
        this.velocity.z = vec.z * Speed;

        //�d�͂ɂ�闎����ݒ�
        this.velocity.y += Physics.gravity.y * Time.deltaTime;

        //�ړ�������
        this.controller.Move(this.velocity * Time.deltaTime);

        if (TitleScreen.ScreenState == 0)
        {
            // ����������������������������������������������������������������������������������������
            // ���C�����j���[�̓��͂͂����ł��I
            // ����������������������������������������������������������������������������������������

            if (Input.GetKey("up"))
            {
                transform.position -= transform.right * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("down"))
            {

                transform.position += transform.right * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("right"))
            {

                transform.position += transform.forward * idospeed * Time.deltaTime;
            }
            if (Input.GetKey("left"))
            {
                transform.position -= transform.forward * idospeed * Time.deltaTime;
            }
        }
    }

}
