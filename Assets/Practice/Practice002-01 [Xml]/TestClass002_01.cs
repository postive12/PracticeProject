using System;
namespace Practice.Practice002_01
{
    [Serializable]
    public class TestClass002_01
    {
        public int Id;
        public int Value;
        public bool Boolean;
        public CustomClass002_01[] CustomData;
    }
    [Serializable]
    public class CustomClass002_01
    {
        public int Code;
        public int Value;
    }
}
