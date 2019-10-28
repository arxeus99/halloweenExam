using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sakilaUI
{
    public partial class Form1 : Form
    {

        private string connectionString = "";

        private string last_name = "";

        private Boolean loged = false;

        private Boolean staff = false;

        public Form1()
        {
            InitializeComponent();
            lastnameLabel.Visible = false;
            foreach(Control c in this.tabPage2.Controls)
            {
                c.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var movies = new List<Movie>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "";
            if (checkBox1.Checked)
            {
                sql= $"SELECT title, film_id, description, length, rating FROM sakila.film" +
                $" WHERE title = '{titleTextBox.Text}' ORDER BY film_id";
            }
            else
            {
                sql = $"SELECT title, film_id, description, length, rating FROM sakila.film" +
                $" WHERE title LIKE '%{titleTextBox.Text}%' ORDER BY film_id";
            }
            movies = connection.Query<Movie>(sql).ToList();
            moviesListBox.DataSource = movies;
            moviesListBox.DisplayMember = "title";
            found.Text = movies.Count() + " records found";
            connection.Close();
        }

        private void moviesListBox_DoubleClick(object sender, EventArgs e)
        {
            Movie selectedMovie = moviesListBox.SelectedItem as Movie;
            if (selectedMovie == null)
            {
                DialogResult error = MessageBox.Show("you must search for a movie before picking one", "error", MessageBoxButtons.OK);
            }
            else
            { 
                var details = new MovieDetailsForm(selectedMovie);
                DialogResult result = details.ShowDialog(this);
            }
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if(loginButton.Text.Equals("Log In"))
            {
                if (userTextBox.Text.Equals("guest"))
                {
                    if (passwordTextBox.Text.Equals("£123"))
                    {
                        loged = true;
                        connectionString = "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t;";

                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK);
                        userTextBox.Text = "";
                        passwordTextBox.Text = "";
                    }
                }
                else
                {
                    connectionString = "Server=localhost;Database=sakila;Uid=staff;Pwd=$up3r$3cr3t;";
                    var users = new List<String>();
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    string sql = "SELECT first_name FROM sakila.staff";
                    users = connection.Query<string>(sql).ToList();
                    Boolean encontrado = false;
                    connection.Close();
                    foreach (string s in users)
                    {
                        if (userTextBox.Text.Equals(s))
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado == true)
                    {
                        if (passwordTextBox.Text.Equals("£456"))
                        {
                            loged = true;
                            staff = true;
                            sql = "SELECT last_name FROM sakila.staff WHERE first_name = '" + userTextBox.Text + "';";
                            users = connection.Query<string>(sql).ToList();
                            lastnameLabel.Visible = true;
                            last_name = users[0];
                            lastnameLabel.Text = "Mr. " + last_name;
                            connection.Close();
                        }
                        else
                        {
                            DialogResult error = MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK);
                            userTextBox.Text = "";
                            passwordTextBox.Text = "";
                        }

                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("User non-existent", "Error", MessageBoxButtons.OK);
                        userTextBox.Text = "";
                        passwordTextBox.Text = "";
                    }
                }
                if (loged == true)
                {
                    userTextBox.Enabled = false;
                    passwordTextBox.Enabled = false;
                    loginButton.Text = "Log out";
                    foreach (Control c in this.tabPage2.Controls)
                    {
                        c.Enabled = true;
                    }
                    if(staff == true)
                    {
                        pictureBox1.Visible = false;
                    }
                }
            }
            else
            {
                loged = false;
                staff = false;
                lastnameLabel.Visible = false;
                pictureBox1.Visible = true;
                foreach (Control c in this.tabPage2.Controls)
                {
                    c.Enabled = false;
                }
                userTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                userTextBox.Text = "";
                passwordTextBox.Text = "";
                loginButton.Text = "Log In";
                last_name = "";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE sakila.staff SET email = '"+emailTextBox.Text+"' WHERE(last_name = '"+last_name+"');";
            DialogResult done = MessageBox.Show("Email updated succesfully", "Done", MessageBoxButtons.OK);
            emailTextBox.Text = "";
            connection.Execute(sql);
            connection.Close();
        }
    }
}
