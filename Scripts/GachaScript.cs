using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GachaScript : MonoBehaviour
{
    public Text buyListUI;
    
    public List<string> GachaList = new List<string>(){
        "����", "�����", "ġŲ", "�ҽ���", "�߸��ҽ���", "������", "������", "����", "�����̽�����", "�ߴٸ�",
        "���", "����", "�ٳ���", "����", "��", "��", "����", "���ξ���", "����", "������",
        "����", "�ϵ���", "����", "������ī", "����", "�丶��", "�����", "���", "����ݸ�", "ȣ��",
        "������â", "�߰�����", "������", "������̽�ũ��", "���ھ��̽�ũ��", "�밡��", "��¥�����ֵ���", "���ѿո���", "������", "�ſ�ո���" };

    public List<string> ShowList = new List<string>();

    //List<int> randNums = new List<int>();

    //public GameObject[] newItems;
    public NewItem[] newItems;

    public void ClearShowList()
    {
        ShowList.Clear();
    }


    public void Gacha()
    {
        int rand1 = Random.Range(0, GachaList.Count);
        int rand2 = Random.Range(0, GachaList.Count);
        int rand3 = Random.Range(0, GachaList.Count);
        int rand4 = Random.Range(0, GachaList.Count);
        int rand5 = Random.Range(0, GachaList.Count);
        int rand6 = Random.Range(0, GachaList.Count);
        int rand7 = Random.Range(0, GachaList.Count);
        int rand8 = Random.Range(0, GachaList.Count);
        int rand9 = Random.Range(0, GachaList.Count);
        int rand10 = Random.Range(0, GachaList.Count);
     
        if (ShowList.Count == 0)
        {
            ShowList.Add(GachaList[rand1]);
            ShowList.Add(GachaList[rand2]);
            ShowList.Add(GachaList[rand3]);
            ShowList.Add(GachaList[rand4]);
            ShowList.Add(GachaList[rand5]);
            ShowList.Add(GachaList[rand6]);
            ShowList.Add(GachaList[rand7]);
            ShowList.Add(GachaList[rand8]);
            ShowList.Add(GachaList[rand9]);
            ShowList.Add(GachaList[rand10]);
        }


        //buylistui.text = showlist[0] + "\n" + "\n" + showlist[1] + "\n" + "\n" + showlist[2] + "\n"
        //    + "\n" + showlist[3] + "\n" + "\n" + showlist[4] + "\n" + "\n" + showlist[5] + "\n" + "\n"
        //    + showlist[6] + "\n" + "\n" + showlist[7] + "\n" + "\n" + showlist[8] + "\n" + "\n" + showlist[9];

        buyListUI.text = ShowList[0] + "\n" + "\n" + ShowList[1] +"\n" + "\n" + ShowList[2] + "\n" + "\n"
         + ShowList[3] + "\n" + "\n" + ShowList[4] + "\n" + "\n" + ShowList[5] + "\n" + "\n"
        + ShowList[6] + "\n" + "\n" + ShowList[7] + "\n" + "\n" + ShowList[8] + "\n" + "\n" + ShowList[9];
    }

    int numCheck;

    public void Count()
    {
        for (int i = 0; i < newItems.Length; i++)
        {
            if (newItems[i].gameObject.activeSelf == false)
            {
                for (int j = 0; j < ShowList.Count; j++)
                {
                    if (ShowList[j] == newItems[i].itemName)
                    {
                        numCheck++;
                    }
                }
            }
        }

        if (numCheck >= 10)
        {
            //Debug.Log("Mission Clear!");
            SceneManager.LoadScene("Success");
        }
        else
        {
            //Debug.Log("Mission Fail..");
            SceneManager.LoadScene("Ending");
        }
    }
}