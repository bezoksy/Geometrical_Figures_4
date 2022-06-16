//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeometricFigures_3
{
    partial class formMenu : Form
    {
        string buttonFigureName;
        mainForm mainForm;
        MaskedTextBox mTxtBoxCircleRadius;
        TextBox txtBoxPoint2X;
        TextBox txtBoxPoint2Y;
        TextBox txtBoxPoint3X;
        TextBox txtBoxPoint3Y;
        TextBox txtBoxRectangleWidth;
        TextBox txtBoxRectangleHeight;

        public formMenu()
        {
            InitializeComponent();
        }

        public formMenu(Button buttonSender, mainForm form)
        {
            InitializeComponent();
            mainForm = form;
            buttonFigureName = buttonSender.Name;

            switch (buttonSender.Name)
            {
                case "btnCircle":
                    //label Radius
                    Label lblRadius = new Label();
                    lblRadius.Text = "Радиус";
                    lblRadius.Location = new System.Drawing.Point(65, 68);
                    this.Controls.Add(lblRadius);

                    //TextBox Radius
                    mTxtBoxCircleRadius = new MaskedTextBox();
                    mTxtBoxCircleRadius.Location = new System.Drawing.Point(42, 95);
                    mTxtBoxCircleRadius.Mask = "000";
                    this.Controls.Add(mTxtBoxCircleRadius);

                    //Button Draw
                    this.btnDraw.Location = new System.Drawing.Point(60, 125);
                    this.MaximumSize = new Size(200, 200);
                    break;
                case "btnLine":
                    //label Point2
                    Label lblPoint2 = new Label();
                    lblPoint2.Text = "Вторая точка";
                    lblPoint2.Location = new System.Drawing.Point(45,68);
                    this.Controls.Add(lblPoint2);

                    //label Point2X
                    Label lblPoint2X = new Label();
                    lblPoint2X.Text = "X";
                    lblPoint2X.Width = 20;
                    lblPoint2X.Location = new System.Drawing.Point(23, 97);
                    this.Controls.Add(lblPoint2X);

                    //TextBox Point2X
                    txtBoxPoint2X = new TextBox();
                    txtBoxPoint2X.Width = 38;
                    txtBoxPoint2X.Location = new System.Drawing.Point(43, 93);
                    this.Controls.Add(txtBoxPoint2X);

                    //label Point2Y
                    Label lblPoint2Y = new Label();
                    lblPoint2Y.Text = "Y";
                    lblPoint2Y.Width = 20;
                    lblPoint2Y.Location = new System.Drawing.Point(90, 97);
                    this.Controls.Add(lblPoint2Y);

                    //TextBox Point2Y
                    txtBoxPoint2Y = new TextBox();
                    txtBoxPoint2Y.Width = 38;
                    txtBoxPoint2Y.Location = new System.Drawing.Point(110, 93);
                    this.Controls.Add(txtBoxPoint2Y);

                    //Button Draw
                    this.btnDraw.Location = new System.Drawing.Point(60, 125);
                    this.MaximumSize = new Size(200, 200);
                    break;
                case "btnTriangle":
                    //label Point2
                    lblPoint2 = new Label();
                    lblPoint2.Text = "Вторая точка";
                    lblPoint2.Location = new System.Drawing.Point(45, 68);
                    this.Controls.Add(lblPoint2);

                    //label Point2X
                    lblPoint2X = new Label();
                    lblPoint2X.Text = "X";
                    lblPoint2X.Width = 20;
                    lblPoint2X.Location = new System.Drawing.Point(23, 97);
                    this.Controls.Add(lblPoint2X);

                    //TextBox Point2X
                    txtBoxPoint2X = new TextBox();
                    txtBoxPoint2X.Width = 38;
                    txtBoxPoint2X.Location = new System.Drawing.Point(43, 93);
                    this.Controls.Add(txtBoxPoint2X);

                    //label Point2Y
                    lblPoint2Y = new Label();
                    lblPoint2Y.Text = "Y";
                    lblPoint2Y.Width = 20;
                    lblPoint2Y.Location = new System.Drawing.Point(90, 97);
                    this.Controls.Add(lblPoint2Y);

                    //TextBox Point2Y
                    txtBoxPoint2Y = new TextBox();
                    txtBoxPoint2Y.Width = 38;
                    txtBoxPoint2Y.Location = new System.Drawing.Point(110, 93);
                    this.Controls.Add(txtBoxPoint2Y);

                    //label Point3
                    lblPoint2 = new Label();
                    lblPoint2.Text = "Третья точка";
                    lblPoint2.Location = new System.Drawing.Point(45, 130);
                    this.Controls.Add(lblPoint2);

                    //label Point3X
                    Label lblPoint3X = new Label();
                    lblPoint3X.Text = "X";
                    lblPoint3X.Width = 20;
                    lblPoint3X.Location = new System.Drawing.Point(23, 156);
                    this.Controls.Add(lblPoint3X);

                    //TextBox Point3X
                    txtBoxPoint3X = new TextBox();
                    txtBoxPoint3X.Width = 38;
                    txtBoxPoint3X.Location = new System.Drawing.Point(43, 156);
                    this.Controls.Add(txtBoxPoint3X);

                    //label Point3Y
                    Label lblPoint3Y = new Label();
                    lblPoint3Y.Text = "Y";
                    lblPoint3Y.Width = 20;
                    lblPoint3Y.Location = new System.Drawing.Point(90, 156);
                    this.Controls.Add(lblPoint3Y);

                    //TextBox Point3Y
                    txtBoxPoint3Y = new TextBox();
                    txtBoxPoint3Y.Width = 38;
                    txtBoxPoint3Y.Location = new System.Drawing.Point(110, 156);
                    this.Controls.Add(txtBoxPoint3Y);

                    //Button Draw
                    this.btnDraw.Location = new System.Drawing.Point(60, 200);
                    this.MaximumSize = new Size(200, 300);
                    break;
                case "btnRectangle":
                    //label Width
                    Label lblWidth = new Label();
                    lblWidth.Text = "Ширина";
                    lblWidth.Location = new System.Drawing.Point(65, 68);
                    this.Controls.Add(lblWidth);

                    //TextBox Width
                    txtBoxRectangleWidth = new TextBox();
                    txtBoxRectangleWidth.Location = new System.Drawing.Point(42, 95);
                    this.Controls.Add(txtBoxRectangleWidth);

                    //label Height
                    Label lblHeight = new Label();
                    lblHeight.Text = "Высота";
                    lblHeight.Location = new System.Drawing.Point(65, 130);
                    this.Controls.Add(lblHeight);

                    //TextBox Height
                    txtBoxRectangleHeight = new TextBox();
                    txtBoxRectangleHeight.Location = new System.Drawing.Point(42, 156);
                    this.Controls.Add(txtBoxRectangleHeight);

                    //Button Draw
                    this.btnDraw.Location = new System.Drawing.Point(60, 200);
                    this.MaximumSize = new Size(200, 300);
                    break;
                default:
                    throw new Exception("Button not founded!");
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Figure figure = null;

            try
            {
                var startingPointX = int.Parse(this.txtBoxStartPointX.Text);
                var startingPointY = int.Parse(this.txtBoxStartPointY.Text);
                var color = mainForm.btnColor.BackColor;
                var thickness = mainForm.tBarThickness.Value;

                switch (buttonFigureName)
                {
                    case "btnCircle":
                        figure = new Circle(new Point(startingPointX, startingPointY),
                                            int.Parse(this.mTxtBoxCircleRadius.Text),
                                            color,thickness);
                        break;
                    case "btnLine":
                        figure = new Line(new Point(startingPointX, startingPointY),
                                          new Point(int.Parse(txtBoxPoint2X.Text),
                                          int.Parse(txtBoxPoint2Y.Text)),
                                          color, thickness);
                        break;
                    case "btnTriangle":
                        figure = new Triangle(new Point(startingPointX, startingPointY),
                                              new Point(int.Parse(txtBoxPoint2X.Text),
                                              int.Parse(txtBoxPoint2Y.Text)),
                                              new Point(int.Parse(txtBoxPoint3X.Text),
                                              int.Parse(txtBoxPoint3Y.Text)),
                                              color, thickness);
                        break;
                    case "btnRectangle":
                        figure = new Rectangle(new Point(startingPointX, startingPointY),
                                          int.Parse(txtBoxRectangleWidth.Text),
                                          int.Parse(txtBoxRectangleHeight.Text),
                                          color, thickness);
                        break;
                }

                try
                {
                    mainForm.figures.Add(figure);
                    mainForm.panelBoard.Invalidate();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось добавить фигуру!");
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные!");
            }            
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }
    }
}