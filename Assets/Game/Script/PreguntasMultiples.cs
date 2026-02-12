using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class PreguntasMultiples 
{
    [SerializeField] private string question;
    [SerializeField] private string question1;
    [SerializeField] private string question2;
    [SerializeField] private string question3;
    [SerializeField] private string question4;
    [SerializeField] private string answer;
    [SerializeField] private string versiculo;
    [SerializeField] private string dificultad;
    

    public PreguntasMultiples()
    {
    }

    public PreguntasMultiples(string question, string question1, string question2, string question3, string question4, string answer, string versiculo, string dificultad)
    {
        this.question = question;
        this.question1 = question1;
        this.question2 = question2;
        this.question3 = question3;
        this.question4 = question4;
        this.answer = answer;
        this.versiculo = versiculo;
        this.dificultad = dificultad;
    }

    public string Question { get => question; set => question = value; }
    public string Question1 { get => question1; set => question1 = value; }
    public string Question2 { get => question2; set => question2 = value; }
    public string Question3 { get => question3; set => question3 = value; }
    public string Question4 { get => question4; set => question4 = value; }
    public string Answer { get => answer; set => answer = value; }
    public string Versiculo { get => versiculo; set => versiculo = value; }
    public string Dificultad { get => dificultad; set => dificultad = value; }
}
