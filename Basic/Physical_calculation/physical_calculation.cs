using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Myball : MonoBehaviour
{
    // 코드 흐름 선언 < 초기화 < 호출
    Rigidbody rigid;

    public const string SampleScene = "SampleScene";
    //void Start()
    //{

    //    //GetComponent<T> : 자신의 T타입 컴포넌트를 가져옴 
    //    rigid = GetComponent<Rigidbody>(); // 초기화

    //    //2. 속도 올리기 ( velocity : 현재 이동 속도 )
    //    // 실행하게 되면 알아서 속력이 정해지게 됨 
    //    rigid.velocity = Vector3.left;
    //    rigid.velocity = new Vector3(2, 4, 3);
    //}

    //// RigidBody 관련 코드는 FixedUpdate에 작성 
    //void FixedUpdate()
    //{
    //    rigid.velocity = new Vector3(2, 4, -1);
    //}


    // 3. 힘으로 밀기
    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        // AddForce(Vec) : Vec의 방향과 크기로 힘을 줌 
        // ForceMode : 힘을 주는 방식 (가속 , 무게 반영 )
        //rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SampleScene);
        }
    }
    private void FixedUpdate()
    {
        //if(Input.GetButtonDown("Jump"))
        //{
        //    // AddForce의 힘의 방향으로 계속 velocity가 증가 
        //    rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);

        //    Debug.Log(rigid.velocity);
        //}

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), // x축 
                                  0,                              // y축
                                  Input.GetAxisRaw("Vertical"));  // z축

        rigid.AddForce(vec/10f, ForceMode.Impulse);

        // 3. 회전력
        //rigid.AddTorque(Vector3.down);
    }


}
