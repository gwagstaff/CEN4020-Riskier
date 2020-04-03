using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState{START, PLAYERTURN, ENEMYTURN, WON, LOST }


public class BattleSystem : MonoBehaviour
{
    public GameObject player1Prefab;
    public GameObject player2Prefab;
    public GameObject player3Prefab;
    
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject enemy3Prefab;

    public Transform player1BattleStation;
    public Transform player2BattleStation;
    public Transform player3BattleStation;

    public Transform enemy1BattleStation;
    public Transform enemy2BattleStation;
    public Transform enemy3BattleStation;

    Unit player1Unit;
    Unit player2Unit;
    Unit player3Unit;

    Unit enemy1Unit;
    Unit enemy2Unit;
    Unit enemy3Unit;

    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        setupBattle();
    }

    void setupBattle(){
        GameObject player1Go = Instantiate(player1Prefab, player1BattleStation);
        GameObject player2Go =Instantiate(player2Prefab, player2BattleStation);
        GameObject player3Go =Instantiate(player3Prefab, player3BattleStation);

        player1Go.GetComponent<Unit>();
        player2Go.GetComponent<Unit>();
        player3Go.GetComponent<Unit>();
        
        GameObject enemy1Go = Instantiate(enemy1Prefab, enemy1BattleStation);
        GameObject enemy2Go =Instantiate(enemy2Prefab, enemy2BattleStation);
        GameObject enemy3Go =Instantiate(enemy3Prefab, enemy3BattleStation);

        enemy1Go.GetComponent<Unit>();
        enemy2Go.GetComponent<Unit>();
        enemy3Go.GetComponent<Unit>();

        
    }

}
