using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //今指定しているゴールのポジション
    [SerializeField]
    private Vector3 activePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D isHit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (isHit)
        {
            if (isHit.transform.gameObject.tag == "Goal")
            {
                activePosition = isHit.transform.position;
            }
        }
    }

    public Vector3 GetTargetPos() { return activePosition; }

}
