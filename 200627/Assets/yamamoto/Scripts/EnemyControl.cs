using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    //�v���C���[�̕t�߂ɂ��ǂ蒅�������ǂ���
    private bool isReachTargetPosition;
    //�ړI�n
    private Vector3 targetPosition;

    public enum Index
    {
        Red=0,
        Blue,
        Green,
        Max,
    }

    [SerializeField, Header("�ݒ肵�����ړI�n��m���Ă�obj")]
    Player Player;

    [SerializeField, Header("x���@����")]
    float X_MIN_MOVE_RANGE;

    [SerializeField, Header("x���@���")]
    float X_MAX_MOVE_RANGE;

    [SerializeField, Header("y���@����")]
    float Y_MIN_MOVE_RANGE;

    [SerializeField, Header("y���@���")]
    float Y_MAX_MOVE_RANGE;

    [SerializeField, Header("�ړ��X�s�[�h")]
    float SPEED;

    [SerializeField, Header("�G�̃^�C�v")]
    Index Type;
    bool isGoal;
    // Start is called before the first frame update
    void Start()
    {
        this.isReachTargetPosition = false;
        isGoal = false;
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̈ʒu����player�܂�SPEED�̑��x�ňړ�����
        if (!isGoal) targetPosition = Player.GetTargetPos();

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, SPEED);

        if (transform.position == targetPosition)
        {
            isReachTargetPosition = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            isGoal = true;
        }
    }
    public void SetTargetPosObj(GameObject _targetObj) { Player = _targetObj.GetComponent<Player>(); }
    public Index GetType() { return Type; }
}
