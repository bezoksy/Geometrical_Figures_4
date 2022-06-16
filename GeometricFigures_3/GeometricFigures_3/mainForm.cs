//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Windows.Forms;

namespace GeometricFigures_3
{
    partial class mainForm : Form
    {
        internal Figures figures = new Figures();

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {
            formMenu form = new formMenu((Button) sender, this);
            form.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            figures.Clear();
            panelBoard.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Graphic files(*.pic)|*.pic";
            if (saveDialog.ShowDialog() == DialogResult.Cancel)
                return;

            figures.Save(saveDialog.FileName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var loadDialog = new OpenFileDialog();
            loadDialog.Filter = "Graphic files(*.pic)|*.pic";
            if (loadDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                figures.Load(loadDialog.FileName);
                panelBoard.Invalidate();
            } catch
            {
                MessageBox.Show("Не удалось загрузить файл!");
            }
        }

        private void panelBoard_Paint(object sender, PaintEventArgs e)
        {
            figures.Draw(e.Graphics);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            this.btnColor.BackColor = this.colorDialog.Color;
        }
    }
}