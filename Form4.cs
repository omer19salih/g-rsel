using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Manavodev2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        // Kişileri listelemek için metot oluşturacağız
        void KisileriListele()
        {
           baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\salih ömer\\OneDrive\\Belgeler\\Database4.accdb;");

            baglanti.Open();
            da = new OleDbDataAdapter("SELECT * FROM manav", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

            listView1.Items.Clear(); // ListView'i temizle
            listView1.View = View.Details; // Detaylı görünüm modunu aç
            listView1.Columns.Clear();

            // Kolonları ekleyelim
            foreach (DataColumn column in tablo.Columns)
            {
                listView1.Columns.Add(column.ColumnName, 100);
            }

            // Verileri ekleyelim
            foreach (DataRow row in tablo.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < tablo.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }
     

        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO manav (Katagori, Urunadi, Fiyat, Stok) VALUES (@Katagori, @Urunadi, @Fiyat, @Stok)";
            baglanti.Open();
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Katagori", textkatogori.Text);
            komut.Parameters.AddWithValue("@Urunadi", texturunadi.Text);
            komut.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(textfiyat.Text)); // Sayı olduğundan emin ol
            komut.Parameters.AddWithValue("@Stok", Convert.ToInt32(textstok.Text)); // Sayı olduğundan emin ol
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriListele();
        }

        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM manav WHERE Barkodno=@Barkodno";
            baglanti.Open();
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Barkodno", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // İlk sütun Barkodno olarak varsayılıyor
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriListele();
        }

        private void buttonGüncelle_Click_1(object sender, EventArgs e)
        {
            string sorgu = "UPDATE manav SET Katagori=@Katagori, Urunadi=@Urunadi, Fiyat=@Fiyat, Stok=@Stok WHERE Barkodno=@Barkodno";
            baglanti.Open();
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kategori", textkatogori.Text);
            komut.Parameters.AddWithValue("@Urunadi", texturunadi.Text);
            komut.Parameters.AddWithValue("@Fiyat", Convert.ToDouble(textfiyat.Text));
            komut.Parameters.AddWithValue("@Stok", Convert.ToInt32(textstok.Text));
            komut.Parameters.AddWithValue("@Barkodno", Convert.ToInt32(textbarkodno.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriListele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            textbarkodno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textkatogori.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            texturunadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textstok.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                textbarkodno.Text = item.SubItems[0].Text;
                textkatogori.Text = item.SubItems[1].Text;
                texturunadi.Text = item.SubItems[2].Text;
                textfiyat.Text = item.SubItems[3].Text;
                textstok.Text = item.SubItems[4].Text;
            }
            // textbarkodno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); DataGridView'ın seçili satırındaki ilk hücrenin değerini alır, bu değeri metin formatına dönüştürür ve ardından textbarkodno.Text'a atar. Yani, textbarkodno adındaki bir TextBox'ın içine bu hücrenin değeri yazılır.
            //listView.SelectedItems.Count > 0, bir ListView kontrolündeki seçili öğelerin sayısının 0'dan büyük olup olmadığını kontrol eder. Yani, bu koşul, ListView kontrolünde en az bir öğe seçildiyse true değerini döner.
            //AddWithValue kullanmak, parametreleri daha dinamik bir şekilde SQL sorgusuna eklemenize olanak tanır ve SQL Injection gibi güvenlik açıklarına karşı koruma sağlar.
            //SelectedItems Kullanıcı, bir ürün listesinde veya fotoğraf galerisinde birden fazla öğe seçebilir. "Selected Items" bu öğeleri belirtir.
            //OleDbDataAdapter, ADO.NET kütüphanesinin bir parçası olup, veritabanı ile uygulamanız arasındaki veri transferini sağlayan bir bileşendir. Bu sınıf, veritabanındaki verileri alıp bir DataSet veya DataTable içine doldurur. Ayrıca, veritabanındaki verilerdeki değişiklikleri güncellemek için kullanılır.
            // OleDbCommand, .NET Framework'te veritabanı ile etkileşime geçmek için kullanılan bir sınıftır. Bu sınıf, özellikle OLE DB (Object Linking and Embedding, Database) veri sağlayıcıları aracılığıyla veritabanlarına sorgular gönderir. OleDbCommand ile SQL komutları (SELECT, INSERT, UPDATE, DELETE gibi) çalıştırılabilir ve veritabanından sonuçlar alınabilir veya veritabanına veri yazılabilir.
            //ExecuteNonQuery katalog işlemlerini gerçekleştirmek (örneğin, veritabanının yapısını sorgulamak veya tablolar gibi veritabanı nesneleri oluşturmak) veya UPDATE, INSERT veya DELETE deyimlerini yürüterek veritabanındaki verileri kullanmadan DataSet değiştirmek için kullanabilirsiniz.
            //SubItems (Alt Öğeler) genellikle ana öğelerin altındaki alt öğeleri tanımlamak için kullanılır. Özellikle yazılım geliştirmede ve kullanıcı arayüzlerinde, ana öğenin altındaki ilişkili öğeleri veya seçenekleri düzenlemek amacıyla kullanılır. 
        }

        private void MaxMin_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            komut = new OleDbCommand("SELECT MAX(CDbl(Fiyat)) FROM manav", baglanti);
            var maxFiyat = komut.ExecuteScalar();
            label6.Text = "Maksimum Fiyat: " + (maxFiyat != DBNull.Value ? maxFiyat.ToString() : "Veri Yok");

            komut = new OleDbCommand("SELECT MIN(CDbl(Fiyat)) FROM manav", baglanti);
            var minFiyat = komut.ExecuteScalar();
            label7.Text = "Minimum Fiyat: " + (minFiyat != DBNull.Value ? minFiyat.ToString() : "Veri Yok");

            baglanti.Close();


        }

        private void Top5_Click(object sender, EventArgs e)
        {

            baglanti.Open(); // Veritabanı bağlantısını aç

            // En yüksek 5 fiyatı almak için SQL sorgusu
            string sorgu = "SELECT TOP 5 * FROM manav ORDER BY CDBL(Fiyat) DESC";

            da = new OleDbDataAdapter(sorgu, baglanti); // Sorguyu çalıştır ve veri al
            DataTable tablo = new DataTable(); // Geçici tablo oluştur
            da.Fill(tablo); // Verileri tabloya doldur

            dataGridView1.DataSource = tablo; // DataGridView'e verileri yükle

            baglanti.Close(); // Bağlantıyı kapat
        }

        private void SortDataGrid_Click(object sender, EventArgs e)
        {
            
                // Eğer DataGridView'de sıralama yapılmamışsa, ilk kez sıralama yapalım
                if (dataGridView1.SortOrder == SortOrder.None || dataGridView1.SortOrder == SortOrder.Descending)
                {
                    // Fiyat sütununa göre artan sıralama yap
                    dataGridView1.Sort(dataGridView1.Columns["Fiyat"], System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    // Fiyat sütununa göre azalan sıralama yap
                    dataGridView1.Sort(dataGridView1.Columns["Fiyat"], System.ComponentModel.ListSortDirection.Descending);   //SortOrder.Descending: Eğer sıralama zaten azalan ise, artan sıralama yapılır.
                 }
            


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortListView_Click(object sender, EventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewItemComparer(3, true); // 3. sütunu (Fiyat) artan sırala
            listView1.Sort(); // ListView'i sıralamak için çağırıyoruz
        }

        private void buttonSortListViewDesc_Click(object sender, EventArgs e)
        {

            listView1.ListViewItemSorter = new ListViewItemComparer(3, false); // 3. sütunu (Fiyat) azalan sırala
            listView1.Sort(); // ListView'i sıralamak için çağırıyoruz
        }




        class ListViewItemComparer : System.Collections.IComparer
        {
            private int col; // Sıralanacak sütun
            private bool asc; // Artan mı, azalan mı?

            public ListViewItemComparer(int column, bool ascending)
            {
                col = column;  // column: Bu, genellikle sıralama işlemi yapılacak olan sütunun adını temsil eder.Örneğin, veritabanı sorgularında veya LINQ ifadelerinde bir sütun ismi belirtmek için kullanılır.
                asc = ascending; //asc = ascending: Bu, verilerin artan sırayla (küçükten büyüğe) sıralanmasını ifade eder. "ascending" sıralama, en küçük değeri önce göstermek anlamına gelir.
            }

            public int Compare(object x, object y)
            {
                double val1, val2;

                // Eğer değerler sayıysa, sayısal sıralama yap
                if (double.TryParse(((ListViewItem)x).SubItems[col].Text, out val1) && //TryParse, C# dilinde bir metodu ifade eder ve genellikle bir veriyi belirli bir tipe dönüştürürken hata almayı önlemek amacıyla kullanılır
                    double.TryParse(((ListViewItem)y).SubItems[col].Text, out val2))
                {
                    return asc ? val1.CompareTo(val2) : val2.CompareTo(val1);
                }

                // Eğer değerler metinse, alfabetik sıralama yap
                int result = string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                return asc ? result : -result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
