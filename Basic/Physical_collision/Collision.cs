using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    // 오브젝트의 재질 접근은 MeshRenderer를 통해서 
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
    // Collision : 충돌 정보 클래스
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "myball1")
            //Color(0,0,0) -> black, Color(1,1,1) -> white
            mat.color = new Color(0, 0, 0);
    }
    // CollisionStay : 물리적 충돌이 진행될 때 호출되는 함ㅡ
    private void OnCollisionStay(Collision collision)
    {

    }
    // CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함
    private void OnCollisionExit(Collision collision)
    {

    }
}
