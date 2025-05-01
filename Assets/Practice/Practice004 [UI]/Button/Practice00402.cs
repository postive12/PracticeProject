using UnityEngine;
using UnityEngine.UI;

namespace Practice.Practice004
{
    public class Practice00402 : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
            
        }
        private void OnClick()
        {
            Debug.Log("Link by code");
        }
    }
}