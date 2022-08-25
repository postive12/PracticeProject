using System;
using System.IO;
using Newtonsoft.Json;
using Practice.Practice002_00__Json_convert_Newtonsoft__;
using UnityEngine;

namespace Practice.Practice002_00
{
    public class JsonTest : MonoBehaviour
    {
        public TestClass00200[] TestVariable;
        public TextAsset JsonFile;//Variable that contains json data
        private void Start()
        {
            Print();
        }
        //Json data load func
        public void Read()
        {
            var result = JsonConvert.SerializeObject(TestVariable);//Convert to json
            Debug.Log(result);
        }
        //Json export func
        public void Print()
        {
            var result = JsonConvert.DeserializeObject<TestClass00200[]>(JsonFile.text);//convert to usable data
            foreach (var i in result)
            {
                Debug.Log($"Id : {i.Id}, Value : {i.Value}, Bool : {i.Boolean}");//Print data;
            }
            
        }
    }
}
