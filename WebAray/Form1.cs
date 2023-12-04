using Business.Abstract1;
using Business.DependencyResolvers.ninject;
using Entity.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WebAray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = İnstanceFactory.GetInstance<IProductService>();
            _categoryService = İnstanceFactory.GetInstance<ICategoryService>();
        }
        private readonly IProductService _productService;
        private readonly ICategoryService  _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
           
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll().ToList();
            // GÖRÜNÜN KISIM KATEGORİNİN İSMİ- SEÇTİĞİMİZDE IDSİ OLSUN
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            // BİRDE ÜRÜN EKLENİRKEN KATEGORİLERİN YÜKLENMESİ
            cbxCategoryId.DataSource = _categoryService.GetAll().ToList();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";

            // GÜNCELLEME KISMINDA KATEGORİLERİN YÜKLENMESİ
            cbxUpdateCategory.DataSource = _categoryService.GetAll().ToList();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dataGridView1.DataSource = _productService.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            tbxUpdateName.Text = row.Cells[1].Value.ToString();
            tbxUpdatePrice.Text = row.Cells[3].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[2].Value;
            tbxUpdateStockAmount.Text = row.Cells[5].Value.ToString();
            tbxUpdateStockPerUnit.Text = row.Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    // BUTONA TIKLADIĞIMDA YAZILAN BİLGİLERİ EKRANA GÖNDERECEK
                    // Add isminde Metod Oluştur F12 ile ilgili yer git gerekli işlemleri yap
                    // Yazılan Bilgileri Buraya Çekmem Lazım

                    CategoryID = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName2.Text,
                    QuantityPerUnit = tbxStockPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxProductPrice.Text),
                    UnitİnStock = Convert.ToInt16(tbxStockAmount.Text)

                });
                MessageBox.Show("ÜRÜNLER KAYDEDİLDİ !");
                LoadProducts();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                // SEÇİLİ ID ALACAZ ONUN ÜZERİNDEN İŞLEM YAPACAĞIZ
                ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                CategoryID = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                ProductName = tbxUpdateName.Text,
                QuantityPerUnit = tbxUpdateStockPerUnit.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdatePrice.Text),
                UnitİnStock = Convert.ToInt16(tbxUpdateStockAmount.Text)

            });
            MessageBox.Show("ÜRÜNLER GÜNCELLENDİ!");
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Dgw Boş İken Silme Yapmasın-- YOksa Hata Alırz
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("ÜRÜNLER SİLİNDİ!");
                    LoadProducts();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dataGridView1.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            // BOŞ İSE TÜM LİSTEYİ GÖSTER
            else
            {
                LoadProducts();
            }
        }
    }
}
