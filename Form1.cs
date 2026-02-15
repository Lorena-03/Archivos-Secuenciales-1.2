using System.Data;
using System.Text;

namespace Archivos_secuenciales
{
    public partial class Form1 : Form
    {
        private string archivoActual = string.Empty;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            InicializarDataTable();
            ActualizarEstadoBotones();
        }

        private void InicializarDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Línea", typeof(int));
            dataTable.Columns.Add("Contenido", typeof(string));
            dgvArchivo.DataSource = dataTable;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Abrir Archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        archivoActual = openFileDialog.FileName;
                        LeerArchivo();
                        MostrarPropiedadesArchivo();
                        txtRutaArchivo.Text = archivoActual;
                        MessageBox.Show("Archivo abierto correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ActualizarEstadoBotones();
        }

        private void LeerArchivo()
        {
            if (string.IsNullOrEmpty(archivoActual) || !File.Exists(archivoActual))
                return;

            dataTable.Clear();
            string[] lineas = File.ReadAllLines(archivoActual, Encoding.UTF8);
            
            for (int i = 0; i < lineas.Length; i++)
            {
                dataTable.Rows.Add(i + 1, lineas[i]);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(archivoActual))
            {
                btnGuardarComo();
            }
            else
            {
                GuardarArchivo();
            }
        }

