using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingTrainingProgram
{
    internal class ShakerSort : IAlgorithm
    {
        public bool InAlgorithm { get; set; } = false;
        public string _name { get; } = "Shaker Sort";
        public int[] _array { get; } = new int[10];

        public List<int[]> _lastArray { get; } = new List<int[]>();

        public string[] _codeArray => throw new NotImplementedException();

        int i = 1;
        private int left = 0;
        private int right = 9;

        private int[] _Sort = new int[10];
        public ShakerSort() { }

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
        // Swap випратити повторення
        public async void NextStep(Label[] labels, Tile[] Array, Form f)
        {
            if (!Equal(_array))
            {

                for (int i = right; i > left; --i)
                {
                    Array[i]._Label.BackColor = Color.IndianRed;
                    Array[i - 1]._Label.BackColor = Color.IndianRed;
                    await Task.Delay(300);
                    if (_array[i - 1] > _array[i])
                    {
                        Array[i]._Label.BackColor = Color.Red;
                        Array[i - 1]._Label.BackColor = Color.Blue;
                        await Task.Delay(600);

                        int temp = _array[i];
                        string temp1 = Array[i]._Label.Text;
                        _array[i] = _array[i - 1];
                        _array[i - 1] = temp;
                        await Task.Delay(160);
                        Array[i - 1]._Label.BackColor = Color.Red;
                        Array[i]._Label.BackColor = Color.Blue;
                        Array[i]._Label.Text = Array[i - 1]._Label.Text;


                        Array[i]._Label.Text = Array[i - 1]._Label.Text;
                        Array[i - 1]._Label.Text = temp1;

                        await Task.Delay(460);
                        Array[i]._Label.BackColor = Tile._default;
                        Array[i - 1]._Label.BackColor = Tile._default;

                        f.Invalidate();
                    }
                    await Task.Delay(300);
                    Array[i]._Label.BackColor = Tile._default;
                    Array[i - 1]._Label.BackColor = Tile._default;
                }

                ++left;
                for (int i = left; i < right; ++i)
                {
                    Array[i]._Label.BackColor = Color.IndianRed;
                    Array[i + 1]._Label.BackColor = Color.IndianRed;
                    await Task.Delay(300);
                    if (_array[i] > _array[i + 1])
                    {
                        Array[i]._Label.BackColor = Color.Red;
                        Array[i + 1]._Label.BackColor = Color.Blue;
                        await Task.Delay(600);

                        int temp = _array[i];
                        string temp1 = Array[i]._Label.Text;
                        _array[i] = _array[i + 1];
                        _array[i + 1] = temp;
                        await Task.Delay(160);
                        Array[i + 1]._Label.BackColor = Color.Red;
                        Array[i]._Label.BackColor = Color.Blue;
                        Array[i]._Label.Text = Array[i + 1]._Label.Text;


                        Array[i]._Label.Text = Array[i + 1]._Label.Text;
                        Array[i + 1]._Label.Text = temp1;

                        await Task.Delay(460);
                        Array[i]._Label.BackColor = Tile._default;
                        Array[i + 1]._Label.BackColor = Tile._default;


                        f.Invalidate();
                    }
                    await Task.Delay(300);
                    Array[i]._Label.BackColor = Tile._default;
                    Array[i + 1]._Label.BackColor = Tile._default;
                }

                --right;



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
