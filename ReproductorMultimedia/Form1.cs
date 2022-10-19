using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO; //para que funcione el fileinfo
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMultimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_lista_archivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = lb_lista_archivo.SelectedItem as MediaFile; //file puede ser "archivo" es variable
            if(file != null)//si es diferente a algo, es decir, si no se selecciona nada
            {
                mpmediaplayer.URL = file.Path;
                mpmediaplayer.Ctlcontrols.play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv"})
            {//para que njos permitan seleccionar archivos sin dejarlo vacio
                if (ofd.ShowDialog()==DialogResult.OK)//para abrir el cuadro de dialogo
                {
                    List<MediaFile> file = new List<MediaFile>();//Abre un archivo tipo vista
                    foreach(string FileName in ofd.FileNames)//foreach ya tiene incluida la bandera (i=0..) y todo eso para MATRICES
                    {
                        FileInfo fi = new FileInfo(FileName);
                        file.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName),
                        Path = fi.FullName}); //CARGAR LA LISTA DE ARCHIVOS
                    }
                    lb_lista_archivo.DataSource = file; //no se ayuda, si ve esto ¿me lo puede explicar porfavor?
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_lista_archivo.ValueMember = "Path"; //no se pero hace todo valido creo
            lb_lista_archivo.DisplayMember = "FileName";
        }
    }
}
