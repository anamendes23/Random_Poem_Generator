/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Poem_Generator
{
    public partial class Form1 : Form
    {
        //list to hold random words
        List<string> catIpsumList = new List<string>();
        List<string> cupcakeIpsumList = new List<string>();
        List<string> coffeeIpsumList = new List<string>();
        List<string> customizedList = new List<string>();
        //paths
        string catPath = "catIpsum.txt";
        string cupcakePath = "cupcakeIpsum.txt";
        string coffeePath = "coffeeIpsum.txt";

        public Form1()
        {
            InitializeComponent();
            catIpsumList.Add(" aNahaA ");
            TextFileReader(catIpsumList, catPath);
            TextFileReader(cupcakeIpsumList, cupcakePath);
            TextFileReader(coffeeIpsumList, coffeePath);
        }

        private void TextFileReader(List<string> list, string path)
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                char[] separators = { ' ', ',', ':', '.', ';', '!', '?' };               

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split(separators);
                    for (int i = 0; i < words.Length; i++)
                    {
                        if(words[i]!="" || words[i] != " ")
                            list.AddRange(words);
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == "I")
                        continue;
                    list[i].ToLower().Trim();
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }

        private void GeneratePoem(List<string> list)
        {
            Random rand = new Random();
            richTextBox2.Clear();

            for (int i = 0; i < 9; i++)
            {
                if (i == 3 || i == 6)
                    richTextBox2.AppendText("\n");
                int nOfWords = rand.Next(3, 6);
                for (int j = 0; j < nOfWords; j++)
                {
                    int randIndex = rand.Next(0, list.Count - 1);
                    string word = list[randIndex];
                    richTextBox2.AppendText(word + " ");
                }
                richTextBox2.AppendText("\n");
            }
        }

        private void BtnCatPoem_Click(object sender, EventArgs e)
        {
            GeneratePoem(catIpsumList);
        }

        private void BtnCupcakePoem_Click(object sender, EventArgs e)
        {
            GeneratePoem(cupcakeIpsumList);
        }

        private void BtnCoffeePoem_Click(object sender, EventArgs e)
        {
            GeneratePoem(coffeeIpsumList);
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            try
            {
                string inputString = richTextBox1.Text;
                char[] separators = { ' ', ',', ':', '.', ';', '!', '?' };
                string[] words = inputString.Split(separators);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != "" || words[i] != " ")
                        customizedList.AddRange(words);
                }

                GeneratePoem(customizedList);
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
