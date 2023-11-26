using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Box> boxes;

    private int index;

    private void Awake()
    {
        index = 0;
    }

    public void TriggerBoxAnimator(string type)
    {

        boxes[index].TriggerAnim(type);

        index++;

        CheckFinishLevel();
    }

    public void CheckFinishLevel()
    {
        foreach(Box box in boxes)
        {
            if (!box.isTriggerd) return;
        }

        GameManager.Instance.CheckLevelUp();
    }


    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
