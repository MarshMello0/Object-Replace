using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Harmony;
using System.Reflection;
using System.Linq;
using System.IO;

[ModTitle("ObjectReplace")]
[ModDescription("Replace objects from the game with your own!")]
[ModAuthor(". Marsh.Mello .")]
[ModVersion("1.1.0")]
[RaftVersion("1.03B")]
public class ObjectReplace : Mod
{
    void Start()
    {
        CreateCommands();
    }

    private void CreateCommands()
    {
        RConsole.registerCommand("or", "Use or help for help about object replace", "or", CheckCommand);
    }

    private void CheckCommand()
    {
        string lastCommand = RConsole.lastCommands.LastOrDefault();

        if (lastCommand.Split(' ').Length > 1)
        {
            if (lastCommand.Split(' ')[0] == "or")
            {
                if (lastCommand.Split(' ')[1] == "help")
                {
                    Help();
                }
                else if (lastCommand.Split(' ')[1] == "replace")
                {
                    if (lastCommand.Split(' ').Length >= 3)
                    {
                        Replace(lastCommand.Split(' ')[2], lastCommand.Split(' ')[3]);
                    }
                    else
                    {
                        Log("Error");
                        Log("or replace objectName filePath");
                    }
                    
                }
                else if (lastCommand.Split(' ')[1] == "type")
                {
                    Type();
                }
            }
        }
    }

    private void Help()
    {
        Log("<align=center><size=200%> Object Replace Help </size> </align>");
        Log("<align=center><size=150%>All commands<b><u> must </u></b>start with or </size> </align>");
        Log("");
        Log("replace");
        Log("replace requires two other args, type and folder");
        Log(" ");
        Log("type is the type of object to replace");
        Log("folder is the name of the folder which the model and texture is in");
        Log("");
        Log("help");
        Log("help displays this help messages");
        Log("");
        Log("type");
        Log("type will list the available  types of models which you can change");
    }

