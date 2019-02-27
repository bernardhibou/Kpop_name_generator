using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class NameGenerator : MonoBehaviour
{
    public List<string> firstNames;    
    
// Start is called before the first frame update
void Start()
{
    //Creating list
    firstNames = new List<string>();

    //Creating file path
    string filePathFirstName = "Assets/Resources/firstNames.txt";
    string filePathNickName = "Assets/Resources/nickNames.txt";
    string filePathLastName = "Assets/Resources/lastNames.txt";
   
    //Calling function readTextFile
    //We're giving it filePath in the brackets, and that's where it'll read the names from
    readTextFile(filePathFirstName);
    readTextFile(filePathNickName);
    readTextFile(filePathLastName);
    

void readTextFile(string file_path)
    {
        StreamReader fileReader = new StreamReader(file_path);
            firstNames.Clear();

        //While the fileReader hasn't finished reading the whole file
        while (!fileReader.EndOfStream)
        {
            //Create a temporary stream: tempString
            //Add the value of tempString to the list: firstNames;
            string readingLine = fileReader.ReadLine();
            firstNames.Add(readingLine);
        }

        //Close the file after reading
        fileReader.Close();

        //Printing out each element of the firstNames list
        string nameComp = firstNames[Random.Range(0, firstNames.Count)];
        //for (int i = 0; i < firstNames.Count; i++)
        
        Debug.Log(nameComp);
    }
}




    
    // Update is called once per frame
void Update()
    {
        
    }
}
