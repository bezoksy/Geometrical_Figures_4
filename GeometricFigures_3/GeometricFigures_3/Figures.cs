//Giniyatullin Ilyas 220P, GeometricFigures-4, 30.05.2022
using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GeometricFigures_3
{
    [Serializable]
    class Figures
    {
        List<Figure> figures;
        BinaryFormatter formatter = new BinaryFormatter();

        public Figures() 
        {
           figures = new List<Figure>();
        }

        public Figures(string path)
        {
            this.Load(path);
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Save(string path)
        {
            using (var fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, figures);
            }
        }

        public void Load(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {  
                figures = (List<Figure>)formatter.Deserialize(fs);
            }
        }

        public void Draw(Graphics graphics)
        {
            foreach(var f in figures)
            {
                f.Draw(graphics);
            }
        }

        public void Clear()
        {
            figures.Clear();
        }
    }
}