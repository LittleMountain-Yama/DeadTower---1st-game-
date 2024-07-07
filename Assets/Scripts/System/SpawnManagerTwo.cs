using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTwo : MonoBehaviour {

    public Transform[] allPositions;
    public GameObject target;
    public GameObject spawnPath;
    public GameObject spawnBarracks;
    public GameObject spawnLab;
    public GameObject spawnBackPath;
    public GameObject spawnBackEnd;
    public Enemy prefabEnemyA;  //Normal
    public Enemy prefabEnemyB;  //Dog
    public Enemy prefabEnemyC;  //Swat
    private bool pathUsed;
    private bool barracksUsed;
    private bool labUsed;
    private bool backPathUsed;
    private bool backEndUsed;
    private bool secondPhase;

    void Awake()
    {
      target = GameObject.Find("PlayerSprite");
      pathUsed = false;
      barracksUsed = false;
      labUsed = false;
      backPathUsed = false;
      backEndUsed = false;
      secondPhase = false;
    }
    void Update()
    {
        if (target.transform.GetComponent<Player>().hasChem == true)
        {
            secondPhase = true;
        }
        if (spawnPath == null && pathUsed == false)
        {
            Enemy enemyTempA = Instantiate(prefabEnemyB);
            enemyTempA.transform.position = allPositions[0].position;
            Enemy enemyTempB = Instantiate(prefabEnemyA);
            enemyTempB.transform.position = allPositions[1].position;
            Enemy enemyTempC = Instantiate(prefabEnemyA);
            enemyTempC.transform.position = allPositions[2].position;
            Enemy enemyTempD = Instantiate(prefabEnemyA);
            enemyTempD.transform.position = allPositions[3].position;
            Enemy enemyTempE = Instantiate(prefabEnemyC);
            enemyTempE.transform.position = allPositions[4].position;
            Enemy enemyTempF = Instantiate(prefabEnemyA);
            enemyTempF.transform.position = allPositions[5].position;
            Enemy enemyTempG = Instantiate(prefabEnemyB);
            enemyTempG.transform.position = allPositions[6].position;
            pathUsed = true;
        }
        if (spawnBarracks == null && barracksUsed == false)
        {
            Enemy enemyTempH = Instantiate(prefabEnemyA);
            enemyTempH.transform.position = allPositions[7].position;
            Enemy enemyTempI = Instantiate(prefabEnemyA);
            enemyTempI.transform.position = allPositions[8].position;
            Enemy enemyTempJ = Instantiate(prefabEnemyA);
            enemyTempJ.transform.position = allPositions[9].position;
            Enemy enemyTempK = Instantiate(prefabEnemyA);
            enemyTempK.transform.position = allPositions[10].position;
            barracksUsed = true;
        }
        if (spawnLab == null && labUsed == false)
        {
            Enemy enemyTempL = Instantiate(prefabEnemyB);
            enemyTempL.transform.position = allPositions[11].position;
            Enemy enemyTempM = Instantiate(prefabEnemyC);
            enemyTempM.transform.position = allPositions[12].position;
            Enemy enemyTempN = Instantiate(prefabEnemyA);
            enemyTempN.transform.position = allPositions[13].position;
            Enemy enemyTempO = Instantiate(prefabEnemyA);
            enemyTempO.transform.position = allPositions[14].position;
            Enemy enemyTempP = Instantiate(prefabEnemyA);
            enemyTempP.transform.position = allPositions[15].position;
            Enemy enemyTempQ = Instantiate(prefabEnemyA);
            enemyTempQ.transform.position = allPositions[16].position;
            Enemy enemyTempR = Instantiate(prefabEnemyC);
            enemyTempR.transform.position = allPositions[17].position;
            Enemy enemyTempS = Instantiate(prefabEnemyA);
            enemyTempS.transform.position = allPositions[18].position;
            Enemy enemyTempT = Instantiate(prefabEnemyA);
            enemyTempT.transform.position = allPositions[19].position;
            Enemy enemyTempU = Instantiate(prefabEnemyA);
            enemyTempU.transform.position = allPositions[20].position;
            Enemy enemyTempV = Instantiate(prefabEnemyB);
            enemyTempV.transform.position = allPositions[21].position;
            Enemy enemyTempW = Instantiate(prefabEnemyA);
            enemyTempW.transform.position = allPositions[22].position;
            Enemy enemyTempX = Instantiate(prefabEnemyA);
            enemyTempX.transform.position = allPositions[23].position;
            Enemy enemyTempY = Instantiate(prefabEnemyA);
            enemyTempY.transform.position = allPositions[24].position;
            Enemy enemyTempZ = Instantiate(prefabEnemyB);
            enemyTempZ.transform.position = allPositions[25].position;
            labUsed = true;
        }
        if (spawnBackPath == null && backPathUsed == false && secondPhase == true)
        {
            Enemy enemyTempAA = Instantiate(prefabEnemyA);
            enemyTempAA.transform.position = allPositions[26].position;
            Enemy enemyTempAB = Instantiate(prefabEnemyA);
            enemyTempAB.transform.position = allPositions[27].position;
            Enemy enemyTempAC = Instantiate(prefabEnemyC);
            enemyTempAC.transform.position = allPositions[28].position;
            Enemy enemyTempAD = Instantiate(prefabEnemyC);
            enemyTempAD.transform.position = allPositions[29].position;
            backPathUsed = true;
        }
        if (spawnBackEnd == null && backEndUsed == false && secondPhase == true)
        {
            backEndUsed = true;
            Enemy enemyTempAE = Instantiate(prefabEnemyB);
            enemyTempAE.transform.position = allPositions[30].position;
            Enemy enemyTempAF = Instantiate(prefabEnemyB);
            enemyTempAF.transform.position = allPositions[31].position;
            Enemy enemyTempAG = Instantiate(prefabEnemyB);
            enemyTempAG.transform.position = allPositions[32].position;
            Enemy enemyTempAH = Instantiate(prefabEnemyC);
            enemyTempAH.transform.position = allPositions[33].position;
            Enemy enemyTempAI = Instantiate(prefabEnemyA);
            enemyTempAI.transform.position = allPositions[34].position;
        }               
    }
}