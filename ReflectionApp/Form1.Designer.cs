using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReflectionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox everythingIsClear;
        private PictureBox justFewUnClear;
        private PictureBox someWork;
        private PictureBox bitDifficult;
        private Label lblStatistics;
        private Label lblUnderstood; // Новый Label для статуса
        private Label lblUncertain; // Новый Label для статуса
        private Label lblNeedsHelp; // Новый Label для статуса
        private Label lblNotUnderstood; // Новый Label для статуса
        private Chart statisticsChart;
        private MenuStrip menuStrip;
        private ToolStripMenuItem aboutMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            everythingIsClear = new PictureBox();
            justFewUnClear = new PictureBox();
            someWork = new PictureBox();
            bitDifficult = new PictureBox();
            lblStatistics = new Label();
            lblUnderstood = new Label();
            lblUncertain = new Label();
            lblNeedsHelp = new Label();
            lblNotUnderstood = new Label();
            ((System.ComponentModel.ISupportInitialize)everythingIsClear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)justFewUnClear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)someWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bitDifficult).BeginInit();

            statisticsChart = new Chart();

            menuStrip = new MenuStrip();
            aboutMenuItem = new ToolStripMenuItem("О программе");
            menuStrip.Items.Add(aboutMenuItem);
            aboutMenuItem.Click += AboutMenuItem_Click;  // Обработчик клика на "О программе"

            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;

            SuspendLayout();
            // 
            // everythingIsClear
            // 

            ChartArea chartArea = new ChartArea();
            statisticsChart.ChartAreas.Add(chartArea);
            statisticsChart.Location = new Point(300, 400);  // Positioning the chart
            statisticsChart.Name = "statisticsChart";
            statisticsChart.Size = new Size(400, 300);
            statisticsChart.TabIndex = 9;

            Controls.Add(statisticsChart);  // Добавляем график в форму


            everythingIsClear.Image = Image.FromFile(@"resource\everythingIsClear.png");
            everythingIsClear.Location = new Point(147, 51);
            everythingIsClear.Name = "everythingIsClear";
            everythingIsClear.Size = new Size(100, 100);
            everythingIsClear.TabIndex = 0;
            everythingIsClear.TabStop = false;
            everythingIsClear.Click += sticker_Click;
            // 
            // justFewUnClear
            // 
            justFewUnClear.Image = Image.FromFile(@"resource\justFewUnClear.png");
            justFewUnClear.Location = new Point(556, 42);
            justFewUnClear.Name = "justFewUnClear";
            justFewUnClear.Size = new Size(100, 100);
            justFewUnClear.TabIndex = 1;
            justFewUnClear.TabStop = false;
            justFewUnClear.Click += sticker_Click;
            // 
            // someWork
            // 
            someWork.Image = Image.FromFile(@"resource\someWork.png");
            someWork.Location = new Point(147, 241);
            someWork.Name = "someWork";
            someWork.Size = new Size(100, 100);
            someWork.TabIndex = 2;
            someWork.TabStop = false;
            someWork.Click += sticker_Click;
            // 
            // bitDifficult
            // 
            bitDifficult.Image = Image.FromFile(@"resource\bitDifficult.png");
            bitDifficult.Location = new Point(556, 241);
            bitDifficult.Name = "bitDifficult";
            bitDifficult.Size = new Size(100, 100);
            bitDifficult.TabIndex = 3;
            bitDifficult.TabStop = false;
            bitDifficult.Click += sticker_Click;
            // 
            // lblStatistics
            // 
            lblStatistics.Location = new Point(12, 550);
            lblStatistics.Name = "lblStatistics";
            lblStatistics.Size = new Size(300, 100);
            lblStatistics.TabIndex = 8;
            // 
            // lblUnderstood
            // 
            lblUnderstood.Location = new Point(147, 167);
            lblUnderstood.Name = "lblUnderstood";
            lblUnderstood.Size = new Size(112, 23);
            lblUnderstood.TabIndex = 4;
            lblUnderstood.Text = "Все понятно";
            // 
            // lblUncertain
            // 
            lblUncertain.Location = new Point(525, 158);
            lblUncertain.Name = "lblUncertain";
            lblUncertain.Size = new Size(164, 23);
            lblUncertain.TabIndex = 5;
            lblUncertain.Text = "Лишь кое-что неясно";
            // 
            // lblNeedsHelp
            // 
            lblNeedsHelp.Location = new Point(106, 360);
            lblNeedsHelp.Name = "lblNeedsHelp";
            lblNeedsHelp.Size = new Size(206, 23);
            lblNeedsHelp.TabIndex = 6;
            lblNeedsHelp.Text = "Еще придется потрудиться";
            // 
            // lblNotUnderstood
            // 
            lblNotUnderstood.Location = new Point(495, 357);
            lblNotUnderstood.Name = "lblNotUnderstood";
            lblNotUnderstood.Size = new Size(236, 23);
            lblNotUnderstood.TabIndex = 7;
            lblNotUnderstood.Text = "Трудновато, многое непонятно";
            // 
            // Form1
            // 
            ClientSize = new Size(800, 800);
            Controls.Add(everythingIsClear);
            Controls.Add(justFewUnClear);
            Controls.Add(someWork);
            Controls.Add(bitDifficult);
            Controls.Add(lblUnderstood);
            Controls.Add(lblUncertain);
            Controls.Add(lblNeedsHelp);
            Controls.Add(lblNotUnderstood);
            Controls.Add(lblStatistics);
            Name = "Form1";
            Text = "Рефлексия по занятию";
            ((System.ComponentModel.ISupportInitialize)everythingIsClear).EndInit();
            ((System.ComponentModel.ISupportInitialize)justFewUnClear).EndInit();
            ((System.ComponentModel.ISupportInitialize)someWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)bitDifficult).EndInit();
            ResumeLayout(false);
        }
    }
}
