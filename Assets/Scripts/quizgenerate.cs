using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Question
{
    public Sprite QuestionSprite;
    public Sprite AnsuereSprite1;
    public Sprite AnsuereSprite2;
    public Sprite AnsuereSprite3;

    public int CorrectAnserIndex;

}

public class quizgenerate : MonoBehaviour
{
    public enum GameState
    {
        //NOTPLAYING
        //PLAYING;
        //SHOWINGANSWERS;
        //FINISH;
    }

    public Question[] Questions;
    public Image QuestionsImage;
    public Image answer1image;
    public Image answer2image;
    public Image answer3image;

    public GameObject CorrectAnswers13;
    public GameObject CorrectAnswers23;
    public GameObject CorrectAnswers33;


    public Text TimerText;
    public float timer;
    private float _timer;

    public GameObject car;
    public float carspeed;
    public GameObject[] Points;
    public int NumQuestions=-1;
    public int NumCoreectAnsewrs;


    public GameObject ingameScreen;
    public GameObject finishScreen;

    public Image Price;
    public Image ResultImage;

    public Sprite[] Prices;
    public Sprite[] ResultSpraices;
    // Start is called before the first frame update
    void Start()
    {
        _timer = timer;
        //GenerateQuiz();
    }

    // Update is called once per frame
    void Update()
    {
        //if (NumQuestions >= 3)
        //{
        //    Price.sprite = Prices[NumCoreectAnsewrs];
        //    ResultImage.sprite = ResultSpraices[NumCoreectAnsewrs];
        //    ingameScreen.SetActive(false);
        //    finishScreen.SetActive(true);
        //    State = GameState.FINISH;
        //}
        //if(State == GameState.PLAYING)
        //{

        //}
    }



    public void CompareAnswer(int UseAnswer)
    {
        //State = GameState.SHOWUNANSWERS;
        //if (UseAnswer == CurrentQuestions.CorrectAnswerIndex)
        //{
        //    NumCoreectAnsewrs++;
        //    print(message: "CORRECT ANSWERS");
        //}
        //else
        //{
        //    print(message: "INCORRECT ANSWERS");
        //}
        //StartCoroutine(StartCoroutine());
    }
}
