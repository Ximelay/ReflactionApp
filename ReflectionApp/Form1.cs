using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReflectionApp
{
    public partial class Form1 : Form
    {
        // ������ ��� �������� �������
        private int[] responses = new int[4];

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;  // ������������� �� ������� �������� �����
            this.BackColor = Color.FromArgb(240, 240, 240); // ������������� ����� ������� ��� ��� ���� �����
            ApplyBackgroundColor(this, this.BackColor);
        }

        private void sticker_Click(object sender, EventArgs e)
        {
            if (sender == everythingIsClear)
                responses[0]++;
            else if (sender == justFewUnClear)
                responses[1]++;
            else if (sender == someWork)
                responses[2]++;
            else if (sender == bitDifficult)
                responses[3]++;

            lblStatistics.Text = $"��� �������: {responses[0]} �������\n" +
                                 $"���� ���-��� ������: {responses[1]} �������\n" +
                                 $"��� �������� �����������: {responses[2]} �������\n" +
                                 $"����������, ������ ���������: {responses[3]} �������";

            // Clear the existing points in the 'Responses' series
            statisticsChart.Series["Responses"].Points.Clear();

            // Add updated data to the series
            statisticsChart.Series["Responses"].Points.AddXY("��� �������", responses[0]);
            statisticsChart.Series["Responses"].Points.AddXY("���� ���-��� ������", responses[1]);
            statisticsChart.Series["Responses"].Points.AddXY("��� �������� �����������", responses[2]);
            statisticsChart.Series["Responses"].Points.AddXY("����������, ������ ���������", responses[3]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create and add the "Responses" series if not already present
            if (!statisticsChart.Series.Any(s => s.Name == "Responses"))
            {
                Series responsesSeries = new Series("Responses");
                responsesSeries.ChartType = SeriesChartType.Bar; // Set the chart type
                statisticsChart.Series.Add(responsesSeries);
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��� ���������� ��� ������ ��������� ��������� ����� �������.\n" +
                            "�������� ���� �� ������ ��� ����������� ������ ������ ���������. \n" +
                            "�� ������ ����� ������� ��������� ��������� ����������.",
                "� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyBackgroundColor(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                control.BackColor = color;

                if (control.HasChildren)
                {
                    ApplyBackgroundColor(control, color);
                }
            }
        }
    }
}
