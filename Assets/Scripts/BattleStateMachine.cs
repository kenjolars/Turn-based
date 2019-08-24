using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour
{
    public enum PerformAction
    {
        WAIT,
        TAKEACTION,
        PERFORMACTION
    }

    public PerformAction battleStates;

    public List<HandleTurn> PerformList = new List<HandleTurn>();

    public List<GameObject> HeroInBattle = new List<GameObject>();
    public List<GameObject> VillainInBattle = new List<GameObject>();

    void Start()
    {
        battleStates = PerformAction.WAIT;
        VillainInBattle.AddRange(GameObject.FindGameObjectsWithTag("Villain"));
        HeroInBattle.AddRange(GameObject.FindGameObjectsWithTag("Hero"));
    }

    void Update()
    {
        switch(battleStates)
        {
            case (PerformAction.WAIT):

            break;

            case (PerformAction.TAKEACTION):

            break;

            case (PerformAction.PERFORMACTION):

            break;
        }
    }

    public void CollectActions(HandleTurn input)
    {
        PerformList.Add(input);
    }
}
