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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Avaliacao4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insere info
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
            string query = "INSERT INTO vendas(`marca`,`modelo`,`preco`, `qtd_estoque`) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Produto Cadastrado com sucesso!!");
                databaseConnection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                string query = "UPDATE `vendas` SET `marca`= '" + textBox8.Text + "', `modelo`= '" + textBox7.Text + "', `preco`= '" + textBox6.Text + "', `qtd_estoque` = '" + textBox5.Text + "'";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Venda realizada com sucesso!!");
                    databaseConnection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (textBox8.Text == "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                    string query = "UPDATE `vendas` SET `preco`= '" + textBox6.Text + "', `qtd_estoque` -= '" + textBox5.Text + "'";

                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Venda realizada com sucesso!!");
                        databaseConnection.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (textBox8.Text == "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
                    {
                        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                        string query = "UPDATE `vendas` SET `qtd_estoque`= '" + textBox5.Text + "'";

                        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                        commandDatabase.CommandTimeout = 60;

                        try
                        {
                            databaseConnection.Open();
                            MySqlDataReader myReader = commandDatabase.ExecuteReader();
                            MessageBox.Show("Venda realizada com sucesso!!");
                            databaseConnection.Close();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        if (textBox8.Text == "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
                        {
                            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                            string query = "UPDATE `vendas` SET `marca`= '" + textBox8.Text + "', `qtd_estoque`= '" + textBox5.Text + "'";

                            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                            commandDatabase.CommandTimeout = 60;

                            try
                            {
                                databaseConnection.Open();
                                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                MessageBox.Show("Venda realizada com sucesso!!");
                                databaseConnection.Close();

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            if (textBox8.Text == "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
                            {
                                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                                string query = "UPDATE `vendas` SET `marca`= '" + textBox8.Text + "'";

                                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                                commandDatabase.CommandTimeout = 60;

                                try
                                {
                                    databaseConnection.Open();
                                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                    MessageBox.Show("Venda realizada com sucesso!!");
                                    databaseConnection.Close();

                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                if (textBox8.Text == "" && textBox7.Text != "" && textBox6.Text != "" && textBox5.Text != "")
                                {
                                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=locacell;";
                                    string query = "UPDATE `vendas` SET  `preco`= '" + textBox6.Text + "'";

                                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                                    commandDatabase.CommandTimeout = 60;

                                    try
                                    {
                                        databaseConnection.Open();
                                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                                        MessageBox.Show("Venda realizada com sucesso!!");
                                        databaseConnection.Close();

                                    }

                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }

                            }
                        }





                    }
                }
            }
        }
        }
    }
