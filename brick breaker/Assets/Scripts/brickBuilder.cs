using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class brickBuilder : MonoBehaviour
{
    public int brickCount=0,level=0, rowNum=1,colNum=1;
    public GameObject[] listOfBricks;
    public GameObject player;
    
    private void Start()
    {
        listOfBricks = Resources.LoadAll<GameObject>("BrickTypes");
        
        BuildBricks(level);
    }
    //build a random array of bricks
    //each array worth a certian number of points
    //4hit brick=4points etc.
    public void BuildBricks(int level)
    {
        if (level>=13) {//the screen can only hold 13 rows of blocks
            level = 13;
        }
        for (int i = 0; i < level; i++)//spawn 4 blocks and move on
        {
            whereSpawn(1,i);
            new WaitForEndOfFrame();
            whereSpawn(2,i);
            new WaitForEndOfFrame();
            whereSpawn(3,i);   
            new WaitForEndOfFrame();
            whereSpawn(4,i);
            new WaitForEndOfFrame();
        }
    }

    public void makeOneBrick(Vector3 loc)
    {
        int whichBrick;
        if (level<3) {//up the difficulty
            whichBrick = Random.Range(0, level);
        }
        else {
            if (level>12)
            {
                whichBrick = Random.Range(1, 3); 
            }
            else {
                whichBrick = Random.Range(0, 3);
            }
        }
        GameObject newBrick=Instantiate(listOfBricks[whichBrick]) as GameObject;
        newBrick.transform.position = loc;
        brickCount++;
    }

    public void whereSpawn(int colNum,int rowNum)
    {
        var loc = new Vector3(0, 0, 0);
        if (colNum==4) { loc.x = (float) -48; }//far left xval
        if (colNum==3) { loc.x = (float) -16; }//center left xval
        if (colNum==2) { loc.x = (float) 16; }//center right xval
        if (colNum==1) { loc.x = (float) 48; }//far right xval
        loc.y = (float) (126 - (rowNum * 13));//start at the max height and work down
        makeOneBrick(loc);
    }

    private void Update()
    {
        if (brickCount <= 0)
        {
            if (player.transform.position.y<=6)
            {
                level++;
                BuildBricks(level);
            }
        }
    }
}
