using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    //プレイヤーの付近にたどり着いたかどうか
    private bool isReachTargetPosition;
    //目的地
    private Vector3 targetPosition;

    public enum Index
    {
        Red=0,
        Blue,
        Green,
        Max,
    }

    [SerializeField, Header("設定したい目的地を知ってるobj")]
    Player Player;

    [SerializeField, Header("x軸　下限")]
    float X_MIN_MOVE_RANGE;

    [SerializeField, Header("x軸　上限")]
    float X_MAX_MOVE_RANGE;

    [SerializeField, Header("y軸　下限")]
    float Y_MIN_MOVE_RANGE;

    [SerializeField, Header("y軸　上限")]
    float Y_MAX_MOVE_RANGE;

    [SerializeField, Header("移動スピード")]
    float SPEED;

    [SerializeField, Header("敵のタイプ")]
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
        //現在の位置からplayerまでSPEEDの速度で移動する
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
