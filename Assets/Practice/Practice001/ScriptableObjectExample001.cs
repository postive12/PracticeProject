using UnityEngine;

namespace Practice.Practice001
{
    //유니티에 메뉴 추가
    [CreateAssetMenu(fileName = "ScriptableObjectExample", menuName = "ScriptableObject/ScriptableObjectExample")]
    public class ScriptableObjectExample001 : ScriptableObject //ScriptableObject를 상속
    {
        public TestClass001[] TestInt;//저장할 데이터 변수
    }
}
