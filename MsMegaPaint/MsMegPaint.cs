using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace MsMegaPaint
{
    public partial class MsMegaPaint : Form
    {
        public enum Shapes  //Keep tabs on selected variant of shape.
        {
            Circle,
            Square,
            Triangle,
            Line,
            Pencil
        }

        private Stack<Shape> shapeStack;
        private Stack<Shape> redoStack;
        private Shape currentShape;
        private Shapes selectedShape;
        private Color selectedColor;
        private Point startPoint;
        private bool drawing;

        public MsMegaPaint()
        {
            InitializeComponent();
            shapeStack = new Stack<Shape>();
            redoStack = new Stack<Shape>();
            drawing = false;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)  //When user clicks on the picturebox we begin drawing.
        {
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;             //Drawing is in progress.
                startPoint = e.Location;    //The position of the click on the canvas.

                switch (selectedShape)  //based on selected shape, initialize subtype of Shape.
                {
                    case Shapes.Circle:
                        currentShape = new Circle { Center = startPoint, Radius = 0, Color = selectedColor };
                        break;
                    case Shapes.Square:
                        currentShape = new Square { TopLeft = startPoint, SideLength = 0, Color = selectedColor };
                        break;
                    case Shapes.Triangle:
                        currentShape = new Triangle { Color = selectedColor };
                        break;
                    case Shapes.Line:
                        currentShape = new Line { StartPoint = startPoint, Color = selectedColor };
                        break;
                    case Shapes.Pencil:
                        currentShape = new Pencil { Color = selectedColor };
                        break;
                }
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)  //When user moves the mouse. PictureBox is redrawn continually as this happens.
        {
            if (drawing && currentShape != null)    //If drawing is in progress. currentShape != null is a safeguard so we don't refer to a non-existing object.
            {
                currentShape.UpdateShape(startPoint, e.Location);   //Every Shape subclass has an UpdateShape metho, tho not all require both the parameters.
                pictureBox.Invalidate();                            //Update picturebox.
            }
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)    //When user let's go of the mousebutton.
        {
            if (e.Button == MouseButtons.Left && drawing)
            {
                drawing = false;                //We are no longer drawing.
                shapeStack.Push(currentShape);  //Push the new shape to to of stack.
                currentShape = null;            //Clear the shape, now that it is saved to shapeStack.
                pictureBox.Invalidate();
                using (Graphics g = pictureBox.CreateGraphics())    //Draw to picturebox.
                {
                    for (int i = shapeStack.Count - 1; i >= 0; i--) //Reverse order through the stack - otherwise older shapes appear on top of newer ones.
                    {
                        Shape shape = shapeStack.ElementAt(i);
                        shape.Draw(g);
                    }
                }
            }
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)  //This is called by pictureBox.Invalidate().
        {
            for (int i = shapeStack.Count - 1; i >= 0; i--)     //Draw shapes in stack.
            {
                Shape shape = shapeStack.ElementAt(i);
                shape.Draw(e.Graphics);
            }
            if (currentShape != null)                           //Draw currentShape if there is one (when the player is drawing an object).
                currentShape.Draw(e.Graphics);
        }
        private void undoButton_Click(object sender, EventArgs e)   //Undo button.
        {
            if (shapeStack.Count > 0)       //Check if there's anything to undo.
            {
                redoStack.Push(shapeStack.Pop());   //We remove the most recent shape.
                pictureBox.Invalidate();            //Redraw picturebox.
            }
        }
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)        //Anything to redo?
            {
                shapeStack.Push(redoStack.Pop());   //Put it back in shapeStack.
                pictureBox.Invalidate();
            }
        }
        private void saveShapesButton_Click(object sender, EventArgs e)     //Save shapeStack.
        {
            saveShapesDialog.Filter = "jsonx (*.jsonx)|*.jsonx";    //"x" makes it cool. Filter predetermines options for file type.
            DialogResult result = saveShapesDialog.ShowDialog();    //Display dialog for user. 

            if (result == DialogResult.OK)
            {
                string fileName = saveShapesDialog.FileName;        //Name set in dialog.

                string json = JsonConvert.SerializeObject(shapeStack, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All     //Writes info on what class the objects are, which is needed to unserialize the json correctly.
                });
                File.WriteAllText(fileName, json);
            }
        }
        private void loadShapesButton_Click(object sender, EventArgs e)     //Load shapeStack.
        {
            DialogResult result = openShapesDialog.ShowDialog(this);    //Display dialog for user. 

            if (result == DialogResult.OK)
            {
                string fileName = openShapesDialog.FileName;

                string json = File.ReadAllText(fileName);

                Stack<Shape> loadedShapes = JsonConvert.DeserializeObject<Stack<Shape>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All     //Allows the deserializer to create objects of the correct class.
                });

                shapeStack.Clear();     //Clears whatever might be in the shapeStack.
                foreach (Shape shape in loadedShapes)
                {
                    shapeStack.Push(shape);
                }

                pictureBox.Invalidate();
            }
        }
        private void saveBitmapButton_Click(object sender, EventArgs e)
        {
            saveBitmapDialog.Filter = "Bitmap Image (*.bmp)|*.bmp|PNG Image (*.png)|*.png|JPEG Image (*.jpeg;*.jpg)|*.jpeg;*.jpg"; //Filter predetermines options for file type.

            DialogResult result = saveBitmapDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = saveBitmapDialog.FileName;

                Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);    //New bitmap object of same dimensions as the picturebox.

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White); //We set the background color. Otherwise the result might be transparent, which is not what we want (in this case).

                    foreach (Shape shape in shapeStack) //Draw shapes from shapeStack to the bitmap.
                    {
                        shape.Draw(g);
                    }
                }
                bitmap.Save(fileName);

                bitmap.Dispose(); //Clears bitmap after use.
            }
        }
        #region ShapeButtons        //Sets selectedShape. One shape at a time, therefore grouped radio buttons. Also shows user which shape is selected.
        private void circleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shapes.Circle;
        }

        private void squareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shapes.Square;
        }

        private void triangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shapes.Triangle;
        }

        private void lineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shapes.Line;
        }

        private void pencilRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedShape = Shapes.Pencil;
        }
        #endregion  
        #region ColorButtons    //Sets selectedColor, as well as setting color of selectedColorBox to show user which color is selected.
        private void blackButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.Black;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.White;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.Red;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.Orange;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.Yellow;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.LawnGreen;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.DodgerBlue;
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            selectedColor = selectedColorBox.BackColor = Color.MediumOrchid;
        }
        #endregion      
    }
}