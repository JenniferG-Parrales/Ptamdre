using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocNota
{
    public partial class Form1 : Form
    {
        private string directory;

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

           // DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            // treeView1.Nodes.Add(ReadFiles(directoryInfo));

        }

        private string ReadFiles(DirectoryInfo directoryInfo)
        {
            throw new NotImplementedException();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpen = new OpenFileDialog();
            StreamReader mLectura = null;

            mOpen.Filter = "Archivos de Textos (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            mOpen.Title = "Abrir archivo ";
            mOpen.FileName = "Sin titulo";
            mOpen.ShowDialog();
            mOpen.OpenFile();
            string RutArchivo = mOpen.FileName;
            mLectura = File.OpenText(RutArchivo);
            richTextBox1.Text = mLectura.ReadToEnd();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog mSave = new SaveFileDialog();
            StreamWriter mEscritura = null;

            mSave.Filter = "Archivos de Textos (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            mSave.Title = "Guardar como...";
            mSave.ShowDialog();
            string Ruta = mSave.FileName;
            mEscritura = File.AppendText(Ruta);
            mEscritura.Write(richTextBox1.Text);
            mEscritura.Flush();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            richTextBox1.Text = Fecha.ToString();
        }

        private void estiloDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog mFont = new FontDialog();
            mFont.Font = richTextBox1.Font;


            if (mFont.ShowDialog() == DialogResult.OK)

                richTextBox1.Font = mFont.Font;
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog mColor = new ColorDialog();
            if (mColor.ShowDialog() == DialogResult.OK) ;
            richTextBox1.ForeColor = mColor.Color;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Son las 1, matenme por favor");
        }
    }
}
