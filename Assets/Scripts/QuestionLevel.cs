using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLevel : MonoBehaviour
{
    Level level;
    LoadScene loadscene;
    [SerializeField] public int questionableBlocks;
    public void Start()
    {
        level = FindObjectOfType<Level>();
        loadscene = FindObjectOfType<LoadScene>();
    }
    public void CountQuestionableBlocks()
    {
        questionableBlocks++;
    }
    public void QuestionableBlockDestroyed()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion1Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed1()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion2Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed2()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion3Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed3()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion4Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed4()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion5Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed5()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion6Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed6()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion7Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed7()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion8Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed8()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion9Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed9()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion10Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed10()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion11Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed11()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion12Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed12()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion13Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed13()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion14Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed14()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion15Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed15()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion16Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed16()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion17Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed17()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion18Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed18()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion19Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed19()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion20Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed20()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion21Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed21()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion22Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed22()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion23Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed23()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion24Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed24()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion25Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed25()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion26Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed26()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion27Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed27()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion28Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed28()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion29Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed29()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion30Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed30()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion31Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed31()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion32Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed32()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion33Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed33()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion34Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed34()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion35Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed35()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion36Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed36()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion37Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed37()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion38Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed38()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion39Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed39()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion40Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed40()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion41Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed41()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion42Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed42()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion43Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed43()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion44Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed44()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion45Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed45()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion46Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed46()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion47Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed47()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion48Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed48()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion49Scene();
        questionableBlocks--;
    }
    public void QuestionableBlockDestroyed49()
    {
        FindObjectOfType<Ball>().hasStarted = false;
        FindObjectOfType<Ball>().onDoubleClick = true;
        loadscene.loadQuestion50Scene();
        questionableBlocks--;
    }
}
