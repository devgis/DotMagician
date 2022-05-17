using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrawApp
{
    public partial class MainForm : Form
    {
        Font ft = new Font("隶书", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        public void DrawString(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                word=word.Replace("\r\n","");
            }
            if (string.IsNullOrEmpty(word))
            {
                return;
            }
            else
            {
                int colSize = 7;
                if (nudRowCount.Value <= 0)
                {
                    colSize = 7;
                }
                else
                {
                    colSize = (int)nudRowCount.Value;
                }

                int fontSize = 16;
                int rowCount = word.Length / (int)nudRowCount.Value;
                if (word.Length % (int)nudRowCount.Value > 0)
                {
                    rowCount += 1;
                }

                int bmpwidth = fontSize * colSize + fontSize;
                int bmpheight = rowCount * fontSize + fontSize;
                Bitmap bitmap = new Bitmap(bmpwidth, bmpheight);

                for (int i = 0; i < bmpwidth; i++)
                {
                    for (int j = 0; j < bmpheight; j++)
                    {
                       bitmap.SetPixel(i, j,Color.White);
                    }
                }
                //return;
                Graphics g = Graphics.FromImage(bitmap);


                for (int i = 0; i < colSize; i++)
                {
                    for (int j = 0; j < rowCount ; j++)
                    {
                        g.DrawString(word[j*colSize+i].ToString(), new Font(ft.Name, 16, FontStyle.Regular, GraphicsUnit.Pixel), new SolidBrush(Color.Black), new PointF() { X = i * fontSize, Y = j * fontSize });
                    }
                }
                pictureBox1.Image = bitmap;

                StringBuilder sb = new StringBuilder();
                bool[,] bDraw = new bool[bmpwidth, bmpheight];
                for (int j = 0; j < bmpheight; j++)
                {
                    for (int i = 0; i < bmpwidth; i++)
                    {
                        //sb.AppendFormat("r:{0} g:{1} b:{2}\r\n", bitmap.GetPixel(i, j).R, bitmap.GetPixel(i, j).G, bitmap.GetPixel(i, j).B);
                        bDraw[i, j] =!(bitmap.GetPixel(i, j).R == 255 && bitmap.GetPixel(i, j).G == 255 && bitmap.GetPixel(i, j).B == 255);//.R > 0 || bitmap.GetPixel(i, j).G > 0 || bitmap.GetPixel(i, j).B > 0;
                    }
                }
                
                for (int j = 0; j < bmpheight; j++)
                {
                    
                    for (int i = 0; i < bmpwidth; i++)
                    {
                        
                        if(bDraw[i,j])
                        {
                            sb.Append("1"); //需要点
                        }
                        else
                        {
                            sb.Append("0");
                        }
                        //sb.AppendFormat("r:{0} g:{1} b:{2}\r\n", bitmap.GetPixel(i, j).R, bitmap.GetPixel(i, j).G, bitmap.GetPixel(i, j).B);
                        
                    }
                    sb.Append("\r\n");
                }
                tbOutPut.Text = sb.ToString();
            }
        }

        private void btGenerat_Click(object sender, EventArgs e)
        {
            DrawString(tbInput.Text);
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog=new FontDialog();  if(fontDialog.ShowDialog()==DialogResult.OK)  {
                tbInput.Font=fontDialog.Font;//将当前选定的文字改变字体 
                ft = fontDialog.Font;
            }
        }
    }
}
