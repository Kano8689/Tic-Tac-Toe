using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;



public class Random_TicTac : MonoBehaviour
{
    public Text disp;
    public Text[] btn;
    public Button[] BtnAry;
    int i,cnt=0;
    public int temp = 1;

    List<int> list = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (i = 1; i <= 9; i++)
        {
            btn[i].text = "";
            BtnAry[i].GetComponent<Image>().color = Color.white;
            btn[i].color = Color.black;
            BtnAry[i].interactable = true;
        }
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void BtnClick(int pos)
    {
        //if(temp % 2 == 1)
        {
            BtnAry[pos].interactable = false;
            
            btn[pos].text = "X";
            temp++;

            list.Add(pos);
            Win();
        }

        //if(temp % 2 == 0)
        {
            if(temp<=8)
            {
                for (i = 1; i <= 2;)
                {
                    int rn = Random.Range(1, 10);

                    if (!list.Contains(rn))
                    {
                        //list.Add(rn);
                        pos = rn;
                        i++;
                    }
                }
                BtnAry[pos].interactable = false;

                btn[pos].text = "0";
                temp++;
                list.Add(pos);
                Win();
            }

            //BtnAry[pos].interactable = false;

            //btn[pos].text = "0";
            //temp++;
            //list.Add(pos);
            //Win();
        }

        //list.Add(pos);
        //Win();
    }
    public void Restart()
    {
        disp.text = "";
        temp = 1;
        cnt = 0;
        for(i=0;i<10;i++)
        {
            list.Remove(i);
        }
        Start();
    }

    public void Win()
    {
        if (btn[1].text == "X" && btn[2].text == "X" && btn[3].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[3].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[2].color = Color.blue;
            btn[3].color = Color.blue;
        }
        else if (btn[1].text == "X" && btn[4].text == "X" && btn[7].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[4].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[1].text == "X" && btn[5].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[2].text == "X" && btn[5].text == "X" && btn[8].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;

            btn[2].color = Color.blue;
            btn[5].color = Color.blue;
            btn[8].color = Color.blue;
        }
        else if (btn[3].text == "X" && btn[6].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[6].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (btn[3].text == "X" && btn[5].text == "X" && btn[7].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[4].text == "X" && btn[5].text == "X" && btn[6].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;

            btn[4].color = Color.blue;
            btn[5].color = Color.blue;
            btn[6].color = Color.blue;
        }
        else if (btn[7].text == "X" && btn[8].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[7].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[7].color = Color.blue;
            btn[8].color = Color.blue;
            btn[9].color = Color.blue;
        }

        else if (btn[1].text == "0" && btn[2].text == "0" && btn[3].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[3].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[2].color = Color.blue;
            btn[3].color = Color.blue;
        }
        else if (btn[1].text == "0" && btn[4].text == "0" && btn[7].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[4].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[1].text == "0" && btn[5].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[2].text == "0" && btn[5].text == "0" && btn[8].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;

            btn[2].color = Color.blue;
            btn[5].color = Color.blue;
            btn[8].color = Color.blue;
        }
        else if (btn[3].text == "0" && btn[6].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[6].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (btn[3].text == "0" && btn[5].text == "0" && btn[7].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[4].text == "0" && btn[5].text == "0" && btn[6].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;

            btn[4].color = Color.blue;
            btn[5].color = Color.blue;
            btn[6].color = Color.blue;
        }
        else if (btn[7].text == "0" && btn[8].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[7].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[7].color = Color.blue;
            btn[8].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (temp == 9)
        {
            disp.text = "Match Is Draw";
            disp.color = Color.red;
        }

        if (cnt == 1)
        {
            for (i = 1; i <= 9; i++)
            {
                BtnAry[i].interactable = false;
            }
        }
    }
}
