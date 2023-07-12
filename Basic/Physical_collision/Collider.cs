using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Myball : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);

    }

    // TriggerStay : 콜라이더가 계속 충돌하고 있을 때 호출
    // Collision X, Collider O -> OnTrigger는 물리적인 충돌이 X, 단순히 콜라이더가 겹쳤냐의 차이 (물리적인 충돌이 아니기 때문에 충돌정보자체가 없다)
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }
}
