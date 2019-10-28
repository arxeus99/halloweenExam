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
    public partial class MovieDetailsForm : Form
    {
        Movie _selected;
        private static string connectionString =
            "Server=localhost;Database=sakila;Uid=client;Pwd=$3cr3t3t;";

        public MovieDetailsForm(Movie selectedMovie)
        {

            
         
            InitializeComponent();
            string sql = "";
            var datos = new List<string>();
            _selected = selectedMovie;
            MySqlConnection connection = new MySqlConnection(connectionString);
            title.Text = _selected.title;
            sql = "SELECT category.name FROM sakila.film_category INNER JOIN category ON film_category.category_id = category.category_id WHERE film_category.film_id = " + _selected.film_id + "; ";
            datos = connection.Query<string>(sql).ToList();
            category.Text = datos[0];
            sql = "SELECT language.name FROM language INNER JOIN film ON film.language_id = language.language_id WHERE film.film_id = " + _selected.film_id + "; ";
            datos = connection.Query<string>(sql).ToList();
            language.Text = datos[0];
            description.Text = _selected.description;
            duration.Text = _selected.length + "'";
            rating.Text = _selected.rating;
            if (rating.Text.Equals("NC-17") || rating.Text.Equals("R"))
            {
                rating.ForeColor = Color.Red;
            }
            sql = "SELECT actor.first_name FROM actor INNER JOIN film_actor ON actor.actor_id = film_actor.actor_id WHERE film_id = "+_selected.film_id+"; ";
            datos = connection.Query<string>(sql).ToList();
            actorsListBox.DataSource = datos;
            connection.Close();

            
        }
    }
}
