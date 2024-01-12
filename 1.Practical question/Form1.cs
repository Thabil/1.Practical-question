using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _1.Practical_question
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private ArrayList wordsList = new ArrayList();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList concatedWords = new ArrayList();


            if (button2.Text == "Remove Item")
            {
                if (radioButton2.Checked)
                {
                    comboBox2.Items.Remove(comboBox2.SelectedItem);
                    MessageBox.Show("The word removed  ComboBox!");

                    if (radioButton1.Checked)
                    {
                        comboBox1.Items.Remove(comboBox1.SelectedItem);
                        MessageBox.Show($"The word removed  ComboBox!");

                    }
                }


            }

            else
            {
                if (comboBox1.SelectedItem == comboBox2.SelectedItem)
                {
                    MessageBox.Show("Select different words!");
                }

                else if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Combo boxes can't be empty");
                }

                else
                {
                    label5.Text = $"{comboBox1.SelectedItem}{comboBox2.SelectedItem}";
                    concatedWords.Add(label2.Text);

                    MessageBox.Show("The word is added to Collection now");

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();
            if (newWord.Length == 0)
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (wordsList.Contains(newWord))
            {
                MessageBox.Show("Word already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // if all checks pass, this will add the word entered to the array list
            wordsList.Add(newWord);
            //this will make the word added appear on the combobox lists
            comboBox1.Items.Add(newWord);
            comboBox2.Items.Add(newWord);

            wordsList.Add(newWord);
            MessageBox.Show("Word added to the collection.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "Remove Item";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "Remove Item";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}