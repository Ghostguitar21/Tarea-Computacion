using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameControler : MonoBehaviour

{
    List<PreguntasMultiples> preguntasMultiples = new List<PreguntasMultiples>();
    public string fileName = "ArchivoPregunta.txt";
    public TextMeshProUGUI pregunta;
    public TextMeshProUGUI[] opciones;
    public int preguntaActualIndex = 0;

    void Start()
    {
        LoadPreguntasMultiples();

        if (preguntasMultiples.Count > 0)
        {
            MostrarPregunta(0);
        }
    }


    void Update()
    {

    }
    public void LoadPreguntasMultiples()
    {

        string filePath = Path.Combine(Application.dataPath, "Game", "StreamingAssets", fileName);

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)

        {
            string[] pregunta = line.Split('-');

            if (pregunta.Length >= 8)
            {
                PreguntasMultiples nuevaPregunta = new PreguntasMultiples(
                pregunta[0],
                pregunta[1],
                pregunta[2],
                pregunta[3],
                pregunta[4],
                pregunta[5],
                pregunta[6],
                pregunta[7]
                );

                preguntasMultiples.Add(nuevaPregunta);
            }

        }
    }

    public void MostrarPregunta(int index)
    {
        PreguntasMultiples p = preguntasMultiples[index];
        pregunta.text = p.Question + p.Versiculo + p.Dificultad;
        opciones[0].text = p.Question1;
        opciones[1].text = p.Question2;
        opciones[2].text = p.Question3;
        opciones[3].text = p.Question4;

    }
    public void Verificar(int botonPresionado)
    {
        PreguntasMultiples p = preguntasMultiples[preguntaActualIndex];
        string respuesta = "";

        switch (botonPresionado)
        {
            case 0: respuesta = p.Question1; break;
            case 1: respuesta = p.Question2; break;
            case 2: respuesta = p.Question3; break;
            case 3: respuesta = p.Question4; break;


        }

        if (respuesta == p.Answer)
        {
            Debug.Log("Correcto");
            siguiente();
        }
        else {
            Debug.Log("Incorrecto");
        }
    }
    void siguiente()
    {
        preguntaActualIndex++;
        if (preguntaActualIndex < preguntasMultiples.Count)
        {
            MostrarPregunta(preguntaActualIndex);
        }
        else
        {
            pregunta.text = "Terminaste";
        }
    }

}

