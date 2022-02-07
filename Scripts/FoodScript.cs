using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    public List<string> FoodList = new List<string>(){
        "생선", "고기", "치킨", "소시지", "잘린소시지", "구운고기", "베이컨", "연어", "슬라이스연어", "닭다리",
        "사과", "포도", "바나나", "레몬", "귤", "감", "딸기", "파인애플", "수박", "복숭아",
        "양파", "완두콩", "버섯", "파프리카", "가지", "토마토", "배추", "당근", "브로콜리", "호박",
        "돼지막창", "닭가슴살", "사골곰탕", "딸기아이스크림", "초코아이스크림", "용가리", "모짜렐라핫도그", "순한왕만두", "떡갈비", "매운왕만두" };

    public Text textSearchBar;

    public void Food()
    {
        for (int i = 0; i < 2; i++)
        {
            int rand = Random.Range(0, FoodList.Count);
            textSearchBar.text = "1. " + FoodList[rand] + "2. " + FoodList[rand];
            //print(FoodList[rand]);
            FoodList.RemoveAt(rand);
        }
    }
}
