using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace Practice.Practice002_01__Xml_
{
    public class XmlTest : MonoBehaviour
    {
        public TextAsset XmlFile;
        public string Path;
        public TestClass00201 Data;

        public void ExportXmlData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TestClass00201));//TestClass002_01 데이터 타입으로 생성
            FileStream fileStream = new FileStream(Path + "/" + "data.xml", FileMode.Create);//생성한 데이터를 기록할 파일 생성
            serializer.Serialize(fileStream, Data);//데이터 변환 후 파일 스트림을 이용해 출력
            fileStream.Close();
            Debug.Log("File exported.");
        }

        public void ImportXmlData()
        {
            StringReader reader = new StringReader(XmlFile.text);//스트림 리터를 통해 텍스트 불러오기
            XmlSerializer serializer = new XmlSerializer(typeof(TestClass00201));//TestClass002_01 데이터 타입으로 생성
            Data = serializer.Deserialize(reader) as TestClass00201;//데이터 변환 후 Data 변수에 기입
        }
    }
}
