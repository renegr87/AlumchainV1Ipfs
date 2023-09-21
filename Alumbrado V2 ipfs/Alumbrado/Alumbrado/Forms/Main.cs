using Alumbrado.Abstracts;
using Alumbrado.Models;
using Alumbrado.Services;
using Nethereum.Hex.HexTypes;
using Nethereum.Web3.Accounts;
using Nethereum.Web3;
using System;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Threading.Tasks;
using Nethereum.RPC.Eth.DTOs;
using System.Text;

namespace Alumbrado
{
    public partial class Main : Form
    {
        // File Dialog
        private string _InitialDirectory = "c:\\";
        private string _Filter = "Json files (*.json)|*.json";
        // Readings
        private Reading[] Readings;
        // Services 
        private IPublishService PublishService;

        public Main()
        {
            // TODO: DI
            PublishService = new PublishService();

            InitializeComponent();
        }

        #region Actions

        private void bt_load_Click(object sender, EventArgs e)
        {
            var source = GetSourceFromFile();
            if (source is not null)
            {
                try
                {
                    Readings = PublishService.LoadReadings(source);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void bt_publish_Click(object sender, EventArgs e)
        {
            if (Readings != null)
            {
                try
                {
                    var ipfsHash = await PublishToIPFSAsync();
                    MessageBox.Show($"El archivo se ha publicado en IPFS con hash: {ipfsHash}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al publicar en IPFS: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Primero debes cargar un archivo.");
            }
        }

        #endregion

        #region Private Methods

        private string? GetSourceFromFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = _InitialDirectory;
                openFileDialog.Filter = _Filter;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                var option = openFileDialog.ShowDialog();

                if (option == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    SetFile(filePath);
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        return fileContent = reader.ReadToEnd();
                    }
                }
                return null;
            }
        }

        private void SetFile(string filePath)
        {
            lb_file.Text = filePath;
            lb_valid.Text = "-";
        }

        private async Task<string> PublishToIPFSAsync()
        {
            var ipfsClient = new IpfsClient("http://127.0.0.1:8080"); // Cambia la URL según la configuración de tu nodo IPFS, aqui ya esta, se copio del local host, ENTRADA	http://127.0.0.1:8080, pero no indica si debe llevar API: /ip4/127.0.0.1/tcp/5001


            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(Readings))))
            {
                var file = new IpfsStreamWrapper(stream);
                var result = await ipfsClient.FileSystem.AddFileAsync(file);
                return result.Id.Hash.ToString();
            }
        }

        #endregion
    }

    internal class IpfsStreamWrapper
    {
        private MemoryStream stream;

        public IpfsStreamWrapper(MemoryStream stream)
        {
            this.stream = stream;
        }
    }
}
