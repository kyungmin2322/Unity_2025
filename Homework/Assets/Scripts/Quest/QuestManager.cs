using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Quest quest;

    Dictionary<int, Quest> questList;

    void Awake()
    {
        questList = new Dictionary<int, Quest>();
        GenerateData();
    }

    void GenerateData()
    {
        questList.Add(quest.퀘스트번호, quest);
    }

    public int GetQuestTalkIndex(int id)
    {
        return quest.퀘스트번호;
    }
}