    private void Replace(string objectName, string path)
    {
        if (!File.Exists("mods/ObjectReplaceMod/" + path + "/model.obj"))
        {
            Log("The model.obj is missing in " + "mods/ObjectReplaceMod/" + path);
            return;
        }

        if (!File.Exists("mods/ObjectReplaceMod/" + path + "/texture.png"))
        {
            Log("The texture.png is missing in " + "mods/ObjectReplaceMod/" + path);
            return;
        }

        if (objectName == "shark")
        {
            foreach (Shark shark in UnityEngine.Object.FindObjectsOfType<Shark>())
            {
                Mesh mesh = FastObjImporter.Instance.ImportFile("mods/ObjectReplaceMod/" + path + "/model.obj");
                GameObject gameObject = new GameObject();
                gameObject.AddComponent<MeshRenderer>();
                gameObject.AddComponent<MeshFilter>().mesh = mesh;
                gameObject.AddComponent<MeshCollider>();
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture)LoadTexture("mods/ObjectReplaceMod/" + path + "/texture.png");
                gameObject.transform.parent = shark.transform;
                gameObject.transform.position = shark.transform.position;
                gameObject.transform.rotation = shark.transform.rotation;
                gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
                foreach (Renderer componentsInChild in shark.GetComponentsInChildren<SkinnedMeshRenderer>())
                    componentsInChild.enabled = false;
            }
            Success("Shark");
        }
        else if (objectName == "seagull")
        {
            foreach (Seagull item in UnityEngine.Object.FindObjectsOfType<Seagull>())
            {
                Mesh mesh = FastObjImporter.Instance.ImportFile("mods/ObjectReplaceMod/" + path + "/model.obj");
                GameObject gameObject = new GameObject();
                gameObject.AddComponent<MeshRenderer>();
                gameObject.AddComponent<MeshFilter>().mesh = mesh;
                gameObject.AddComponent<MeshCollider>();
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture)LoadTexture("mods/ObjectReplaceMod/" + path + "/texture.png");
                gameObject.transform.parent = item.transform;
                gameObject.transform.position = item.transform.position;
                gameObject.transform.rotation = item.transform.rotation;
                gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
                foreach (Renderer componentsInChild in item.GetComponentsInChildren<SkinnedMeshRenderer>())
                    componentsInChild.enabled = false;
            }
            Success("Seagull");
        }
        else if (objectName == "sail")
        {
            foreach (Sail item in UnityEngine.Object.FindObjectsOfType<Sail>())
            {
                Mesh mesh = FastObjImporter.Instance.ImportFile("mods/ObjectReplaceMod/" + path + "/model.obj");
                GameObject gameObject = new GameObject();
                gameObject.AddComponent<MeshRenderer>();
                gameObject.AddComponent<MeshFilter>().mesh = mesh;
                gameObject.AddComponent<MeshCollider>();
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture)LoadTexture("mods/ObjectReplaceMod/" + path + "/texture.png");
                gameObject.transform.parent = item.transform;
                gameObject.transform.position = item.transform.position;
                gameObject.transform.rotation = item.transform.rotation;
                gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
                foreach (Renderer componentsInChild in item.GetComponentsInChildren<SkinnedMeshRenderer>())
                    componentsInChild.enabled = false;
            }
            Success("Sail");
        }
        else if (objectName == "tree")
        {
            foreach (Tree item in UnityEngine.Object.FindObjectsOfType<Tree>())
            {
                Mesh mesh = FastObjImporter.Instance.ImportFile("mods/ObjectReplaceMod/" + path + "/model.obj");
                GameObject gameObject = new GameObject();
                gameObject.AddComponent<MeshRenderer>();
                gameObject.AddComponent<MeshFilter>().mesh = mesh;
                gameObject.AddComponent<MeshCollider>();
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture)LoadTexture("mods/ObjectReplaceMod/" + path + "/texture.png");
                gameObject.transform.parent = item.transform;
                gameObject.transform.position = item.transform.position;
                gameObject.transform.rotation = item.transform.rotation;
                gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
                foreach (Renderer componentsInChild in item.GetComponentsInChildren<SkinnedMeshRenderer>())
                    componentsInChild.enabled = false;
            }
            Success("Tree");
        }
        else if (objectName == "scarecrow")
        {
            foreach (Scarecrow item in UnityEngine.Object.FindObjectsOfType<Scarecrow>())
            {
                Mesh mesh = FastObjImporter.Instance.ImportFile("mods/ObjectReplaceMod/" + path + "/model.obj");
                GameObject gameObject = new GameObject();
                gameObject.AddComponent<MeshRenderer>();
                gameObject.AddComponent<MeshFilter>().mesh = mesh;
                gameObject.AddComponent<MeshCollider>();
                gameObject.GetComponent<Renderer>().material.mainTexture = (Texture)LoadTexture("mods/ObjectReplaceMod/" + path + "/texture.png");
                gameObject.transform.parent = item.transform;
                gameObject.transform.position = item.transform.position;
                gameObject.transform.rotation = item.transform.rotation;
                gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
                foreach (Renderer componentsInChild in item.GetComponentsInChildren<SkinnedMeshRenderer>())
                    componentsInChild.enabled = false;
            }
            Success("scarecrow");
        }

    }

    private Texture2D LoadTexture(string path)
    {
        Texture2D tex = (Texture2D)null;
        if (File.Exists(path))
        {
            byte[] data = File.ReadAllBytes(path);
            tex = new Texture2D(1024, 1024);
            tex.LoadImage(data);
        }
        return tex;
    }

    private void Success(string objectName)
    {
        Log("Replaced " + objectName + " successfully!");
    }

    private void Type()
    {
        Log("Current objects which you can change");
        Log("shark - this is the shark");
        Log("seagull - this is the seagull");
        Log("sail - this is the sail, but not the black stand for it");
        Log("tree - this is a part of the tree however I am not sure which part :P");

    }

    public void Log(string text)
    {
        RConsole.Log(text);
    }

    
}