using System.Drawing;

namespace LifeDZ
{
    class Style
    {
        private Color _life;
        private Color _default;
        public Style()
        {
            _default = Color.Black;
            _life = Color.Green;
        }

        public Color TerraIncognita
        {
            get { return _default; }
        }

        public Color Life
        {
            get { return _life; }
        }
    }
}
