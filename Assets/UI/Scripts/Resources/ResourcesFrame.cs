using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ResourcesFrame : MonoBehaviour
    {
        public static ResourcesFrame instance;
        public Statistics.Statistics statistics;

        private void Awake() 
        {
            instance = this;       
        }
        void Start()
        {
            statistics = GameObject.Find("PlayerStatistics").GetComponent<Statistics.Statistics>();
        }

        void Update()
        {
            gameObject.transform.GetChild(0).GetComponentInChildren<TMPro.TextMeshProUGUI>().text = statistics.money.ToString();
            gameObject.transform.GetChild(1).GetComponentInChildren<TMPro.TextMeshProUGUI>().text = statistics.units.ToString();
            gameObject.transform.GetChild(2).GetComponentInChildren<TMPro.TextMeshProUGUI>().text = statistics.TimerString();
        }
        
    }
}


