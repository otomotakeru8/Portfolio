using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class PlayerSetting
{
    public int attackFrequency;
    public int relocationFrame;
    public int maxHp;
    public Vector2[] viewRange;
    public Vector2[] attackRange;

    public PlayerSetting(string charactername, Charactor charactor)
    {
        switch (charactername)
        {
            case Daemon:
                if (charactor.level > 90)
                {

                }
                else if (charactor.level > 50)
                {

                }
                else
                {

                }
                if (charactor.credibility >= 200)
                {

                }
                else if (charactor.credibility >= 150)
                {

                }
                else if (charactor.credibility >= 100)
                {

                }
                else if (charactor.credibility >= 50)
                {

                }
                viewRange = new Vector2[]
                {
                    new Vector2(0,0),
                    new Vector2(0,1),
                    new Vector2(0,-1),
                    new Vector2(1,0),
                    new Vector2(1,1),
                    new Vector2(1,-1),
                    new Vector2(-1,0),
                    new Vector2(-1,1),
                    new Vector2(-1,-1),
                    new Vector2(0,2),
                    new Vector2(0,-2),
                    new Vector2(2,0),
                    new Vector2(-2,0)
                };
                if (Master.playerdeta.DaemonbreakingThrough2 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1),
                        new Vector2(0,2),
                        new Vector2(0,-2),
                        new Vector2(2,0),
                        new Vector2(-2,0)
                    };
                }
                else if (Master.playerdeta.DaemonbreakingThrough1 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1),
                        new Vector2(0,2),
                        new Vector2(0,-2)
                    };
                }
                else
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1)
                    };
                }

                break;
            case Poltergeist:

                break;
            case Gore:

                break;
            case Zashiki_warashi:

                break;
            case Ghost:

                break;
        }
    }
}
