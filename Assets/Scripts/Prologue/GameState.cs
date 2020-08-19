using UnityEngine;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField] Text TitleText = null;
    [SerializeField] Text GameText = null;
    [SerializeField] Chapters CurrentChapter = null;
    [SerializeField] Image image = null;
    private Chapters CurrentGameState = null;

    // Start is called before the first frame update
    void Start()
    {
        CurrentGameState = CurrentChapter;
        UpdateGameElements();   
    }

    private void Update()
    {
        if (CurrentGameState.name is "Episode 000")
            Debug.Log("Current chapter is the main screen.");
        else
            Debug.Log("Testing...");
    }

    private void UpdateGameElements()
    {
        CurrentChapter = CurrentGameState;
        TitleText.text = CurrentChapter.ChapterTitle;
        GameText.text = CurrentChapter.ChapterText;
        image.sprite = CurrentChapter.ChapterPicture;
    }

    public void OptionOne()
    {
        CurrentGameState = CurrentChapter.OptionOneButton;
        UpdateGameElements();
    }

    public void OptionTwo()
    {
        if (CurrentGameState.name is "Episode 001")
        {
            Application.Quit();
        }
        else
        {
        CurrentGameState = CurrentGameState.OptionTwoButton;
        UpdateGameElements();
        }
    }
}
