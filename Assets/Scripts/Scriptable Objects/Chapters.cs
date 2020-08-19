using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Episode ", menuName = "ScriptableObjects/States", order = 1)]
public class Chapters : ScriptableObject
{
    public string ChapterTitle = null;
    [TextArea(12, 12)] public string ChapterText = null;
    public Chapters OptionOneButton = null;
    public Chapters OptionTwoButton = null;
    public Sprite ChapterPicture = null;
}
