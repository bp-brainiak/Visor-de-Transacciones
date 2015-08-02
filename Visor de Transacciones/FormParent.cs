using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visor_de_Transacciones.Forms;

namespace Visor_de_Transacciones
{
    public partial class FormParent : Form
    {
        public MenuStrip MenuStrip
        {
            get
            {
                return menuStrip;
            }

            set
            {
                menuStrip = value;
            }
        }
        public ToolStrip ToolStrip
        {
            get
            {
                return toolStrip;
            }

            set
            {
                toolStrip = value;
            }
        }
        public StatusStrip StatusStrip
        {
            get
            {
                return statusStrip;
            }

            set
            {
                statusStrip = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator1
        {
            get
            {
                return toolStripSeparator1;
            }

            set
            {
                toolStripSeparator1 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator2
        {
            get
            {
                return toolStripSeparator2;
            }

            set
            {
                toolStripSeparator2 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator3
        {
            get
            {
                return toolStripSeparator3;
            }

            set
            {
                toolStripSeparator3 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator4
        {
            get
            {
                return toolStripSeparator4;
            }

            set
            {
                toolStripSeparator4 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator5
        {
            get
            {
                return toolStripSeparator5;
            }

            set
            {
                toolStripSeparator5 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator6
        {
            get
            {
                return toolStripSeparator6;
            }

            set
            {
                toolStripSeparator6 = value;
            }
        }
        public ToolStripMenuItem PrintSetupToolStripMenuItem
        {
            get
            {
                return printSetupToolStripMenuItem;
            }

            set
            {
                printSetupToolStripMenuItem = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator7
        {
            get
            {
                return toolStripSeparator7;
            }

            set
            {
                toolStripSeparator7 = value;
            }
        }
        public ToolStripSeparator ToolStripSeparator8
        {
            get
            {
                return toolStripSeparator8;
            }

            set
            {
                toolStripSeparator8 = value;
            }
        }
        public ToolStripStatusLabel ToolStripStatusLabel
        {
            get
            {
                return toolStripStatusLabel;
            }

            set
            {
                toolStripStatusLabel = value;
            }
        }
        public ToolStripMenuItem AboutToolStripMenuItem
        {
            get
            {
                return aboutToolStripMenuItem;
            }

            set
            {
                aboutToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem TileHorizontalToolStripMenuItem
        {
            get
            {
                return tileHorizontalToolStripMenuItem;
            }

            set
            {
                tileHorizontalToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem FileMenu
        {
            get
            {
                return fileMenu;
            }

            set
            {
                fileMenu = value;
            }
        }
        public ToolStripMenuItem NewToolStripMenuItem
        {
            get
            {
                return newToolStripMenuItem;
            }

            set
            {
                newToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem OpenToolStripMenuItem
        {
            get
            {
                return openToolStripMenuItem;
            }

            set
            {
                openToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem SaveToolStripMenuItem
        {
            get
            {
                return saveToolStripMenuItem;
            }

            set
            {
                saveToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem SaveAsToolStripMenuItem
        {
            get
            {
                return saveAsToolStripMenuItem;
            }

            set
            {
                saveAsToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem PrintToolStripMenuItem
        {
            get
            {
                return printToolStripMenuItem;
            }

            set
            {
                printToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem PrintPreviewToolStripMenuItem
        {
            get
            {
                return printPreviewToolStripMenuItem;
            }

            set
            {
                printPreviewToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem ExitToolStripMenuItem
        {
            get
            {
                return exitToolStripMenuItem;
            }

            set
            {
                exitToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem EditMenu
        {
            get
            {
                return editMenu;
            }

            set
            {
                editMenu = value;
            }
        }
        public ToolStripMenuItem UndoToolStripMenuItem
        {
            get
            {
                return undoToolStripMenuItem;
            }

            set
            {
                undoToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem RedoToolStripMenuItem
        {
            get
            {
                return redoToolStripMenuItem;
            }

            set
            {
                redoToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem CutToolStripMenuItem
        {
            get
            {
                return cutToolStripMenuItem;
            }

            set
            {
                cutToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem CopyToolStripMenuItem
        {
            get
            {
                return copyToolStripMenuItem;
            }

            set
            {
                copyToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem PasteToolStripMenuItem
        {
            get
            {
                return pasteToolStripMenuItem;
            }

            set
            {
                pasteToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem SelectAllToolStripMenuItem
        {
            get
            {
                return selectAllToolStripMenuItem;
            }

            set
            {
                selectAllToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem ViewMenu
        {
            get
            {
                return viewMenu;
            }

            set
            {
                viewMenu = value;
            }
        }
        public ToolStripMenuItem ToolBarToolStripMenuItem
        {
            get
            {
                return toolBarToolStripMenuItem;
            }

            set
            {
                toolBarToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem StatusBarToolStripMenuItem
        {
            get
            {
                return statusBarToolStripMenuItem;
            }

            set
            {
                statusBarToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem ToolsMenu
        {
            get
            {
                return toolsMenu;
            }

            set
            {
                toolsMenu = value;
            }
        }
        public ToolStripMenuItem OptionsToolStripMenuItem
        {
            get
            {
                return optionsToolStripMenuItem;
            }

            set
            {
                optionsToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem WindowsMenu
        {
            get
            {
                return windowsMenu;
            }

            set
            {
                windowsMenu = value;
            }
        }
        public ToolStripMenuItem NewWindowToolStripMenuItem
        {
            get
            {
                return newWindowToolStripMenuItem;
            }

            set
            {
                newWindowToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem CascadeToolStripMenuItem
        {
            get
            {
                return cascadeToolStripMenuItem;
            }

            set
            {
                cascadeToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem TileVerticalToolStripMenuItem
        {
            get
            {
                return tileVerticalToolStripMenuItem;
            }

            set
            {
                tileVerticalToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem CloseAllToolStripMenuItem
        {
            get
            {
                return closeAllToolStripMenuItem;
            }

            set
            {
                closeAllToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem ArrangeIconsToolStripMenuItem
        {
            get
            {
                return arrangeIconsToolStripMenuItem;
            }

            set
            {
                arrangeIconsToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem HelpMenu
        {
            get
            {
                return helpMenu;
            }

            set
            {
                helpMenu = value;
            }
        }
        public ToolStripMenuItem ContentsToolStripMenuItem
        {
            get
            {
                return contentsToolStripMenuItem;
            }

            set
            {
                contentsToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem IndexToolStripMenuItem
        {
            get
            {
                return indexToolStripMenuItem;
            }

            set
            {
                indexToolStripMenuItem = value;
            }
        }
        public ToolStripMenuItem SearchToolStripMenuItem
        {
            get
            {
                return searchToolStripMenuItem;
            }

            set
            {
                searchToolStripMenuItem = value;
            }
        }
        public ToolStripButton NewToolStripButton
        {
            get
            {
                return newToolStripButton;
            }

            set
            {
                newToolStripButton = value;
            }
        }
        public ToolStripButton OpenToolStripButton
        {
            get
            {
                return openToolStripButton;
            }

            set
            {
                openToolStripButton = value;
            }
        }
        public ToolStripButton SaveToolStripButton
        {
            get
            {
                return saveToolStripButton;
            }

            set
            {
                saveToolStripButton = value;
            }
        }
        public ToolStripButton PrintToolStripButton
        {
            get
            {
                return printToolStripButton;
            }

            set
            {
                printToolStripButton = value;
            }
        }
        public ToolStripButton PrintPreviewToolStripButton
        {
            get
            {
                return printPreviewToolStripButton;
            }

            set
            {
                printPreviewToolStripButton = value;
            }
        }
        public ToolStripButton HelpToolStripButton
        {
            get
            {
                return helpToolStripButton;
            }

            set
            {
                helpToolStripButton = value;
            }
        }
        public ToolTip ToolTip
        {
            get
            {
                return toolTip;
            }

            set
            {
                toolTip = value;
            }
        }
        public ToolStripComboBox ToolStripComboBox1
        {
            get
            {
                return toolStripComboBox1;
            }

            set
            {
                toolStripComboBox1 = value;
            }
        }
        private int childFormNumber = 0;

        public FormParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
           // Form childForm = new Form();
            FrmConexionBaseDeDatos childForm = new FrmConexionBaseDeDatos();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip.Visible = ToolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip.Visible = StatusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
