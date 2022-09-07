using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class ShoesEditor : UserControl
    {
        readonly General general;
        public string Query { get; set; }
        public string Query2 { get; set; }
        public Guna2DataGridView DataGridView { get; set; }
        public FlowLayoutPanel FlowLayoutPanel { get; set; }
        long ID_shoes = 0;
        public static string connectString;
        List<Bitmap> bitmaps = new List<Bitmap>();
        List<string> sizes = new List<string>();
        bool flag = false;
        public ShoesEditor(string query, string query2, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            Query = query;
            Query2 = query2;
            general = new General();
            connectString = general.StringConnection();
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
            pictureBox.AllowDrop = true;
            FillControls();
        }
        private void FillControls()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(Query2, conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ID_shoes = long.Parse(reader[0].ToString());
                        nameTB.Text = reader[1].ToString();
                        brandTB.Text = reader[2].ToString();
                        var price = reader[3].ToString().Split(',').ToArray();
                        priceTB.Text = price[0];
                        priceRealPartTB.Text = price[1];
                        discountTB.Text = reader[4].ToString();
                        productionCountryTB.Text = reader[5].ToString();
                        typeCB.SelectedItem = reader[6].ToString();
                        colorCB.SelectedItem = reader[7].ToString();
                        foreach (var i in reader[8].ToString().Split(',').ToArray())
                            materialLB.Items.Add(i);
                        seasonCB.SelectedItem = reader[9].ToString();
                        genderCB.SelectedItem = reader[10].ToString();
                        descriptionRTB.AppendText(reader[11].ToString());
                    }
                }
                comm = new SqlCommand($"SELECT picture FROM Pictures WHERE id_shoes = {ID_shoes}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            using (var ms = new MemoryStream((byte[])reader[0]))
                                bitmaps.Add(new Bitmap(Image.FromStream(ms)));
                            picturesLB.Items.Add($"Картинка {bitmaps.Count}");
                        }

                    }
                }
                comm = new SqlCommand($"SELECT size, amount FROM Sizes WHERE id_shoes = {ID_shoes}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            sizes.Add(reader[0].ToString() + " " + reader[1].ToString());
                    }
                }
            }

        }
        public ShoesEditor(string query, Guna2DataGridView dataGridView, FlowLayoutPanel flowLayoutPanel)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            Query = query;
            DataGridView = dataGridView;
            FlowLayoutPanel = flowLayoutPanel;
            pictureBox.AllowDrop = true;
        }
        private void PriceTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);

        private void PriceRealPartTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);

        private void ClearButton_Click(object sender, EventArgs e)
        {
            general.UpdateTable(DataGridView, Query);
            FlowLayoutPanel.Controls.Clear();
            FlowLayoutPanel.Controls.Add(new ShoesEditor(Query, DataGridView, FlowLayoutPanel));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckControls())
            {
                general.InsertIntoTable("Shoes", Array());
                AddPictures();
                AddSizes();
                ClearButton_Click(sender, e);
                new Message("Добавлено.", true).ShowDialog();
            }
        }
        public string[] Array()
        {
            var material = string.Empty;
            for(var i = 0; i < materialLB.Items.Count;i++)
            {
                if (i != materialLB.Items.Count - 1)
                    material += materialLB.Items[i] + ",";
                else
                    material += materialLB.Items[i];
            }

            return new[] { nameTB.Text, brandTB.Text, priceTB.Text + "." + (priceRealPartTB.Text == "" ? priceRealPartTB.PlaceholderText : priceRealPartTB.Text), discountTB.Text == "" ? discountTB.PlaceholderText : discountTB.Text, productionCountryTB.Text, typeCB.Text,colorCB.Text, material, seasonCB.Text,genderCB.Text,descriptionRTB.Text}; 
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ID_shoes != 0)
            {
                if (CheckControls())
                {
                    UpdateTableEntry();
                    CheckPictures();
                    CheckSizes();
                    ClearButton_Click(sender, e);
                    new Message("Изменено.", true).ShowDialog();
                }
            }
            else
                new Message("Обувь не выбрана.", false).ShowDialog();
        }
        private bool CheckControls() => (general.CheckLength(nameTB.Text) && CheckCompliance(brandTB, "введенный бренд") && general.CheckLength(priceTB.Text) && CheckCompliance(productionCountryTB, "введенную страну производства") && general.CheckLength(typeCB.Text) && general.CheckLength(colorCB.Text) && general.CheckItemsCount(materialLB.Items.Count) && general.CheckLength(seasonCB.Text) && general.CheckLength(genderCB.Text) && general.CheckLength(descriptionRTB.Text) && general.CheckItemsCount(bitmaps.Count) && general.CheckItemsCount(sizes.Count)) ? true : false;
        
        private bool CheckCompliance(Guna2TextBox textBox, string mess)
        {
            if (textBox.Text.Length != 0)
            {
                var i = textBox.AutoCompleteCustomSource.IndexOf(textBox.Text);
                if (i != -1)
                    return true;
                new Message($"Исходный список не содержит {mess}.", false).ShowDialog();
                return false;
            }
            new Message("Имеется незаполненное поле.", false).ShowDialog();
            return false;
        }
        private void UpdateTableEntry()
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand($"UPDATE Shoes SET name = @0, brand = @1, price = @2, discount = @3, production_country = @4, type = @5, color = @6, material = @7, season = @8, gender = @9, description = @10 WHERE id_shoes = {ID_shoes}", conn);
                var array = Array();
                for (var i = 0; i < array.Length; i++)
                    sqlCommand.Parameters.AddWithValue($"@{i}", array[i]);
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ID_shoes != 0)
            {
                var message2 = new Message2("Вы действительно хотите удалить данную запись?");
                message2.ShowDialog();
                if (message2.ToString().Equals("True"))
                {
                    using(var conn = new SqlConnection(connectString))
                    {
                        conn.Open();
                        var cmd = new SqlCommand($"SELECT DISTINCT Basket.id_order_realisation FROM Shoes INNER JOIN Sizes ON {ID_shoes} = Sizes.id_shoes INNER JOIN Basket ON Sizes.id_size = Basket.id_size INNER JOIN Order_realisation ON Basket.id_order_realisation = Order_realisation.id_order_realisation", conn);
                        using(var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    general.ExecuteQuery($"DELETE FROM Basket WHERE id_order_realisation = {reader[0]}");
                                    general.ExecuteQuery($"DELETE FROM Orders WHERE id_order_realisation = {reader[0]}");
                                    general.ExecuteQuery($"DELETE FROM Order_realisation WHERE id_order_realisation = {reader[0]}");
                                }
                            }
                        }
                    }
                    general.ExecuteQuery($"DELETE FROM Reviews WHERE id_shoes = {ID_shoes}");
                    general.ExecuteQuery($"DELETE FROM Liked WHERE id_shoes = {ID_shoes}");
                    general.ExecuteQuery($"DELETE FROM Shoes WHERE id_shoes = {ID_shoes}");
                    ClearButton_Click(sender, e);
                    new Message("Удалено.", true).ShowDialog();
                }
            }
            else
                new Message("Обувь не выбрана.", false).ShowDialog();
        }

        private void DescriptionRTB_TextChanged(object sender, EventArgs e) => descriptionL.Text = $"описание ({descriptionRTB.Text.Length} / 1500)";

        private void NameTB_TextChanged(object sender, EventArgs e) => nameL.Text = $"название ({nameTB.Text.Length} / 100)";

        private void BrandTB_TextChanged(object sender, EventArgs e) => brandL.Text = $"бренд ({brandTB.Text.Length} / 50)";

        private void DiscountTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);


        private void DeleteMaterialB_Click(object sender, EventArgs e)
        {
            if(materialLB.SelectedIndex != -1)
            {
                materialLB.Items.RemoveAt(materialLB.SelectedIndex);
                MaterialLB_SizeChanged(sender, e);
            }
            else
                new Message("Выберите материал.", false).ShowDialog();
        }

        private void MaterialLB_SizeChanged(object sender, EventArgs e) => materialL.Text = $"материал ({materialLB.Items.Count} / 10)";

        private void ProductionCountryTB_TextChanged(object sender, EventArgs e) => productionCountryL.Text = $"страна производства ({productionCountryTB.Text.Length} / 50)";

        private void MaterialCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialLB.Items.Count != 10)
            {
                if (materialLB.Items.Count != 0)
                {
                    var flag = true;
                    for (int i = 0; i < materialLB.Items.Count; i++)
                    {
                        if (materialLB.Items[i].Equals(materialCB.SelectedItem))
                        {
                            flag = false;
                            new Message("Такой материал уже имеется.", false).ShowDialog();
                        }
                    }
                    if (flag)
                        materialLB.Items.Add(materialCB.Text);
                }
                else
                    materialLB.Items.Add(materialCB.Text);
                MaterialLB_SizeChanged(sender, e);
            }
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e) => general.PictureBoxDragDrop(pictureBox, e);

        private void PictureBox_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

        private void PictureBox_MouseClick(object sender, MouseEventArgs e) => general.PictureBoxMouseClick(pictureBox, e);

        private void AddPictureB_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                bitmaps.Add(new Bitmap((Bitmap)pictureBox.Image.Clone()));
                picturesLB.Items.Add($"Картинка {bitmaps.Count}");
                general.ImageToNull(pictureBox);
                flag = true;
            }
            else
                new Message("Картинка отсутствует.", false).ShowDialog();
        }

        private void PicturesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (picturesLB.SelectedIndex != -1)
                pictureBox.Image = (Bitmap)bitmaps[picturesLB.SelectedIndex].Clone();
            if(pictureBox.BackgroundImage != null)
                pictureBox.BackgroundImage = null;
        }

        private void DeletePictureB_Click(object sender, EventArgs e)
        {
            if (picturesLB.SelectedIndex != -1)
            {
                bitmaps.RemoveAt(picturesLB.SelectedIndex);
                picturesLB.Items.RemoveAt(picturesLB.SelectedIndex);
                if(pictureBox.Image != null)
                    general.ImageToNull(pictureBox);
                for (var i = 0; i < picturesLB.Items.Count; i++)
                    picturesLB.Items[i] = $"Картинка {i + 1}";
                flag = true;
            }
        }

        private void ChangePictureB_Click(object sender, EventArgs e)
        {
            if (picturesLB.SelectedIndex != -1)
            {
                if (pictureBox.Image != null)
                {
                    bitmaps[picturesLB.SelectedIndex] = new Bitmap(pictureBox.Image);
                    flag = true;
                }
                else
                    new Message("Картинка отсутствует.", false).ShowDialog();
            }
        }

        private void ClearPictureB_Click(object sender, EventArgs e)
        {
            if(picturesLB.Items.Count != 0)
            {
                bitmaps.Clear();
                picturesLB.Items.Clear();
                if (pictureBox.Image != null)
                    general.ImageToNull(pictureBox);
                flag = true;
            }
            else
                new Message("Список пуст.", false).ShowDialog();
        }
        private void CheckPictures()
        {
            if (flag)
            {
                general.ExecuteQuery($"DELETE FROM Pictures WHERE id_shoes = {ID_shoes}");
                AddPictures();
                flag = false;
            }
        }
        private void AddPictures()
        {
            if (pictureBox.Image != null)
                general.ImageToNull(pictureBox);
            ID_shoes = ID_shoes == 0 ? long.Parse(general.ReturnElement("SELECT TOP 1 id_shoes FROM Shoes ORDER BY id_shoes DESC")) : ID_shoes;
            foreach (var bitmap in bitmaps)
            {
                var ms = new MemoryStream();
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Seek(0, SeekOrigin.Begin);
                var data = ms.ToArray();
                general.InsertIntoTable("Pictures", new object[] { ID_shoes.ToString(), data });
            }
        }
        private void ChangeB_Click(object sender, EventArgs e)
        {
            if(general.CheckLength(sizeCB.Text) && general.CheckLength(amountTB.Text))
            {
                if (general.CheckItemsCount(int.Parse(amountTB.Text)))
                {
                    var index = sizes.FindIndex(p => string.Equals(p.Substring(0, p.IndexOf(" ")), sizeCB.Text, StringComparison.CurrentCultureIgnoreCase));
                    if (index != -1)
                        sizes[index] = sizeCB.Text + " " + amountTB.Text;
                    else
                        sizes.Add(sizeCB.Text + " " + amountTB.Text);
                }
            }
        }

        private void AmountTB_TextChanged(object sender, EventArgs e) => amountL.Text = $"количество ({amountTB.Text.Length} / 8)";

        private void AmountTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);

        private void AddSizes()
        {
            foreach (var size in sizes)
                general.InsertIntoTable("Sizes", new[] { ID_shoes.ToString(), size.Substring(0, size.IndexOf(" ")).Replace(",", "."), size.Substring(size.IndexOf(" "), size.Count() - size.IndexOf(" ")).Replace(" ", "")});
        }

        private void SizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = sizes.FindIndex(p => string.Equals(p.Substring(0, p.IndexOf(" ")), sizeCB.Text, StringComparison.CurrentCultureIgnoreCase));
            if (index != -1)
                amountTB.Text = sizes[index].Substring(sizes[index].IndexOf(" "), sizes[index].Count() - sizes[index].IndexOf(" ")).Replace(" ", "");
            else
                amountTB.Clear();
        }
        private void CheckSizes()
        {
            foreach (var size in sizes)
            {
                var arr = size.Replace(",", ".").Split(' ').ToArray();
                if (general.ReturnElement($"SELECT COUNT(*) FROM Sizes WHERE id_shoes = {ID_shoes} AND size = {arr[0]}").Equals("0"))
                    general.InsertIntoTable("Sizes", new[] { ID_shoes.ToString(), arr[0], arr[1] });
                else
                    general.ExecuteQuery($"UPDATE Sizes SET amount = {arr[1]} WHERE id_shoes = {ID_shoes} AND size = {arr[0]}");
            }
        }
    }
}
