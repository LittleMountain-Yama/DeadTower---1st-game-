using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerOne : MonoBehaviour
{
    public Transform[] allPositions;
    public GameObject target;
    public GameObject spawnEntrance;
    public GameObject spawnConference;
    public GameObject spawnOffice;
    public GameObject spawnKitchen;
    public GameObject spawnDeposit;
    public GameObject spawnOutside;
    public Enemy prefabEnemy;
    private bool entranceUsed;
    private bool conferenceUsed;
    private bool officeUsed;
    private bool kitchenUsed;
    private bool depositUsed;
    private bool outsideUsed;
  
    private void Awake()
    {
      target = GameObject.Find("PlayerSprite");
      entranceUsed = false;
      conferenceUsed = false;
      officeUsed = false;
      kitchenUsed = false;
      depositUsed = false;
      outsideUsed = false;
    }

    private void Update()
    {
        if(spawnEntrance == null && entranceUsed == false)
        {
            Enemy enemyTempA = Instantiate(prefabEnemy);
            enemyTempA.transform.position = allPositions[0].position;
            Enemy enemyTempB = Instantiate(prefabEnemy);
            enemyTempB.transform.position = allPositions[1].position;
            entranceUsed = true;
        }
        if (spawnConference == null && conferenceUsed == false)
        {
            Enemy enemyTempF = Instantiate(prefabEnemy);
            enemyTempF.transform.position = allPositions[5].position;
            Enemy enemyTempG = Instantiate(prefabEnemy);
            enemyTempG.transform.position = allPositions[6].position;
            Enemy enemyTempH = Instantiate(prefabEnemy);
            enemyTempH.transform.position = allPositions[7].position;
            Enemy enemyTempI = Instantiate(prefabEnemy);
            enemyTempI.transform.position = allPositions[8].position;
            conferenceUsed = true;
        }
        if (spawnOffice == null && officeUsed == false)
        {
            Enemy enemyTempJ = Instantiate(prefabEnemy);
            enemyTempJ.transform.position = allPositions[9].position;
            Enemy enemyTempK = Instantiate(prefabEnemy);
            enemyTempK.transform.position = allPositions[10].position;
            Enemy enemyTempL = Instantiate(prefabEnemy);
            enemyTempL.transform.position = allPositions[11].position;
            officeUsed = true;
        }
        if (spawnKitchen == null && kitchenUsed == false)
        {
            Enemy enemyTempO = Instantiate(prefabEnemy);
            enemyTempO.transform.position = allPositions[14].position;
            Enemy enemyTempP = Instantiate(prefabEnemy);
            enemyTempP.transform.position = allPositions[15].position;
            Enemy enemyTempQ = Instantiate(prefabEnemy);
            enemyTempQ.transform.position = allPositions[16].position;
            Enemy enemyTempR = Instantiate(prefabEnemy);
            enemyTempR.transform.position = allPositions[17].position;
            Enemy enemyTempS = Instantiate(prefabEnemy);
            enemyTempS.transform.position = allPositions[18].position;
            kitchenUsed = true;
        }
            if (spawnDeposit == null && depositUsed == false)
        {
            Enemy enemyTempX = Instantiate(prefabEnemy);
            enemyTempX.transform.position = allPositions[23].position;
            Enemy enemyTempY = Instantiate(prefabEnemy);
            enemyTempY.transform.position = allPositions[24].position;
            Enemy enemyTempZ = Instantiate(prefabEnemy);
            enemyTempZ.transform.position = allPositions[25].position;
            Enemy enemyTempAA = Instantiate(prefabEnemy);
            enemyTempAA.transform.position = allPositions[26].position;
            Enemy enemyTempAB = Instantiate(prefabEnemy);
            enemyTempAB.transform.position = allPositions[27].position;
            depositUsed = true;
        }
        if (spawnOutside == null && outsideUsed == false)
        {
            Enemy enemyTempAC = Instantiate(prefabEnemy);
            enemyTempAC.transform.position = allPositions[28].position;
            Enemy enemyTempAD = Instantiate(prefabEnemy);
            enemyTempAD.transform.position = allPositions[29].position;
            Enemy enemyTempAE = Instantiate(prefabEnemy);
            enemyTempAE.transform.position = allPositions[30].position;
            Enemy enemyTempAF = Instantiate(prefabEnemy);
            enemyTempAF.transform.position = allPositions[31].position;
            Enemy enemyTempAG = Instantiate(prefabEnemy);
            enemyTempAG.transform.position = allPositions[32].position;
            Enemy enemyTempAH = Instantiate(prefabEnemy);
            enemyTempAH.transform.position = allPositions[33].position;
            Enemy enemyTempAI = Instantiate(prefabEnemy);
            enemyTempAI.transform.position = allPositions[34].position;
            Enemy enemyTempAJ = Instantiate(prefabEnemy);
            enemyTempAJ.transform.position = allPositions[35].position;
            outsideUsed = true;
        }
    }


}
