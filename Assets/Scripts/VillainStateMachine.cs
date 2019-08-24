using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillainStateMachine : MonoBehaviour
{
    //variables
    private BattleStateMachine BSM;
    public BaseVillain villain;

    public enum TurnState
    {
        PROCESSING,
        CHOOSEACTION,
        WAITING,
        ACTION,
        DEAD
    }

    public TurnState currentState;
    //progressbar
    private float cur_cooldown = 0f;
    private float max_cooldown = 5f;
    //this gameobject
    private Vector3 startposition;

    void Start()
    {
        currentState = TurnState.PROCESSING;
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();
        startposition = transform.position;
    }

    void Update()
    {
        //Debug.Log(currentState);
        switch (currentState)
        {
            case (TurnState.PROCESSING):
                UpgradeProgressBar();

                break;

            case (TurnState.CHOOSEACTION):
                ChooseAction();
                currentState = TurnState.WAITING;

                break;

            case (TurnState.WAITING):

                break;

            case (TurnState.ACTION):

                break;

            case (TurnState.DEAD):

                break;

        }

    }

    void UpgradeProgressBar()
    {
        cur_cooldown = cur_cooldown + Time.deltaTime;
        if (cur_cooldown >= max_cooldown)
        {
            currentState = TurnState.CHOOSEACTION;
        }
    }

    void ChooseAction()
    {
        HandleTurn myAttack = new HandleTurn();
        myAttack.Attacker = villain.name;
        myAttack.AttackerGameObject = this.gameObject;
        myAttack.AttackerTarget = BSM.HeroInBattle[Random.Range(0, BSM.HeroInBattle.Count)];
        BSM.CollectActions(myAttack);
    }
}
