using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gelir_Gider_Takip
{
    public partial class GiderTipi_Ekle : Form
    {
        public GiderTipi_Ekle()
        {
            InitializeComponent();
        }

        private void GiderTipi_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int kontrol = Convert.ToInt16(glb.sql.Command("select count(*) from GIDER_TIPLERI where gdr_Gider_Kod = '" + txt_gider_kod + "'"));
            if (kontrol == 0)
            {
                glb.sql.Command(""
                         + "       INSERT INTO[dbo].[GIDER_TIPLERI] "
                         + "              ([gdr_Gider_Kod] "
                         + "              ,[gdr_Gider_Ad]) "
                         + "        VALUES "
                         + "              ( '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                         + "              , '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                         + ") ");
                if (glb.sql.exception == null)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            else
            {
                glb.sql.Command(""
                    + "    update [dbo].[GIDER_TIPLERI] set "
                    + "              "
                    + "               [gdr_Gider_Ad]  = '" + txt_gider_kod.Text + "' "//< gdr_Gider_Kod, nvarchar(50),> "
                    + "        where  gdr_Gider_Kod = '" + txt_gider_kod.Text + "'"
                    + " ");
                if (glb.sql.exception == null)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                }
            }


        }
    }
}
