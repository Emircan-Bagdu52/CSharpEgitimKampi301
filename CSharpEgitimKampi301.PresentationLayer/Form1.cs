using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
	public partial class Form1 : Form
	{
        private readonly ICategoryService _categoryService;

        public Form1()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtAdi.Text;
            category.CategoryStatus = "true";
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var daletedValue = _categoryService.TGetById(id);
            _categoryService.TDelete(daletedValue);
            MessageBox.Show("Silme başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtAdi.Text;
            updatedValue.CategoryStatus = "true";
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme başarılı");
        }
    }
}
