using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Drawing;
using System.Threading;

namespace 聚赚派
{
    public class Function
    {
        public Image RandomCode()
        {
            string[] CharString = { "a", "b", "c", "d", "e", "f", "g", "h", 
                                      "i", "j", "k", "m", "n", "p", "q", 
                                      "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                      "A", "B", "C", "D", "E", "F", "G", "H", 
                                      "I", "J", "K", "L", "M", "N",  "P", "Q", 
                                      "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Random RandNumber = new Random();
            int count = RandNumber.Next(2, 5);


            byte[] bytes = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            int seed = BitConverter.ToInt32(bytes, 0);
            rng.Dispose();
            Random RandIndex = new Random(seed);


            List<string> RandString = new List<string>();


            for (int i = 0; i < count; i++)
            {
                int k = RandNumber.Next(0, 49);
                RandString.Add(CharString[k]);

            }

            for (int d = 0; d < 4 - count; d++)
            {
                RandString.Insert(RandIndex.Next(0, count + 1), RandNumber.Next(2, 10).ToString());
            }


            string[] RandCode = new string[4];

            RandString.CopyTo(RandCode);

            Rectangle[] rects = { new Rectangle(10, 5, 30, 40), new Rectangle(40, 5, 30, 40),
                new Rectangle(70, 5, 30, 40), new Rectangle(100, 5, 30, 40) };


            Bitmap CodeImg = new Bitmap(140, 50);


            Graphics g = Graphics.FromImage(CodeImg);
            g.Clear(Color.White);
            for (int i = 0; i < 4; i++)
            {
                //float angle = new Random().Next(-45, 46);
                //g.TranslateTransform(12, 12);
                //g.RotateTransform(angle);
                g.DrawString(RandCode[i], new Font("Comic Sans MS", 18), new SolidBrush(Color.Black), rects[i]);
                //g.RotateTransform(-angle);
                //g.TranslateTransform(2, -12);
            }

            for (int i = 0; i < 2; i++)
            {
                g.DrawBezier(new Pen(new SolidBrush(Color.Black),2), RandomPoint(), RandomPoint(), RandomPoint(), RandomPoint());
            }

            
            g.Dispose();

            return CodeImg;

        }

        public Point RandomPoint()
        {
            Thread.Sleep(15);
            Random ram = new Random();
            Point p = new Point(ram.Next(141), ram.Next(141));
            return p;
        }
         

    }
}