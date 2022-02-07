using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    public List<string> FoodList = new List<string>(){
        "����", "���", "ġŲ", "�ҽ���", "�߸��ҽ���", "������", "������", "����", "�����̽�����", "�ߴٸ�",
        "���", "����", "�ٳ���", "����", "��", "��", "����", "���ξ���", "����", "������",
        "����", "�ϵ���", "����", "������ī", "����", "�丶��", "����", "���", "����ݸ�", "ȣ��",
        "������â", "�߰�����", "������", "������̽�ũ��", "���ھ��̽�ũ��", "�밡��", "��¥�����ֵ���", "���ѿո���", "������", "�ſ�ո���" };

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
