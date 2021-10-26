using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW3
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           int[,] ia_Map = new int[10,10];
           int[] ia_MIndex = { 0 ,7, 13, 28, 44, 62, 74, 75, 87 ,90 };

            int i; 
            int j;


            ia_Map[0, 0] = 4;
            ia_Map[0, 7] = 4;
            ia_Map[1, 3] = 4;
            ia_Map[2, 8] = 4;
            ia_Map[4,4] = 4;
            ia_Map[6, 2] = 4;
            ia_Map[7, 4] = 4;
            ia_Map[7,5] = 4;
            ia_Map[8, 7] = 4;
            ia_Map[9, 0] = 4;





            for (i = 0; i < 1; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    int total = 0;
                    if (ia_Map[i, j] == 4)
                    {
                        total = total + 1;
                        ia_Map[i, j + 1] = total;
                        ia_Map[i+1, j] = total;
                        ia_Map[i + 1, j + 1] += total;



                    }
                    else
                    {
                        ia_Map[i, j] = 0;
                    }
                }
            }

            for (i = 1; i < 9; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    int total = 0;
                    if (ia_Map[i, j] == 4)
                    {
                        total = total + 1;
                        ia_Map[i, j + 1] += total;
                        ia_Map[i, j - 1] += total;
                        ia_Map[i+1, j] += total;
                        ia_Map[i-1, j] += total;
                        ia_Map[i+1, j+1] += total;
                        ia_Map[i-1, j-1] += total;
                        ia_Map[i+1, j-1] += total;
                        ia_Map[i-1, j+1] += total;

                    }
                    else
                    {
                        ia_Map[i, j] = 0;
                    }
                }
            }

            for (i = 9; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    int total = 0;
                    if (ia_Map[i, j] == 4)
                    {
                        total = total + 1;
                        ia_Map[i, j + 1] += total;
                        ia_Map[i-1, j + 1] += total;
                        ia_Map[i-1, j] += total;

                    }
                    else
                    {
                        ia_Map[i, j] = 0;
                    }
                }
            }



            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {

                    Response.Write(ia_Map[i, j]);
                    Response.Write(" ");

                }
                Response.Write("<br />");
            }




        }




    }

    }