        private void btnGuardarComo()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar Archivo Como";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivoActual = saveFileDialog.FileName;
                    txtRutaArchivo.Text = archivoActual;
                    GuardarArchivo();
                }
            }
        }

        private void GuardarArchivo()
        {
            try
            {
                List<string> lineas = new List<string>();
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Contenido"] != null)
                    {
                        lineas.Add(row["Contenido"].ToString());
                    }
                }

                File.WriteAllLines(archivoActual, lineas, Encoding.UTF8);
                MostrarPropiedadesArchivo();
                MessageBox.Show("Archivo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea guardar los cambios antes de crear un nuevo archivo?", 
                    "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btnGuardar_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            archivoActual = string.Empty;
            txtRutaArchivo.Text = string.Empty;
            dataTable.Clear();
            dgvPropiedades.Rows.Clear();
            ActualizarEstadoBotones();
            MessageBox.Show("Nuevo archivo creado. Agregue contenido y use 'Guardar' para crear el archivo.", 
                "Nuevo Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(archivoActual) || !File.Exists(archivoActual))
            {
                MessageBox.Show("No hay un archivo abierto para renombrar.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Renombrar Archivo";
                saveFileDialog.FileName = Path.GetFileName(archivoActual);
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(archivoActual);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string nuevoNombre = saveFileDialog.FileName;
                        File.Move(archivoActual, nuevoNombre);
                        archivoActual = nuevoNombre;
                        txtRutaArchivo.Text = archivoActual;
                        MostrarPropiedadesArchivo();
                        MessageBox.Show("Archivo renombrado correctamente.", "Éxito", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al renombrar el archivo: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(archivoActual) || !File.Exists(archivoActual))
            {
                MessageBox.Show("No hay un archivo abierto para eliminar.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"¿Está seguro de que desea eliminar el archivo?\n{archivoActual}", 
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    File.Delete(archivoActual);
                    archivoActual = string.Empty;
                    txtRutaArchivo.Text = string.Empty;
                    dataTable.Clear();
                    dgvPropiedades.Rows.Clear();
                    ActualizarEstadoBotones();
                    MessageBox.Show("Archivo eliminado correctamente.", "Éxito", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el archivo: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            int nuevoNumero = dataTable.Rows.Count + 1;
            dataTable.Rows.Add(nuevoNumero, string.Empty);
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (dgvArchivo.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvArchivo.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvArchivo.Rows.Remove(row);
                    }
                }
                RenumerarLineas();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            RenumerarLineas();
            if (!string.IsNullOrEmpty(archivoActual) && File.Exists(archivoActual))
            {
                MostrarPropiedadesArchivo();
            }
            MessageBox.Show("Datos actualizados correctamente.", "Éxito", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RenumerarLineas()
        {
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["Línea"] = i + 1;
            }
        }

        private void btnExplorador_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleccione una carpeta para explorar archivos";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string carpetaSeleccionada = folderBrowserDialog.SelectedPath;
                    
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.InitialDirectory = carpetaSeleccionada;
                        openFileDialog.Filter = "Archivos de Texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
                        openFileDialog.Title = "Seleccionar Archivo";

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                archivoActual = openFileDialog.FileName;
                                LeerArchivo();
                                MostrarPropiedadesArchivo();
                                txtRutaArchivo.Text = archivoActual;
                                MessageBox.Show("Archivo abierto correctamente.", "Éxito", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al abrir el archivo: {ex.Message}", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            ActualizarEstadoBotones();
        }

        private void MostrarPropiedadesArchivo()
        {
            dgvPropiedades.Rows.Clear();

            if (string.IsNullOrEmpty(archivoActual) || !File.Exists(archivoActual))
                return;

            try
            {
                FileInfo fileInfo = new FileInfo(archivoActual);

                dgvPropiedades.Rows.Add("Nombre", fileInfo.Name);
                dgvPropiedades.Rows.Add("Ruta Completa", fileInfo.FullName);
                dgvPropiedades.Rows.Add("Directorio", fileInfo.DirectoryName);
                dgvPropiedades.Rows.Add("Extensión", fileInfo.Extension);
                dgvPropiedades.Rows.Add("Tamaño", $"{fileInfo.Length} bytes ({FormatearTamaño(fileInfo.Length)})");
                dgvPropiedades.Rows.Add("Creación", fileInfo.CreationTime.ToString("dd/MM/yyyy HH:mm:ss"));
                dgvPropiedades.Rows.Add("Última Modificación", fileInfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss"));
                dgvPropiedades.Rows.Add("Último Acceso", fileInfo.LastAccessTime.ToString("dd/MM/yyyy HH:mm:ss"));
                dgvPropiedades.Rows.Add("Solo Lectura", fileInfo.IsReadOnly ? "Sí" : "No");
                dgvPropiedades.Rows.Add("Atributos", fileInfo.Attributes.ToString());
                dgvPropiedades.Rows.Add("Número de Líneas", dataTable.Rows.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener propiedades: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatearTamaño(long bytes)
        {
            string[] sufijos = { "B", "KB", "MB", "GB", "TB" };
            int contador = 0;
            decimal tamaño = bytes;

            while (tamaño >= 1024 && contador < sufijos.Length - 1)
            {
                tamaño /= 1024;
                contador++;
            }

            return $"{tamaño:0.##} {sufijos[contador]}";
        }

        private void ActualizarEstadoBotones()
        {
            bool archivoExiste = !string.IsNullOrEmpty(archivoActual) && File.Exists(archivoActual);
            btnRenombrar.Enabled = archivoExiste;
            btnEliminar.Enabled = archivoExiste;
        }

        
        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleccione la ubicación donde desea crear la carpeta";
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string ubicacionBase = folderBrowserDialog.SelectedPath;

                    string nombreCarpeta = Microsoft.VisualBasic.Interaction.InputBox(
                        "Ingrese el nombre de la nueva carpeta:",
                        "Crear Carpeta",
                        "Nueva Carpeta",
                        -1, -1);

                    if (!string.IsNullOrWhiteSpace(nombreCarpeta))
                    {
                        try
                        {
                            string rutaNuevaCarpeta = Path.Combine(ubicacionBase, nombreCarpeta);

                            if (Directory.Exists(rutaNuevaCarpeta))
                            {
                                MessageBox.Show($"La carpeta '{nombreCarpeta}' ya existe en esta ubicación.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            Directory.CreateDirectory(rutaNuevaCarpeta);
                            MessageBox.Show($"Carpeta '{nombreCarpeta}' creada exitosamente en:\n{rutaNuevaCarpeta}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al crear la carpeta: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No hay contenido en el archivo para buscar.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string textoBuscar = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el texto que desea buscar:",
                "Buscar en Archivo",
                "",
                -1, -1);

            if (string.IsNullOrWhiteSpace(textoBuscar))
            {
                return;
            }

            try
            {
                dgvArchivo.ClearSelection();
                int coincidencias = 0;
                List<int> lineasEncontradas = new List<int>();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string contenido = dataTable.Rows[i]["Contenido"]?.ToString() ?? string.Empty;

                    if (contenido.IndexOf(textoBuscar, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        coincidencias++;
                        lineasEncontradas.Add(i + 1);
                        dgvArchivo.Rows[i].Selected = true;

                        if (coincidencias == 1)
                        {
                            dgvArchivo.FirstDisplayedScrollingRowIndex = i;
                        }
                    }
                }

                if (coincidencias > 0)
                {
                    string mensaje = $"Se encontraron {coincidencias} coincidencia(s) en las líneas:\n";
                    mensaje += string.Join(", ", lineasEncontradas);
                    MessageBox.Show(mensaje, "Resultados de Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontraron coincidencias para '{textoBuscar}'.",
                        "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la búsqueda: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
