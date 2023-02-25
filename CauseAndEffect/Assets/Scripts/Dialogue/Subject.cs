using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Subject", menuName = "Create Subject")]

public class Subject : ScriptableObject
{
    public string SubjectName;
    public Color BorderColor;
    public Color InnerColor;
    public Sprite SubjectFace;

}
