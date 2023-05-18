using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        // Time.deltaTime 사용방법 - 이전 프레임의 완료까지 걸린 시간 
        // deltaTime 값은 프레임이 적으면 크, 프레임이 많으면 작

        // Translate : 벡터에 곱하기 - transform.Translate(Vec * Time.deltaTime);
        // Vector 함수 : 시간 매개변수에 곱하기 - Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
        Vector3 vec = new Vector3(
                Input.GetAxisRaw("Horizontal") * Time.deltaTime,
                Input.GetAxisRaw("Vertical") * Time.deltaTime);
        // -> deltaTime으로 인해 10프레임이든, 60프레임이든 상관없이 동일하게 나옴

        transform.Translate(vec);
    }

}