using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace M_SHOES.BY
{
    public partial class TableEditor : Form
    {
        readonly General general;
        public static string connectString;
        public long ID_user { get; set; }
        public TableEditor(long id_user)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
        }
        bool flag;
        private void TablesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDataGridView(TranslateTablesName("0"));
            UpdateSearchAttribute();
            flag = false;
        }
        private void UpdateSearchAttribute()
        {
            searchAttributesCB.Items.Clear();
            searchAttributesCB.SelectedIndex = -1;
            searchConditionCB.SelectedIndex = -1;
            flag = true;
            searchTB.Clear();
            for (var i = 0; i < dataGridView.Columns.Count; i++)
            {
                if(!dataGridView.Columns[i].HeaderText.Equals("картинка") && !dataGridView.Columns[i].HeaderText.Contains("id"))
                    searchAttributesCB.Items.Add(dataGridView.Columns[i].HeaderText);
            }
        }
        private void FillDataGridView(string query) => general.UpdateTable(dataGridView, query);
        private string TranslateTablesName(string index)
        {
            var query = string.Empty;
            switch (tablesCB.SelectedItem)
            {
                case "Пользователи":
                    {
                        query = "SELECT id_user AS 'номер пользователя', role AS 'роль', email AS 'электронная почта',password AS 'пароль', name AS 'имя', phone AS 'телефон', picture AS 'картинка' FROM Users";
                        if (!index.Equals("-1")) {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new UsersEditor(query, query + " WHERE id_user = " + index, dataGridView, itemsFLP));
                        }
                        return query;
                    }
                case "Заказы":
                    {
                        query = "SELECT id_order AS 'номер заказа', id_order_realisation AS 'id реализации заказа',id_self_pickup_point AS 'id пункта самовывоза', status AS 'статус', implementation_date AS 'дата осуществления', delivery_date AS 'дата доставки', cost AS 'стоимость' FROM Orders";
                        if (!index.Equals("-1"))
                        {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new OrdersEditor(query, query + " WHERE id_order = " + index, dataGridView, itemsFLP));
                        }
                        return query;
                    }
                case "Отзывы":
                    {
                        query = "SELECT id_review AS 'id отзыва',id_user AS 'id пользователя',id_shoes AS 'id обуви',date_time AS 'дата и время', name AS 'имя', mark AS 'оценка', review AS 'отзыв' FROM Reviews";
                        if (!index.Equals("-1"))
                        {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new ReviewsEditor(query, query + " WHERE id_review = " + index, dataGridView, itemsFLP));
                        }
                        return query;
                    }
                case "Пункты самовывоза":
                    {
                        query = "SELECT id_self_pickup_point AS 'id пункта самовывоза', address AS 'адрес', information AS 'информация' FROM Self_pickup_points";
                        if (!index.Equals("-1"))
                        {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new SelfPickupPointsEditor(query, query + " WHERE id_self_pickup_point = " + index, dataGridView, itemsFLP));
                        }
                        return query;
                    }
                case "Обувь":
                    {
                        query = "SELECT id_shoes AS 'код обуви', name AS 'название', brand AS 'бренд', price AS 'цена', discount AS 'скидка', production_country AS 'страна производства', type AS 'вид', color AS 'цвет', material AS 'материал', season AS 'сезон', gender AS 'пол', description AS 'описание' FROM Shoes";
                        if (!index.Equals("-1"))
                        {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new ShoesEditor(query, query + " WHERE id_shoes = " + index, dataGridView, itemsFLP));
                        }
                        return query;
                    }
                case "Картинки":
                    {
                        query = "SELECT id_picture AS 'id картинки', id_shoes AS 'id обуви', picture AS 'картинка' FROM Pictures";
                        if (!index.Equals("-1"))
                        {
                            itemsFLP.Controls.Clear();
                            itemsFLP.Controls.Add(new PicturesView(query + " WHERE id_picture = " + index));
                        }
                        return query;
                    }
            }
            return "";
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            if (!flag && IsSearchEmpty() && general.CheckLength(tablesCB.SelectedItem == null ? "" : tablesCB.SelectedItem.ToString()) && general.CheckLength(searchAttributesCB.SelectedItem == null ? "" : searchAttributesCB.SelectedItem.ToString()) && general.CheckLength(searchConditionCB.SelectedItem == null ? "" : searchConditionCB.SelectedItem.ToString()))
            {
                try
                {
                    var query = string.Empty;
                    if (searchConditionCB.SelectedIndex == 0)
                        query = $"{TranslateTablesName("-1")} WHERE {general.NameAttribute()} LIKE '%" + searchTB.Text + "%'";
                    if (searchConditionCB.SelectedIndex == 1)
                        query = $"{TranslateTablesName("-1")} WHERE {general.NameAttribute()} = '" + searchTB.Text + "'";
                    general.UpdateTable(dataGridView, query);
                }
                catch (Exception) { }
            }
            flag = false;
        }
        private bool IsSearchEmpty()
        {
            if (searchTB.Text.Length == 0 && tablesCB.SelectedIndex != -1 && searchAttributesCB.SelectedIndex != -1 && searchConditionCB.SelectedIndex != -1)
            {
                FillDataGridView(TranslateTablesName("-1"));
                return false;
            }
            return true;
        }

        private void SearchAttributesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tablesCB.SelectedItem != null)
                general.TranslateAttributes(tablesCB.SelectedItem.ToString(), searchAttributesCB.SelectedItem == null ? "" : searchAttributesCB.SelectedItem.ToString());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (general.CheckLength(tablesCB.SelectedItem == null ? "" : tablesCB.SelectedItem.ToString()) && general.CheckLength(searchAttributesCB.SelectedItem == null ? "" : searchAttributesCB.SelectedItem.ToString()) && general.CheckLength(searchConditionCB.SelectedItem == null ? "" : searchConditionCB.SelectedItem.ToString()) && IsSearchEmpty())
            {
                if (dataGridView.Rows.Count != 0)
                {
                    var message2 = new Message2("Вы действительно хотите удалить данную(ые) запись(и)?");
                    message2.ShowDialog();
                    if (message2.ToString().Equals("True"))
                    {
                        string query = string.Empty;
                        try
                        {
                            if (searchConditionCB.SelectedIndex == 0)
                                query = $"DELETE FROM {general.TranslateAttributes(tablesCB.SelectedItem.ToString(), tablesCB.SelectedItem.ToString())} WHERE {general.TranslateAttributes(tablesCB.SelectedItem.ToString(), searchAttributesCB.SelectedItem.ToString())} LIKE '%" + searchTB.Text + "%'";
                            if (searchConditionCB.SelectedIndex == 1)
                                query = $"DELETE FROM {general.TranslateAttributes(tablesCB.SelectedItem.ToString(), tablesCB.SelectedItem.ToString())} WHERE {general.TranslateAttributes(tablesCB.SelectedItem.ToString(), searchAttributesCB.SelectedItem.ToString())} = '" + searchTB.Text + "'";
                            general.ExecuteQuery(query);
                            general.UpdateTable(dataGridView, TranslateTablesName("-1"));
                            searchAttributesCB.SelectedIndex = -1;
                            searchConditionCB.SelectedIndex = -1;
                            flag = true;
                            searchTB.Clear();
                            new Message("Удалено.", true).ShowDialog();
                        }
                        catch (Exception)
                        {
                            new Message("Ошибка!", false).ShowDialog();
                        }
                    }
                }
                else
                    new Message("Значения не найдены.", false).ShowDialog();
            }
        }

        private void ExitControlBox_Click(object sender, EventArgs e) => Application.Exit();

        private void BackB_Click(object sender, EventArgs e)
        {
            var main = new Main(ID_user);
            if(general.ReturnElement($"SELECT role FROM Users WHERE id_user = {ID_user}").Equals("администратор"))
                main.WorkspaceB_Click(sender, e);
            Hide();
            main.Show();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            flag = false;
            SearchTB_TextChanged(sender, e);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                TranslateTablesName(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
