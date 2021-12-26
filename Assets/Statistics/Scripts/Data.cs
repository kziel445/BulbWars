using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Statistics
{
    public class Data : MonoBehaviour
    {
        public List<DataRecord> datas = new List<DataRecord>();
        private void Awake() 
        {
            DontDestroyOnLoad(transform.gameObject);   
        }
        public int moneyCollected;
        public int unitsRecruted = 0;
        public float timer = 0.0f;
        public bool isVictory;

        public string TimerString(float timer)
        {
            return $"{Mathf.FloorToInt(timer/60)}:{Mathf.FloorToInt(timer % 60).ToString("00")}".ToString();
        }
    }
}

