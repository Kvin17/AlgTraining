using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingTrainingProgram
{
    class BubbleSort : IAlgorithm
    {
        public bool InAlgorithm { get; set; } = false;
        public string _name { get; } = "Bubble Sort";
        public int[] _array { get; } = new int[10];
        public List<int[]> _lastArray { get; } = new List<int[]>();
        private int i = 1;
        private int[] _Sort = new int[10];
        public BubbleSort() { }
       
       public string[] _codeArray { get; } = new string[]
       {"for (int write = 0; write<arr.Length; write++) {",
       "    for (int sort = 0; sort<arr.Length - 1; sort++) {",
       "        if (arr[sort] > arr[sort + 1]) {",
       "            temp = arr[sort + 1];",
       "            arr[sort + 1] = arr[sort];",
       "            arr[sort] = temp;",
       "}}}"};
       
        public void setArray(Tile[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = int.Parse(array[i]._Label.Text);
                _Sort[i] = _array[i];
            }
            _lastArray.Add(new int[] { _array[0], _array[1], _array[2], _array[3], _array[4], _array[5]
            ,_array[6],_array[7],_array[8],_array[9]});
            Array.Sort<int>(_Sort);
           
        }
        public async void NextStep(Label[] labels, Tile[] Array, Form f)
        {
            if (!Equal(_array))
            {
                labels[0].ForeColor = Color.White;
                labels[1].ForeColor= Color.Red;
                for (int j = 0; j < _array.Length - i; j++)
                {
                    Array[j]._Label.BackColor = Color.IndianRed;
                    Array[j + 1]._Label.BackColor = Color.IndianRed;
                    await Task.Delay(300);
                    labels[1].ForeColor = Color.White;
                    labels[2].ForeColor = Color.Red;
                    if (_array[j] > _array[j + 1])
                    {
                        Array[j]._Label.BackColor = Color.Red;
                        Array[j + 1]._Label.BackColor = Color.Blue;
                        //Array[j].DrawLines(g, Array[j + 1]);
                        await Task.Delay(600);
                        labels[2].ForeColor = Color.White;
                        labels[3].ForeColor = Color.Red;
                        int temp = _array[j];
                        string temp1 = Array[j]._Label.Text;

                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                        await Task.Delay(160);
                        labels[3].ForeColor = Color.White;
                        labels[4].ForeColor = Color.Red;
                        Array[j + 1]._Label.BackColor = Color.Red;
                        Array[j]._Label.BackColor = Color.Blue;

                        Array[j]._Label.Text = Array[j + 1]._Label.Text;


                        Array[j]._Label.Text = Array[j + 1]._Label.Text;
                        Array[j + 1]._Label.Text = temp1;
                        //await Task.Delay(160);
                        await Task.Delay(460);
                        labels[4].ForeColor = Color.White;
                        labels[5].ForeColor = Color.Red;
                        Array[j]._Label.BackColor = Tile._default;
                        Array[j + 1]._Label.BackColor = Tile._default;

                        f.Invalidate();
                    }
                    await Task.Delay(300);
                    labels[4].ForeColor = Color.White;
                    labels[5].ForeColor = Color.White;
                    labels[6].ForeColor = Color.Red;
                    labels[0].ForeColor = Color.Red;
                    Array[j]._Label.BackColor = Tile._default;
                    Array[j + 1]._Label.BackColor = Tile._default;
                }
                i++;

                for (int k = 0; k < Array.Length; k++)
                {
                    Array[k]._Label.Text = $"{_array[k]}";
                }

                _lastArray.Add(new int[] { _array[0], _array[1], _array[2], _array[3], _array[4], _array[5]
                        ,_array[6],_array[7],_array[8],_array[9]});
            }
            else
            {
                MessageBox.Show("Масив відсортовано");
            }
            InAlgorithm = false;
        }
        public void LastStep(Tile[] Array)
        {
            if (i - 1 > 0)
            {
                i--;
                _lastArray.RemoveAt(_lastArray.Count - 1);

                for (int j = 0; j < Array.Length; j++)
                {
                    Array[j]._Label.Text = $"{_lastArray[i - 1][j]}";
                    _array[j] = _lastArray[i - 1][j];
                }
            }
        }
        public void ViewCose()
        {

        }
        private bool Equal(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == _Sort[i]) { }

                else return false;
            }
            return true;
        }
    }
}
