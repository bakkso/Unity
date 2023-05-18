using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 만약 저장해도 유니티 내에서 변화가 없다면 스크립트가 잘 매칭되어있는지 확인하기 
public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update() //Update()는 1초에 60번씩 반복
    {

        // Vector3에서 기본적으로 제공하는 4가지 함수

        //1. MoveTowards( 현재위치, 목표위치 , 속도 ) : 등속 이동
        transform.position =
               Vector3.MoveTowards(transform.position, target, 2f);



        //2. SmoothDamp ( 현재위치 , 목표위치 , 참조속도 , 속도 ) : 부드러운 감속 이동 
        Vector3 velo = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position,
               target, ref velo, 0.1f); // 마지막 매개변수에 반비례(적게줄수록)하여 속도 증가 



        //3. Lerp : 선형 보간 , SmoothDamp보다 감속시간이 김 
        //마지막 매개변수에 비례하여 속도 증가 ( 최대값 1 , 0보다 커야함)
        transform.position =
        Vector3.Lerp(transform.position, target, 1f);



        //4. SLerp ( 구면 선형 보간 , 호를 그리며 이동 )
        //마지막 매개변수에 비례하여 속도 증가 ( 최대값 1 , 0보다 커야함)
        transform.position =
               Vector3.Slerp(transform.position, target, 0.05f);
    }

}
