using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindACouple
{
    internal class Picture
    {
        public Image Image { get;private set; }
        public int Id { get; private set; }
        public Picture(Image image,int id)
        {
            Id = id;
            Image = image;
        }
    }
}
