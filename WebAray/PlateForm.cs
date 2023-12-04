using Business.Abstract1.Plates;
using Business.DependencyResolvers.ninject;
using Entity.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;
namespace WebAray
{
    public partial class PlateForm : Form
    {
        public PlateForm()
        {
            InitializeComponent();
            platesService = İnstanceFactory.GetInstance<IPlatesService>();
        }

        private readonly IPlatesService platesService;
        private void PlateForm_Load(object sender, EventArgs e)
        {
            PlatesServiceLoad();
        }
        public void PlatesServiceLoad()
        {
            dataGridView1.DataSource = platesService.GetAll().ToList();
            textBox1.Text = textBox2.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                platesService.Add(new Plates()
                {
                    plateNo = textBox1.Text,
                    plateComment = textBox2.Text
                });
                MessageBox.Show("Başarılı Bir Şekilde Eklendi");
                PlatesServiceLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    platesService.Delete(new Plates()
                    {
                        plateID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Silindi");
                    PlatesServiceLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                platesService.Update(new Plates()
                {
                    plateID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    plateNo = textBox1.Text,
                    plateComment = textBox2.Text
                }) ;
                PlatesServiceLoad();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
