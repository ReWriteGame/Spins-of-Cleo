using UnityEngine;

[CreateAssetMenu(fileName = "PrefabListData", menuName = "ScriptableObject/Bonus", order = 1)]
public class Bonus : ScriptableObject
{
    [SerializeField] private int value = 0;

    public int Value => value;

    [SerializeField] private int lastGetTime = 0;

    public int LastGetTime => lastGetTime;

    public void SetLastTime(int value)
    {
        lastGetTime = value;
    }

    public void AddScore(int value)
    {
        this.value += value;
    }


}

