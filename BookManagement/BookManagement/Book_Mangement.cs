using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class Book_Mangement: Form
    {
        public Book_Mangement()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            AddBook addBookForm = new AddBook();
            addBookForm.ShowDialog(); // Opens as a modal pop-up

        }
    }
}
