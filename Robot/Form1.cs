using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Controls;
using AForge.Imaging.Filters;




namespace Robot
{
    public partial class Form1 : Form
    {
        
        public struct coordinate
        {
            public int x;
            public int y;
        }
        public struct rectangle
        {
            public coordinate TopLeft, BottomRight;
        };

        static int SavedPeople = 0;
        public Form1()
        {
            InitializeComponent();

            
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfor in filterInfoCollection)
                ComboCamera.Items.Add(filterInfor.Name);

            ComboCamera.SelectedIndex = 0;
            

            videoCaptureDevice = new VideoCaptureDevice();
        }

   
        private rectangle[] FindHoles(Bitmap Image)
        {

    
            
            Bitmap Image2 = Image;

            


            Grayscale filter0 = new Grayscale(0.2125, 0.7154, 0.0721);
            Image = filter0.Apply(Image);

            Threshold filter1 = new Threshold(100);
            Image = filter1.Apply(Image);



            int Count = 0;


            bool[,] check = new bool[Image.Width, Image.Height];
            bool[,] visited = new bool[Image.Width, Image.Height];

            Queue<(int, int)> queue = new Queue<(int, int)>();


            //string s = "";

            for (int j = 0; j < Image.Height; ++j)
            {
                for (int i = 0; i < Image.Width; ++i)
                {
                    Color t = Image.GetPixel(i, j);
                    if (t.R != 255)
                    {
                        check[i, j] = true;
                    }
                    else check[i, j] = false;
                    visited[i, j] = false;
                }

            }


            int[,] group = new int[Image.Width, Image.Height];

            int[] dx = { 0, 0, -1, 1/*, 1, 1, -1, -1 */};
            int[] dy = { 1, -1, 0, 0/*, 1, -1, 1, -1 */};

            for (int i = 0; i < Image.Width; ++i)
                for (int j = 0; j < Image.Height; ++j)
                {
                    if (check[i, j] && !visited[i, j])
                    {
                        Count++;
                        (int, int) pair = (i, j);
                        queue.Enqueue(pair);
                        visited[i, j] = true;
                        group[i, j] = Count;
                        while (queue.Count > 0)
                        {
                            (int, int) p = queue.Dequeue();
                            int x = p.Item1;
                            int y = p.Item2;

                            for (int u = 0; u < 4; ++u)
                            {
                                int x1 = x + dx[u];
                                int y1 = y + dy[u];
                                if (0 <= x1 && x1 < Image.Width && 0 <= y1 && y1 < Image.Height
                                    && check[x1, y1] && !visited[x1, y1])
                                {
                                    visited[x1, y1] = true;
                                    (int, int) pairx = (x1, y1);
                                    queue.Enqueue(pairx);
                                    group[x1, y1] = Count;
                                }
                            }
                        }
                    }
                }

            //s = Count.ToString();
            //s += '\n';
            int[] max_x = new int[Count + 1];
            int[] min_x = new int[Count + 1];
            int[] max_y = new int[Count + 1];
            int[] min_y = new int[Count + 1];

            for (int j = 0; j < Image.Height; ++j)
            {
                for (int i = 0; i < Image.Width; ++i)
                {
                    int t = group[i, j];
                    //s += t.ToString();
                    check[i, j] = false;
                }
                //s += '\n';

            }

            for (int i = 0; i <= Count; ++i)
            {
                max_x[i] = 0;
                min_x[i] = Image.Width;
                max_y[i] = 0;
                min_y[i] = Image.Height;

            }

            for (int j = 0; j < Image.Height; ++j)
            {
                for (int i = 0; i < Image.Width; ++i)
                {
                    int t = group[i, j];
                    max_x[t] = Math.Max(max_x[t], i);
                    min_x[t] = Math.Min(min_x[t], i);

                    max_y[t] = Math.Max(max_y[t], j);
                    min_y[t] = Math.Min(min_y[t], j);
                }

            }

            Bitmap bm = new Bitmap(Image.Width, Image.Height);

            rectangle[] rec = new rectangle[Count+1];
            const int thick = 1;
            for (int i = 1; i <= Count; ++i)
            {
                rec[i].TopLeft.x = min_x[i];
                rec[i].TopLeft.y = min_y[i];
                rec[i].BottomRight.x = max_x[i];
                rec[i].BottomRight.y = max_y[i];
                

                for (int p = min_x[i]; p <= max_x[i]; ++p)
                {
                    for (int h = min_y[i]; h <= max_y[i]; ++h)
                        if (p <= min_x[i]+thick || p >= max_x[i]-thick || h <= min_y[i]+thick || h >= max_y[i]-thick)
                        {
                            bm.SetPixel(p, h, Color.Green);
                            check[p, h] = true;
                        }
                }

            }

            for (int j = 0; j < Image.Height; ++j)
            {
                for (int i = 0; i < Image.Width; ++i)
                {
                    if (!check[i, j])
                    {
                        Color t = Image2.GetPixel(i, j);
                        bm.SetPixel(i, j, t);
                    }
                }

            }
            TestAlgorithm.Image = bm;
            return rec;
            //TestAlgorithm.Image = bm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[ComboCamera.SelectedIndex].MonikerString);

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }
        private static Bitmap ResizeImage(Bitmap mg, Size newSize)
        {
            double ratio = 0d;
            double myThumbWidth = 0d;
            double myThumbHeight = 0d;
            int x = 0;
            int y = 0;

            Bitmap bp;


            if ((mg.Width / Convert.ToDouble(newSize.Width)) > (mg.Height /
            Convert.ToDouble(newSize.Height)))
                ratio = Convert.ToDouble(mg.Width) / Convert.ToDouble(newSize.Width);
            else
                ratio = Convert.ToDouble(mg.Height) / Convert.ToDouble(newSize.Height);
            myThumbHeight = Math.Ceiling(mg.Height / ratio);
            myThumbWidth = Math.Ceiling(mg.Width / ratio);

            Size thumbSize = new Size((int)myThumbWidth, (int)myThumbHeight);
            bp = new Bitmap(newSize.Width, newSize.Height);
            x = (newSize.Width - thumbSize.Width) / 2;
            y = (newSize.Height - thumbSize.Height);

            System.Drawing.Graphics g = Graphics.FromImage(bp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            Rectangle rect = new Rectangle(x, y, thumbSize.Width, thumbSize.Height);
            g.DrawImage(mg, rect, 0, 0, mg.Width, mg.Height, GraphicsUnit.Pixel);

            return bp;
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Image, Image2;

            Image = (Bitmap)eventArgs.Frame.Clone();
            Image2 = new Bitmap(Image.Width, Image.Height);

            Image = ResizeImage(Image, new Size((int)(0.125f * Image.Width), (int)(0.125f * Image.Height)));

            WebCam.Image = Image;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true) 
                    videoCaptureDevice.Stop();
            videoCaptureDevice.Stop();
        }

