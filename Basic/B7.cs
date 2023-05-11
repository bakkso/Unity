using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour {

        private void Update() {
        if (Input.anyKeyDown) { 
               //input 게임 내 입력을 관리하는 클래스, anyKeyDown : 아무 입력을 최초로 받을 때 true
               Debug.Log("플레이어가 아무 키를 눌렀습니다 ");
        }

        if (Input.GetKeyDown(KeyCode.Return)) { 
               //GetKeyDown은 누르는 순
               //Return 은 " 엔터 "를 의미 // Escape은 "esc"를 의미 
               Debug.Log("아이템을 구입하였습니다 ");
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
               //GetKey는 누르고 있을때
               //키보드 버튼 입력을 받으면 true //방향키는 Arrow

               Debug.Log("왼쪽으로 이동중 ");
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
               Debug.Log("오른쪽으로 이동중");
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
               Debug.Log("왼쪽 이동을 멈추었습니다. ");
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
               //GetKeyUp은 누르고 있던 것을 떼었을 때 
               Debug.Log("오른쪽 이동을 멈추었습니다 .");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
               for (int i = 0; i < 10; i++) {
                       Debug.Log("왼쪽으로 이동;");
               }
        }
        if (Input.GetMouseButtonDown(2)) { //0은 왼쪽마우스 1은 오른쪽 마우
               Debug.Log("미사일 발사 !");
        }
        if (Input.GetMouseButton(0)) {
               Debug.Log("미사일 모으는 중 ...");
        }
        if (Input.GetMouseButtonUp(1)) {
               Debug.Log("슈퍼 미사일 발사 !! ");
        }
        if (Input.anyKeyDown) { //0은 왼쪽마우스 1은 오른쪽 마우
               Debug.Log("플레이어가 아무 키를 눌렀습니다 ");
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
               Debug.Log("점프 ! ");
        }
        if (Input.GetButtonDown("SuperFire")) {
               Debug.Log("필살Horizontal !");
        }
        if (Input.GetButton("Horizontal")) {
               Debug.Log("횡 이동 중일까용 ... " 
                       + Input.GetAxis("Horizontal"));
                 // GetAxis 수평 , 수직 버튼 입력 받으면 float로 반환 
        }
        if (Input.GetButton("Horizontal")) {
               Debug.Log("횡 이동 중 ... "
                       + Input.GetAxisRaw("Horizontal"));
               // GetAxisRaw 왼쪽은 -1, 오른쪽은 1로 출력
               // 오브젝트는 변수 transform을 항상 가지고 있음 
        }
        if (Input.GetButtonUp("Fire1")) {
               Debug.Log("슈퍼 점프 !! ");
        }
        if (Input.GetButton("Vertical")) {
               Debug.Log("종 이동 중 ... "
                       + Input.GetAxisRaw("Vertical"));
               //
        } 

        }
        private void Start() { //transform 오브젝트 형태에 대한 기본 컴포넌트
               //Transform tr = 이렇게 일부러 transform 변수를 만들어줄 필요 없음 1:1 관계이기때문에
               //오브젝트는 변수 transform을 항상 가지고 있음
                       //int number = 4; 스칼라값 
               Vector3 vec = new Vector3(5 ,5 ,5); // 벡터값 // ( , , , )위치로 이동하는 것이 아닌 그 값만큼 + 되는것임
               transform.Translate(vec); //Vector(차원)+숫자 -> Vector3 는 3차원
               // Translate 는 이동한다는 뜻 ( ) 만큼 이동시켜주세요 ~

        }
        private void Update() { // Update()는 1초에 60회씩 동작
                Vector3 vec = new Vector3(
                        Input.GetAxisRaw("Horizontal"), 
                        Input.GetAxisRaw("Vertical"), 0);
                transform.Translate(vec);
        }
}  