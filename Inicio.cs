using System;
using System.Drawing;
using System.Windows.Forms;

namespace Borrador
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        #region Sidebar
        bool sidebarExpand;
        bool QCollapse;
        bool BCollapse;
        bool CCollapse;
        bool ICollapse;
        bool SubCollapse;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            CambioLugarImagen();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void QTimer_Tick(object sender, EventArgs e)
        {
            if (QCollapse)
            {
                QContainer.Height += 10;
                if (QContainer.Height == QContainer.MaximumSize.Height)
                {
                    QCollapse = false;
                    QTimer.Stop();
                }
            }
            else
            {
                QContainer.Height -= 10;
                if (QContainer.Height == QContainer.MinimumSize.Height)
                {
                    QCollapse = true;
                    QTimer.Stop();
                }
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            QTimer.Start();
        }

        private void CTimer_Tick(object sender, EventArgs e)
        {
            if (CCollapse)
            {
                CContainer.Height += 10;
                if (CContainer.Height == CContainer.MaximumSize.Height)
                {
                    CCollapse = false;
                    CTimer.Stop();
                }
            }
            else
            {
                CContainer.Height -= 10;
                if (CContainer.Height == CContainer.MinimumSize.Height)
                {
                    CCollapse = true;
                    CTimer.Stop();
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CTimer.Start();
        }

        private void BTimer_Tick(object sender, EventArgs e)
        {
            if (BCollapse)
            {
                BContainer.Height += 10;
                if (BContainer.Height == BContainer.MaximumSize.Height)
                {
                    BCollapse = false;
                    BTimer.Stop();
                }
            }
            else
            {
                BContainer.Height -= 10;
                if (BContainer.Height == BContainer.MinimumSize.Height)
                {
                    BCollapse = true;
                    BTimer.Stop();
                }
            }
        }

        private void BButton_Click(object sender, EventArgs e)
        {
            BTimer.Start();
        }

        private void ITimer_Tick(object sender, EventArgs e)
        {
            if (ICollapse)
            {
                IContainer.Height += 10;
                if (IContainer.Height == IContainer.MaximumSize.Height)
                {
                    ICollapse = false;
                    ITimer.Stop();
                }
            }
            else
            {
                IContainer.Height -= 10;
                if (IContainer.Height == IContainer.MinimumSize.Height)
                {
                    ICollapse = true;
                    ITimer.Stop();
                }
            }
        }

        private void IButton_Click(object sender, EventArgs e)
        {
            ITimer.Start();
        }

        public void CambioLugarImagen()
        {
            if (sidebar.Width == sidebar.MaximumSize.Width)
            {
                panelImagen.Visible = false;
            }
            else if (sidebar.Width == sidebar.MinimumSize.Width)
            {
                panelImagen.Visible = true;
            }
        }


        #endregion

        private void btnNuestraEmpresa_Click(object sender, EventArgs e)
        {
          
        }
    }
}
