using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingTrainingProgram
{
    public interface IAlgorithm
    {
        int[] _array { get; }
        string _name { get; }
        bool InAlgorithm { get; set; }
        string[] _codeArray { get; }
        List<int[]> _lastArray { get; }
        void setArray(Tile[] array);
        void NextStep(Label[] codeView, Tile[] Array, Form f);
        void LastStep(Tile[] Array);
        void ViewCose();
    }
}
