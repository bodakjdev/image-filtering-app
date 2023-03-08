using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        List<ConvFilterBase> SavedFilters = new List<ConvFilterBase>()
        {
            new BlurFilter(),
            new GaussianBlurFilter(),
            new SharpenFilter(),
            new EdgeDetectionFilter(),
            new EmbossFilter()
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SavedFilters.Count; i++)
            {
                comboBoxFilterPick.Items.Add(SavedFilters[i].FilterName);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image";
            ofd.Filter = "Image File (*.jpg; *.jpeg; *.bmp; *.png;)|*.jpg; *.jpeg; *.bmp; *.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(ofd.FileName);
                pictureBoxBefore.Image = bmp;
                pictureBoxAfter.Image = bmp;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image File (*.jpg; *.jpeg; *.bmp; *.png;)|*.jpg; *.jpeg; *.bmp; *.png;";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAfter.Image.Save(sfd.FileName);
            }
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBoxAfter.Image);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color org = img.GetPixel(x, y);
                    Color inv = Color.FromArgb(255, 255 - org.R, 255 - org.G, 255 - org.B);
                    img.SetPixel(x, y, inv);
                }
            }
            pictureBoxAfter.Image = img;
        }

        private void buttonBrightUp_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = AdjustBrightness(10);
        }

        private void buttonBrightDown_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = AdjustBrightness(-10);
        }

        private Bitmap AdjustBrightness(int brightness)
        {
            Bitmap img = new Bitmap(pictureBoxAfter.Image);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color org = img.GetPixel(x, y);
                    int[] newRGB = { org.R + brightness, org.G + brightness, org.B + brightness };
                    for (int i = 0; i < newRGB.Length; i++)
                    {
                        if (newRGB[i] > 255)
                        {
                            newRGB[i] = 255;
                        }
                        if (newRGB[i] < 0)
                        {
                            newRGB[i] = 0;
                        }
                    }

                    Color br = Color.FromArgb(org.A, newRGB[0], newRGB[1], newRGB[2]);
                    img.SetPixel(x, y, br);
                }
            }
            return img;
        }

        private void buttonCtrUp_Click(object sender, EventArgs e)
        {
            double threshold = 10.0;
            Bitmap img = new Bitmap(pictureBoxAfter.Image);
            double contrast = Math.Pow((100 + threshold) / 100, 2);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color org = img.GetPixel(x, y);
                    double[] newRGB = { ((((org.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0,
                         ((((org.G / 255.0) - 0.5) * contrast) + 0.5) * 255.0,
                         ((((org.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0 };
                    for (int i = 0; i < newRGB.Length; i++)
                    {
                        if (newRGB[i] > 255)
                        {
                            newRGB[i] = 255;
                        }
                        if (newRGB[i] < 0)
                        {
                            newRGB[i] = 0;
                        }
                    }
                    Color ct = Color.FromArgb(org.A, (int)newRGB[0], (int)newRGB[1], (int)newRGB[2]);
                    img.SetPixel(x, y, ct);
                }
            }
            pictureBoxAfter.Image = img;
        }

        private void buttonGamma_Click(object sender, EventArgs e)
        {
            double c = 1.0;
            double gamma = 2;
            Bitmap img = new Bitmap(pictureBoxAfter.Image);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color org = img.GetPixel(x, y);
                    double[] newRGB = { c * Math.Pow(org.R / 255.0, gamma) * 255.0,
                            c * Math.Pow(org.G / 255.0, gamma) * 255.0,
                            c * Math.Pow(org.B / 255.0, gamma) * 255.0};
                    for (int i = 0; i < newRGB.Length; i++)
                    {
                        if (newRGB[i] > 255)
                        {
                            newRGB[i] = 255;
                        }
                        if (newRGB[i] < 0)
                        {
                            newRGB[i] = 0;
                        }
                    }
                    Color ct = Color.FromArgb(org.A, (int)newRGB[0], (int)newRGB[1], (int)newRGB[2]);
                    img.SetPixel(x, y, ct);
                }
            }
            pictureBoxAfter.Image = img;
        }

        private void buttonBlur_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[0]);
        }

        private void buttonGauss_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[1]);
        }

        private void buttonSharp_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[2]);
        }

        private void buttonEdge_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[3]);
        }

        private void buttonEmboss_Click(object sender, EventArgs e)
        {
            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[4]);
        }

        private void maxAnchor()
        {
            numericUpDownAnchorX.Maximum = numericUpDownWidth.Value - 1;
            numericUpDownAnchorY.Maximum = numericUpDownHeight.Value - 1;
        }

        private void buttonGenerateMatrix_Click(object sender, EventArgs e)
        {
            int width = (int)numericUpDownWidth.Value;
            int height = (int)numericUpDownHeight.Value;

            tableLayoutPanelKernel.Controls.Clear();
            tableLayoutPanelKernel.ColumnCount = width;
            tableLayoutPanelKernel.RowCount = height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = "0";
                    textBox.Width = 30;
                    tableLayoutPanelKernel.Controls.Add(textBox);
                }
            }

            maxAnchor();
        }

        private void buttonIterate_Click(object sender, EventArgs e)
        {

        }

        private void buttonFactor_Click(object sender, EventArgs e)
        {
            int width = (int)tableLayoutPanelKernel.ColumnCount;
            int height = (int)tableLayoutPanelKernel.RowCount;

            double sum = 0;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    TextBox textbox = (TextBox)tableLayoutPanelKernel.GetControlFromPosition(x, y);
                    sum += double.Parse(textbox.Text);
                }
            }

            if (sum == 0)
            {
                sum = 1;
            }
            textBoxFactor.Text = sum.ToString();
        }

        private void textBoxFactor_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxFactor.Text == "0")
            {
                textBoxFactor.Text = "1";
                MessageBox.Show("Factor cannot be = 0!!!");
            }
        }

        private void buttonCustomSave_Click(object sender, EventArgs e)
        {
            int width = (int)tableLayoutPanelKernel.ColumnCount;
            int height = (int)tableLayoutPanelKernel.RowCount;

            double[,] matrix = new double[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    TextBox textbox = (TextBox)tableLayoutPanelKernel.GetControlFromPosition(x, y);
                    matrix[y, x] = double.Parse(textbox.Text);
                }
            }



            int bias = (int)numericUpDownOffset.Value;
            int factor = int.Parse(textBoxFactor.Text);
            string name = textBoxCustomName.Text;
            int anx = (int)numericUpDownAnchorX.Value;
            int any = (int)numericUpDownAnchorY.Value;

            if (SavedFilters.Count() > 5)
            {
                SavedFilters.RemoveAt(5);
                comboBoxFilterPick.Items.RemoveAt(5);
            }
            SavedFilters.Add(new CustomFilter(factor, bias, matrix, name, anx, any));
            comboBoxFilterPick.Items.Add(name);
        }

        private void buttonCustomApply_Click(object sender, EventArgs e)
        {

            pictureBoxAfter.Image = ConvFilterPrep.ConvolutionFilter((Bitmap)pictureBoxAfter.Image, SavedFilters[5]);
        }

        private void buttonLoadFilter_Click(object sender, EventArgs e)
        {
            ConvFilterBase filter = SavedFilters.ElementAt(comboBoxFilterPick.SelectedIndex);

            int width = (int)filter.FilterMatrix.GetLength(1);
            int height = (int)filter.FilterMatrix.GetLength(0);

            numericUpDownHeight.Value = height;
            numericUpDownWidth.Value = width;

            textBoxFactor.Text = filter.Factor.ToString();

            numericUpDownOffset.Value = (decimal)filter.Bias;

            tableLayoutPanelKernel.Controls.Clear();
            tableLayoutPanelKernel.ColumnCount = width;
            tableLayoutPanelKernel.RowCount = height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = filter.FilterMatrix[i, j].ToString();
                    textBox.Width = 30;
                    tableLayoutPanelKernel.Controls.Add(textBox);
                }
            }

            maxAnchor();
        }

    }
}