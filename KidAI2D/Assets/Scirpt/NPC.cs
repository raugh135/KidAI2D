using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour {
    [Header("對話")]
    public string SayStart = "嗨,我請你可以幫我嗎?";
    public string SayNotComplete = "你還沒找到十顆櫻桃呢...?";
    public string SayComplete = "感謝你幫我找到十顆櫻桃~";

    [Header("對話速度")]
    public float Speed = 1.5f;

    [Header("任務相關")]
    public bool Complete = false;
    public int CountPlayer = 0;
    public int CountFinish = 10;
}
	

