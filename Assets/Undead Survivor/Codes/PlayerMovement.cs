using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed = 3.0f;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;
    void Awake() 
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
       
    }

    void FixedUpdate() 
    {
        //rigid.AddForce(inputVec);

        //rigid.velocity = inputVec;
        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime; // 없으면 대각선 이동시 루트이 속도로감
        rigid.MovePosition(rigid.position + nextVec); //rigid position >> rigidbody 위치
        
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    void LateUpdate() 
    {
        anim.SetFloat("Speed", inputVec.magnitude); //magnitude 벡터의 순수 크기

        if (inputVec.x != 0) {
            spriter.flipX = inputVec.x < 0;
        }    
    }

}