        private void HelpVictim_Click(object sender, EventArgs e)
        {
            SavedPeople++;
            string s = "Đã được cứu: " + SavedPeople + " người";
            Saved.Text = s;
            int a = int.Parse(Victim.Text);
            int Rest = a - SavedPeople;
            s = "Còn lại: " + Rest + " người";
            NotSaved.Text = s;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        int last = 0;
        public void Display()
        {
            string s = Environment.CurrentDirectory;
            for (char i = '0'; i<='3'; ++i)
            {
                if (count >= 6) break;

                System.Drawing.Image Tmp = System.Drawing.Image.FromFile(s + "\\Resources\\Test" + i + ".png");
                Bitmap bm = (Bitmap)Tmp;
                Task.Delay(2000).Wait();

                rectangle[] rec = FindHoles(bm);
         
            }
            TestAlgorithm.Image = System.Drawing.Image.FromFile(s + "\\Resources\\OK.png");
        }
        private void BtAuto_Click(object sender, EventArgs e)
        {
            string reversestatus = BtAuto.Text;
            Status.Text = "Trạng thái: " + reversestatus;
            if (reversestatus == "Tự động")
            {
                //Tm.Interval = 1000;
                count = 0;
                Tm.Start();
                BtAuto.Text = "Thủ công";
                Display();
                Tm.Stop();
                MessageBox.Show("Đã tìm được người trong khoảng 10 giây");
            }
            else
            {
                BtAuto.Text = "Tự động";
            }
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            count++;
        }
    }
}
