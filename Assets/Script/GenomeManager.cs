using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenomeManager : MonoBehaviour
{
    public List<GameObject> creatures = new List<GameObject>();
    public int generationNum;

    public List<GameObject> firstGen()
    {
        List<GameObject> genOne = new List<GameObject>();
        return genOne;
    }

    public List<GameObject> nextGen()
    {
        List<GameObject> newGen = new List<GameObject>();
        return newGen;
    }

    public void rankCreatures()
    {
        List<GameObject> sorted = new List<GameObject>();

        creatures = sorted;
    }

    static int SortByScore(GameObject one, GameObject two)
    {
        //return one.GetComponent(typeof(Genome)).score.CompareTo(two.GetComponent(typeof(Genome)).score);
        return 1;
    }

    //creatures.Sort(SortByScore);
}
