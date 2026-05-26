using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AL3_keisanki
{
    public partial class Form1 : Form
    {
        //フィールド
        int test = 0;
        int[] array = new int[5];   //１つ目の値の配列
        int[] array2 = new int[5];  //２つ目の値の配列
        int arrayIndex = 0;         //1つ目の値の桁数カウンタ
        int arrayIndex2 = 0;        //2つ目の値の桁数カウンタ
        int mode = 0;               //計算のモードを決める変数


        /*-----memo-----
         * ---メソッドの説明(雑)---
         *・inputArray() ：押されたボタンの数字を配列に入力するメソッド。
         *・showArray()  ：配列に入力された値をラベルに表示するメソッド。
         *・arrayToInt() ：配列を数値に変換する数値を返すメソッド。
         *・calculate()  ：実際に計算して数値を返すメソッド。modeの値によって計算の種類が変わる。
         * 
         *・modeの値によって，arrayに入力するかarray2に入力するかを分ける。
         *　mode = 0　→　１つ目の値の入力
         *　mode = 1　→　足し算
         *　mode = 2　→　引き算
         *　mode = 3　→　掛け算
         *　mode = 4　→　割り算(整数型)
         *　-----------
         *　mode = 0      :1つ目の値入力モード
         *　mode = 0以外  :２つ目の値入力モード
         */


        public Form1()
        {
            InitializeComponent();
        }

        //----「0」～「9」の数字ボタン----
        private void button1_Click(object sender, EventArgs e)
        {
            //「１」ボタン
            test = 1;
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if(mode != 0)
            {
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //「２」ボタン
            test = 2;
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //「３」ボタン
            test = 3;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //「４」ボタン
            test = 4;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //「５」ボタン
            test = 5;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //「６」ボタン
            test = 6;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //「７」ボタン
            test = 7;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //「８」ボタン
            test = 8;
            //inputArray(test, arrayIndex, array);
            //showArray(array, arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //「９」ボタン
            test = 9;
            //inputArray(test, arrayIndex, array);
            //showArray(array,arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //「０」ボタン
            test = 0;
            //inputArray(test, arrayIndex, array);
            //showArray(array,arrayIndex);
            if (mode == 0)
            {
                inputArray(test, arrayIndex, array);
                showArray(array, arrayIndex);
            }
            if (mode != 0)
            {
                /*inputArray2(test, arrayIndex2, array2);
                showArray(array2, arrayIndex2);
                */
                array2[arrayIndex2] = test;
                if (arrayIndex2 < array2.Length + 1)
                {
                    arrayIndex2++;
                }
                showArray(array2, arrayIndex2);

            }
        }
        //----


        //「+」ボタン
        private void button14_Click(object sender, EventArgs e)
        {
            //+ボタン
            label1.Text = "+";
            mode = 1;
        }


        //「－」ボタン
        private void button11_Click(object sender, EventArgs e)
        {
            //-ボタン
            label1.Text = "-";
            mode = 2;
        }


        //「×」ボタン
        private void button15_Click(object sender, EventArgs e)
        {
            //×ボタン
            label1.Text = "×";
            mode = 3;
        }


        //「÷」ボタン
        private void button12_Click(object sender, EventArgs e)
        {
            //÷ボタン
            label1.Text = "÷";
            mode = 4;
        }


        //「＝」ボタン
        private void button13_Click(object sender, EventArgs e)
        {
            //「＝」ボタン
            label1.Text = calculate(array, array2, arrayIndex, arrayIndex2, mode).ToString();
        }


        //CLRボタン
        private void button16_Click(object sender, EventArgs e)
        {
            //CLRボタン
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            arrayIndex = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = 0;
            }
            arrayIndex2 = 0;
            mode = 0;
            showArray(array, arrayIndex);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void inputArray (int inNum,int index, int[] inArray)
        {
            if (index < array.Length)
            {
                array[index] = inNum;
                if (arrayIndex < inArray.Length+1)
                arrayIndex++;
            }
        }

        private void showArray(int[] array, int index)
        {
            string str = "";
            for (int i = 0; i < index; i++)
            {
                str += array[i].ToString();
            }
            label1.Text = str;
        }

        private int calculate (int[] array1, int[] array2, int array1Index, int array2Index, int mode) {
            int num1 = arrayToInt(array1,array1Index);
            int num2 = arrayToInt(array2,array2Index);
            if (mode == 1)
            {
                return num1 + num2;
            }
            else if(mode == 2)
            {
                return num1 - num2;
            }
            else if(mode == 3)
            {
                return num1 * num2;
            }
            else if(mode == 4)
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    MessageBox.Show("0で割ることはできません。");
                    return 0;
                }
            }
            else { return 0; }
        }

        private int arrayToInt(int[] array, int index)
        {
            int num = 0;
            for (int i = 0; i < index; i++)
            {
                num += array[i] * (int)Math.Pow(10, index - i - 1);
            }
            return num;
        }



        //デバック用ボタン
        private void button18_Click(object sender, EventArgs e)
        {
            //デバック用ボタン
            //array2の値を表示する
            showArray(array2, 5);
        }

        
    }
}
