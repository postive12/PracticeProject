using System;

namespace Practice.Practice002_01__Xml_
{
    [Serializable]
    public class TestClass00201
    {
        public int Id;
        public int Value;
        public bool Boolean;
        public CustomClass00201[] CustomData;
    }
    [Serializable]
    public class CustomClass00201
    {
        public int Code;
        public int Value;
    }
}
