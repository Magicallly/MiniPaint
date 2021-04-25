using FiguresLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        FigureList figures = new FigureList();
        ICreator creator = null;
        Figure figure = null;

        Graphics g;

        Pen pen = new Pen(Color.Black, 3);

        public bool CanUndo => figures.ReadyFigures.Count > 0;
        public bool CanRedo => figures.UndoFigures.Count > 0;


        public void AddFigure(ICreator creator)
        {
            figures.AllCreators.Add(creator);
            comboBox1.Items.Add(creator.FigureName);
        }


        public struct FigureColorInfo
        {
            public string colorName;
            public Color color;
        }

        public struct FigureWidthInfo
        {
            public string widthValue;
            public float width;
        }

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

            //FigureButtonInfo[] figureButtonInfoArr = new FigureButtonInfo[]
            //{
            //    new FigureButtonInfo { figureName = new Line().FigureName, creator = new LineCreator() },
            //    new FigureButtonInfo { figureName = new Ellipse().FigureName, creator = new EllipseCreator() },
            //    new FigureButtonInfo { figureName = new FiguresLibrary.Rectangle().FigureName, creator = new RectangleCreator() },
            //    new FigureButtonInfo { figureName = new Rhombus().FigureName, creator = new RhombusCreator() },
            //    new FigureButtonInfo { figureName = new Polyline().FigureName, creator = new PolylineCreator() }
            //};

            FigureColorInfo[] figureColorInfoArr = new FigureColorInfo[]
            {
                new FigureColorInfo { colorName = "Черный", color = Color.Black  },
                new FigureColorInfo { colorName = "Красный", color = Color.Red },
                new FigureColorInfo { colorName = "Оранжевый", color = Color.Orange },
                new FigureColorInfo { colorName = "Желтый", color = Color.Yellow },
                new FigureColorInfo { colorName = "Зеленый", color = Color.Green },
                new FigureColorInfo { colorName = "Синий", color = Color.Blue },
                new FigureColorInfo { colorName = "Фиолетовый", color = Color.Purple },
                new FigureColorInfo { colorName = "Серый", color = Color.Gray },
            };

            FigureWidthInfo[] figureWidthInfoArr = new FigureWidthInfo[]
            {
                new FigureWidthInfo { widthValue = "1", width = 1 },
                new FigureWidthInfo { widthValue = "2", width = 2 },
                new FigureWidthInfo { widthValue = "3", width = 3 },
                new FigureWidthInfo { widthValue = "4", width = 4 },
                new FigureWidthInfo { widthValue = "5", width = 5}
            };

            int X = 1050;
            int Y = 150;
            RadioButton radioButton, radioButton1;
            foreach (var widthInfo in figureWidthInfoArr)
            {
                radioButton1 = new RadioButton();
                radioButton1.Name = widthInfo.widthValue;
                radioButton1.Text = widthInfo.widthValue;
                if (radioButton1.Name == "3")
                {
                    radioButton1.Checked = true;
                }
                radioButton1.CheckedChanged += new EventHandler(FigureWidth_ChechedChange);
                radioButton1.Location = new Point(X, Y);
                radioButton1.AutoSize = true;
                Y += 50;
                radioButton1.Tag = widthInfo.width;
                radioButton1.UseVisualStyleBackColor = true;
                Controls.Add(radioButton1);
            }

            X = 950;
            Y = 150;
            foreach (var colorInfo in figureColorInfoArr)
            {
                radioButton = new RadioButton();
                radioButton.Name = colorInfo.colorName;
                radioButton.Text = colorInfo.colorName;
                if (radioButton.Name == "Черный")
                {
                    radioButton.Checked = true;
                }
                radioButton.CheckedChanged += new EventHandler(FigureColor_CheckedChange);
                radioButton.Location = new Point(X, Y);
                radioButton.AutoSize = true;
                Y += 50;
                radioButton.Tag = colorInfo.color;
                radioButton.UseVisualStyleBackColor = true;
                Controls.Add(radioButton);
            }

            //Button button;
            //X = 850;
            //Y = 150;
            //foreach (var figureInfo in figureButtonInfoArr)
            //{
            //    button = new Button();
            //    button.Text = figureInfo.figureName;
            //    button.Tag = figureInfo.creator;
            //    button.Click += new EventHandler(FigureButton_Click);
            //    button.Location = new Point(X, Y);
            //    Y += 50;
            //    button.Name = figureInfo.figureName;
            //    button.Size = new Size(75, 23);
            //    button.UseVisualStyleBackColor = true;
            //    Controls.Add(button);

            //}

            AddFigure(new LineCreator());
            AddFigure(new EllipseCreator());
            AddFigure(new RectangleCreator());
            AddFigure(new PolylineCreator());
            AddFigure(new RhombusCreator());
        }

        public void FigureWidth_ChechedChange(object sender, EventArgs e)
        {
            RadioButton checkedItem = (RadioButton)sender;
            pen.Width = (float)checkedItem.Tag;
        }

        public void FigureColor_CheckedChange(object sender, EventArgs e)
        {
            RadioButton checkedItem = (RadioButton)sender;
            pen.Color = (Color)checkedItem.Tag;
        }

        private void FigureButton_Click(object sender, EventArgs e)
        {
            Button clickedItem = (Button)sender;
            creator = (ICreator)clickedItem.Tag;
            NewFigure();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(pnlDraw.BackColor);
            pnlDraw.BackColor = Color.Black;
            btnCanvasColor.BackColor = Color.White;
        }

        private void btnCanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pnlDraw.BackColor = c.Color;
                btnCanvasColor.BackColor = c.Color;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Serializer();
            serializer.Serialize(figures.ReadyFigures);
        }


        private void NewFigure()
        {
            if (figure != null)
            {
                if (figure.IsValid)
                {
                    figures.ReadyFigures.Add(figure);
                    figures.UndoFigures.Clear();
                }
            }
            figure = null;
            if (creator != null)
            {
                figure = creator.Create();
                figure.Pen = new Pen(pen.Color, pen.Width);
            }
        }

        public void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            foreach (var fig in figures.ReadyFigures)
            {
                fig.Draw(e.Graphics);
            }
            if (figure != null)
            {
                figure.Draw(e.Graphics);
            }
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                figure.MouseMove(e.Location);
                pnlDraw.Invalidate();
            }
        }

        private void pnlDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (figure == null)
            {
                NewFigure();
            }
            if (figure != null)
            {
                figure.MouseClick(e.Location);
            }
        }
        private void pnlDraw_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                NewFigure();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnlDraw.CreateGraphics();

            int startX = 50, finishX = 150;
            int startY = 50, finishY = 100;

            foreach (var crt in figures.AllCreators)
            {
                Figure fig = crt.Create();

                fig.Pen = new Pen(pen.Color, pen.Width);

                fig.Points.Clear();
                fig.MouseClick(new Point(startX, startY));
                fig.MouseClick(new Point(startX, finishY));
                fig.MouseClick(new Point((startX + finishX) / 2, startY));
                fig.MouseClick(new Point((startX + finishX) / 2, finishY));
                fig.MouseClick(new Point(finishX, startY));
                fig.MouseClick(new Point(finishX, finishY));
                fig.MouseMove(new Point(finishX, finishY));

                fig.Draw(graphics);

                startY += 75;
                finishY += 75;

                if (finishY > 400)
                {
                    startX += 150;
                    finishX += 150;
                    startY = 50;
                    finishY = 100;
                }
            }
            foreach (var readyfig in figures.ReadyFigures)
            {
                readyfig.Draw(graphics);
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Serializer();
            serializer.Deserialize(figures.ReadyFigures);
            pnlDraw.Invalidate();
            figure = null;
        }

        void Undo()
        {
            int last = figures.ReadyFigures.Count - 1;
            figures.UndoFigures.Add(figures.ReadyFigures[last]);
            figures.ReadyFigures.RemoveAt(last);
            pnlDraw.Invalidate();
        }
        void Redo()
        {
            int last = figures.UndoFigures.Count - 1;
            figures.ReadyFigures.Add(figures.UndoFigures[last]);
            figures.UndoFigures.RemoveAt(last);
            pnlDraw.Invalidate();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanUndo)
            {
                Undo();
            }
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanRedo)
            {
                Redo();
            }
        }


        private void rect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = ".dll";
            openDialog.Filter = "DLL files (*.dll)|*dll";
            openDialog.ShowDialog();
            string fileName = openDialog.FileName;
            try
            {
                var DLL = System.Reflection.Assembly.LoadFile(fileName);
                foreach (var type in DLL.GetTypes())
                {
                    if (type.Name.Contains("Creator") 
                            && !type.IsAbstract && !type.IsInterface)
                    {
                        AddFigure(DLL.CreateInstance(type.FullName) as ICreator);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            creator = figures.AllCreators[comboBox1.SelectedIndex];
            NewFigure();
        }
    }
}
 