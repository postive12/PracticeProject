using System.IO;
using UnityEngine;

public class FileIOTest : MonoBehaviour
{
    private void Start()
    {
        Write(Application.persistentDataPath+"\\test.dat");
    }
    private void Write(string path)
    {
        File.WriteAllText(path,"this is text");//Write text on path
    }
    private void Read(string path)
    {
        var fileInfo = new FileInfo(path);
        if (!fileInfo.Exists) {//Check file
            throw new UnityException("File not found.");
        }
        var result = File.ReadAllText(path);//Read text from path
        Debug.Log(result);
    }
}
