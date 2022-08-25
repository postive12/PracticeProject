using TMPro;
using UnityEngine;

namespace Practice.Practice004__UI_.Text
{
    public class TextScriptPractice004 : MonoBehaviour
    {
        public UnityEngine.UI.Text TextLegacy;
        public TextMeshProUGUI TextTMP;
        void Start()
        {
            TextLegacy.text = "이것이 레가시 텍스트 객체 입니다.";
            TextTMP.text = "이것이 텍스트 메쉬 프로 객체입니다.";
        }
    }
}
