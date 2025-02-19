using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000 + 10, new string[] { "안녕하세요.:1", "무슨 일을 도와드릴까요?:3" });
        talkData.Add(2000 + 20, new string[] { "어서오세요.:0" });
        talkData.Add(3000 + 30, new string[] { "마지막 퀘스트입니다.:3" });

        talkData.Add(100, new string[] { "밤송이다!:2" });

        portraitData.Add(10 + 0, portraitArr[0]);
        portraitData.Add(10 + 1, portraitArr[1]);
        portraitData.Add(10 + 2, portraitArr[2]);
        portraitData.Add(10 + 3, portraitArr[3]);
        portraitData.Add(20 + 0, portraitArr[0]);
        portraitData.Add(20 + 1, portraitArr[1]);
        portraitData.Add(20 + 2, portraitArr[2]);
        portraitData.Add(20 + 3, portraitArr[3]);
        portraitData.Add(30 + 0, portraitArr[0]);
        portraitData.Add(30 + 1, portraitArr[1]);
        portraitData.Add(30 + 2, portraitArr[2]);
        portraitData.Add(30 + 3, portraitArr[3]);
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length) return null;
        else return talkData[id][talkIndex];
    }
}
