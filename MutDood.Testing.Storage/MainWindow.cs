using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MutDood.Storage.Core.StorageElements;
using MutDood.Storage.Interfaces;
using MutDood.Storage.Interfaces.Core.Metadata;

namespace MutDood.Testing.Storage
{
    public partial class MainWindow : Form
    {
        private IStorage _storage;
        private IMetadataStorage _metadataStorage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateStorage_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                _storage = MutDood.Storage.Core.Storage.Create(StorageStrategy.Speed);
                _metadataStorage = (IMetadataStorage) _storage;
            }
        }

        private void btnSerializationTest_Click(object sender, EventArgs e)
        {
            if (_storage !=null)
            {
                var testStorable = new Storable();

                _storage.Save(testStorable); 
            }
            else
            {
                MessageBox.Show("Storage not initialized");
            }
        }

        private void btnCreateMetadata_Click(object sender, EventArgs e)
        {
            if (_storage != null)
            {
                var testStorable = new Storable();

                _storage.Save(testStorable);
            }
            else
            {
                MessageBox.Show("Storage not initialized");
            }
        }
    }
}
