using UnityEngine;

namespace Practice.Practice001
{
    //Add menu
    [CreateAssetMenu(fileName = "ScriptableObjectExample", menuName = "ScriptableObject/ScriptableObjectExample")]
    public class ScriptableObjectExample001 : ScriptableObject //Inherit scriptable object
    {
        public TestClass001[] TestVariable;//Variable that contains data
    }
}
