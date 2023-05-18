using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour //MonoBehaviour은 무엇인가?
{
    // 전역변수 선언
    /*
    string title = "전설의";
    string playerName = "나검사";
    float strength = 15.5f;
    int exp = 1500;
    */
    int health = 30; // 전역변수 ( 혹은 멤버변수)
    int level = 5;
    /*
    int mana = 25;
    bool isFulllevel = false;
    */

    void Start() //게임이 실행될때 아래 함수가 실행된 이유는 Start()함수안에 있었기 떄문
    {

        Debug.Log("Hello Unity!");
        // 1. 변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "검사";
        bool isFulllevel = false;


        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };

        int[] monsterlevel = new int[3]; // new int[] 대괄호안에는 배열의 크기를 넣어줌
        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        // 리스트를 선언하고 초기화하는 방법
        List<string> items = new List<string>(); // 제네릭 : <> 안에는 리스트의 자료형을 정해줘야
        items.Add("생명물약 30");
        items.Add("마나물약 30");


        //리스트와 배열의 차이점 : 리스트는 안에 들어있는 내용을 삭제할 수 있다
        //items.RemoveAt(0); // 괄호()안에 리스트의 번지수를 넣어줌

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]); // 크기를 벗어난 탐색은 오류 : 위에서 items[0]에 해당되는 내용을 지웠기때문
        Debug.Log(items[1]);

        //3. 연산자
        // 사칙연/
        int exp = 1500; //exp : 경험치
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는 ?");
        Debug.Log(nextExp);
        Debug.Log("용사의 총 경험치는?");

        // 문자열 연산자
        string title = "전설의";
        Debug.Log("용사의 이름은 ?");
        Debug.Log(title + " " + playerName); // 변수와 변수 사이에 + 기호만 넣어주면 됨

        // 비교 연산자 bool
        int fulllevel = 99;
        isFulllevel = level == fulllevel;
        Debug.Log("용사는 만렙입니까 ?" + isFulllevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20; // && 는 and의 의미
        //bool isBadCondition = health <= 50 || mana <= 20; // || 는 or의 의미
        Debug.Log("용사의 상태가 나쁩니까 ?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음"; // ? 앞에는 bool 값 , : 앞에는 true 일때 나올 수 있는 값 , : 뒤에는 flase 일때 나올 수 있는 
        Debug.Log("용사의 상태가 나쁩니까 ?" + condition);

        //4.키워드
        //int float string bool new List

        //5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        switch (monsters[0])
        {
            case "슬라임":
            case "사막뱀": // 사막뱀 전용 로직을 따로 작성할 필요 x, 같은 로직이라면 같이 작성해줘도 ok
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("대형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default: // 모든 case에 해당하지 않을 때 실행
                Debug.Log("??? 몬스터가 출현!");
                break;
        }
        //6.반복문
        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
            {
                Debug.Log("사망하였습니다");
            }


            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }
        //for ( 연산될 변수; 조건; 연산) {로직}
        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        //그룹형 변수 길이: .Length(배열), .Count(리스트)
        for (int index = 0; index < monsters.Length; index++) //for문은 그룹형 변수(monsters)와의 조합이 가능 -> monsters.Length 로 사용가 
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters) // foreach : for의 그룹형변수 탐색 특화 / 직접 그룹형 변수 안에 있는 아이템을 하나씩 꺼내어 직접 사용하는 방식
        {
            Debug.Log("이 지역에 있을까요 몬스터 : " + monster);
        }

        //health = Heal(health); //함수의 매개변수 이름은 실제 집어넣을 변수의 이름과 굳이 같을 필요는 없음

        Heal();
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterlevel[index]));
        }

        //8.클래스
        //클래스를 하나의 변수로 만들어줌. 
        Actor player = new Actor(); // 인스턴스 : 정의된 클래스를 변수 초기화로 실체화
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());


        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");

    }
    // 7.함수 (메소드)
    /* int Heal(int currentHealth)  // -함수가 반환하는 자료형-함수이름-함수가 받을 변수 // int : 반환하는 값 필요
    {
        currentHealth += 10;
        Debug.Log("힘을 받았습니다. " + currentHealth);
        return currentHealth; //함수앞에 반환하는 타입이 있다면 return 키워드는 꼭 필요함 
    } */
    void Heal() // void : 반환하는 값이 없을 때 사용
    {
        health += 10; //Health는 현재 지역변수임 Start()와는 관련이 없는 Heal()만의 지역변수 -> health를 전역변수로 Start()로 선언해줌
        Debug.Log("힘을 받았습니다. " + health);
    }
    string Battle(int monsterlevel)
    {
        string result;
        if (level >= monsterlevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;

    }

}



/*int main() // 이 c++ 코드때문에 오류가 났음 
{
    for (int i = 0; i<5; i++) {
    cout<<i<<endl;
    }

int arr[5][3]={{1,2,3},{1,2,3},{1,2,3},{1,2,3},{1,2,3}};
return 0;
}*/

