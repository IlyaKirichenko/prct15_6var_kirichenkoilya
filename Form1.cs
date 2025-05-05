using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace var6._1_kirichenkoilya
{


    public partial class Form1 : Form
    {
        PredUkaz ukaz = new PredUkaz();
        string editingWord = "";
        private string selectedWordForEdit = null;

        public Form1()
        {
            InitializeComponent();

            listViewIndex.ContextMenuStrip = contextMenu;
            contextMenu.Items.Add("Удалить", null, DeleteItem_Click);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtWord.Text == "" || txtPage.Text == "")
            {
                MessageBox.Show("Введите слово и страницу!");
                return;
            }

         
            if (int.TryParse(txtPage.Text, out int page))
            {
                ukaz.Add(txtWord.Text, page); 
                RefreshList(); 
            }
            else
            {
                MessageBox.Show("Неверный номер страницы."); 
            }
        }

       
        private void RefreshList()
        {
            listViewIndex.Items.Clear(); 
            foreach (Predmet item in ukaz.Items) 
            {
                var listItem = new ListViewItem(item.Word);
                listItem.SubItems.Add(string.Join(", ", item.Pages.Cast<int>())); 
                listViewIndex.Items.Add(listItem); 
            }
        }


   
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewIndex.SelectedItems.Count == 0) return; 

            var selected = listViewIndex.SelectedItems[0]; 
            string word = selected.Text; 

           
            if (MessageBox.Show($"Удалить '{word}'?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ukaz.Delete(word); 
                RefreshList(); 
            }
        }

        private void listViewIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIndex.SelectedItems.Count > 0)
            {
                var selected = listViewIndex.SelectedItems[0];
                txtWord.Text = selected.Text;
                txtPage.Text = selected.SubItems[1].Text;
                selectedWordForEdit = selected.Text;
            }
        }

        private void EditItem_Click_1(object sender, EventArgs e)
        {
            if (selectedWordForEdit == null)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWord.Text) || string.IsNullOrWhiteSpace(txtPage.Text))
            {
                MessageBox.Show("Введите слово и страницу.");
                return;
            }

            var pageStrings = txtPage.Text.Split(',');
            var pages = new ArrayList();

            foreach (var p in pageStrings)
            {
                if (int.TryParse(p.Trim(), out int num))
                    pages.Add(num);
                else
                {
                    MessageBox.Show($"Некорректный номер страницы: {p}");
                    return;
                }
            }

            ukaz.Edit(selectedWordForEdit, txtWord.Text, pages);
            selectedWordForEdit = null;
            ClearFields();
            RefreshList();
            /* if (listViewIndex.SelectedItems.Count == 0) return; 

                 var selected = listViewIndex.SelectedItems[0]; 
                 string oldWord = selected.Text;
                 string newWord = txtWord.Text;
                 string newPages = txtPage.Text;
                 if (!string.IsNullOrEmpty(newWord) && !int.TryParse(newPages, out int newPage))
                 {
                     var pagesArray = new ArrayList();
                     ukaz.Edit(oldWord, newWord, pagesArray);
                     RefreshList(); 

                 }
                 else
                 {
                     MessageBox.Show("Неверный ввод данных");
                 }*/
        }
        private void ClearFields()
        {
            txtWord.Text = "";
            txtPage.Text = "";
        }
    }
}

       

