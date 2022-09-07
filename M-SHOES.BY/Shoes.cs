using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace M_SHOES.BY
{
    public partial class Shoes : UserControl
    {
        readonly General general;
        public static string connectString;
        public long ID_user { get; set; }

        string filters = string.Empty;
        string search = string.Empty;

        public Shoes(long id_user, bool flag)
        {
            InitializeComponent();
            general = new General();
            connectString = general.StringConnection();
            ID_user = id_user;
            if (likedTS.Checked)
            { likedTS.Checked = false; Condition(); }
            if (flag)
            {
                CreateAndFillShoesList("");
                showButton.Text = $"Показать ({general.ReturnElement("SELECT COUNT(*) FROM Shoes")})";
            }
        }
        private async void CreateAndFillShoesList(string condition)
        {
            shoesItemsFLP.Controls.Clear();
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT S.id_shoes, S.name, S.brand, S.price, S.discount, (SELECT TOP 1 picture FROM Pictures WHERE id_shoes = S.id_shoes) FROM Shoes S {condition}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        NotFound(true);
                        var c = 0;
                        while (reader.Read())
                        {
                            ++c;
                            await Task.Run(async () => { await Task.Delay(5); });
                            shoesItemsFLP.Controls.Add(new ShoesList(ID_user, long.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), (byte[])reader[5]));
                            if (c == 4)
                            { shoesItemsFLP.Refresh(); c = 0; }
                        }
                    }
                    else
                        NotFound(false);
                }
            }
        }

        private async void FiltersB_Click(object sender, EventArgs e)
        {
            if (filterP.Height == 126)
            {
                Condition();
                AmountIDShoes();
                if (brandCB.Items.Count == 0)
                {
                    using (var conn = new SqlConnection(connectString))
                    {
                        await conn.OpenAsync();
                        var comm = new SqlCommand("SELECT DISTINCT brand FROM Shoes", conn);
                        using (var reader = await comm.ExecuteReaderAsync())
                        {
                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                    brandCB.Items.Add(reader[0].ToString());
                            }
                        }
                    }
                }
                filterP.Height = 672;
            }
            else
                filterP.Height = 126;
        }

        private void SearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Search();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            Search();
            if (filterP.Height != 126)
                filterP.Height = 126;
        }
        public void NotFound(bool flag)
        {
            if (flag)
            {
                shoesItemsFLP.Visible = true;
                notFoundL.Visible = false;
                guna2PictureBox1.Visible = false;
            }
            else
            {
                shoesItemsFLP.Visible = false;
                notFoundL.Visible = true;
                guna2PictureBox1.Visible = true;
                notFoundL.SendToBack();
                guna2PictureBox1.SendToBack();
            }
        }
        private void Search()
        {
            try
            {
                if (searchTB.Text != "")
                {
                    search = string.Empty;
                    if (filters != "")
                    {
                        Condition();
                        if (sizeLB.Items.Count != 0)
                            CreateAndFillShoesList(filters.Replace("Shoes", "S") + ", S.name, S.brand, S.price, S.discount");
                        else
                            CreateAndFillShoesList(filters.Replace("Shoes", "S"));
                    }
                    else
                    {
                        if (!general.ReturnElement($"SELECT COUNT(*) FROM Shoes WHERE name LIKE '%{searchTB.Text}%' OR brand LIKE '%{searchTB.Text}%'").Equals("0"))
                            search = $"WHERE name LIKE '%{searchTB.Text}%' OR brand LIKE '%{searchTB.Text}%'";
                        if (!general.ReturnElement($"SELECT COUNT(*) FROM Shoes WHERE id_shoes = TRY_PARSE('{searchTB.Text}' AS bigint)").Equals("0"))
                            search += search == "" ? $"WHERE id_shoes = {searchTB.Text}": $" OR id_shoes = {searchTB.Text}";
                        if (search != "")
                            CreateAndFillShoesList(search);
                        else
                            NotFound(false);
                    }
                }
                else
                    NotFound(false);
            }
            catch (Exception) { NotFound(false); }
        }
        private string SearchCond()
        {
            search = string.Empty;
            if (searchTB.Text != "")
            {
                if (!general.ReturnElement($"SELECT COUNT(*) FROM Shoes WHERE name LIKE '%{searchTB.Text}%' OR brand LIKE '%{searchTB.Text}%'").Equals("0"))
                    search = $" AND (name LIKE '%{searchTB.Text}%' OR brand LIKE '%{searchTB.Text}%'";
                if (!general.ReturnElement($"SELECT COUNT(*) FROM Shoes WHERE id_shoes = TRY_PARSE('{searchTB.Text}' AS bigint)").Equals("0"))
                    search += search == "" ? $" AND Shoes.id_shoes = {searchTB.Text}": $" OR Shoes.id_shoes = {searchTB.Text})";
                if(search.Contains("("))
                    search += ")";
                search = search.Replace("))", ")");
            }
            return search;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (filters != string.Empty)
            {
                if (sizeLB.Items.Count != 0)
                    CreateAndFillShoesList(filters.Replace("Shoes", "S") + ", S.name, S.brand, S.price, S.discount");
                else
                    CreateAndFillShoesList(filters.Replace("Shoes", "S"));
            }
            filterP.Height = 126;
        }
        private void Condition()
        {
            if (sizeLB.Items.Count != 0)
            {
                filters = $"INNER JOIN Sizes ON Shoes.id_shoes = Sizes.id_shoes {Liked()} WHERE {Price()} {Discount()} {ReturnParams(brandLB, "Shoes.brand")} {ReturnParams(genderLB, "gender")} {ReturnParams(typeLB, "type")} {ReturnParams(sizeLB, "size")} {ReturnParams(colorLB, "color")} {ReturnParams(seasonLB, "season")} {ReturnParams(materialLB, "material")}{SearchCond()} GROUP BY Shoes.id_shoes";
                showButton.Text = $"Показать ({AmountIDShoes()})";
                NotFound(true);
            }
            else
            {
                filters = $"{Liked()} WHERE {Price()} {Discount()} {ReturnParams(brandLB, "Shoes.brand")} {ReturnParams(genderLB, "gender")} {ReturnParams(typeLB, "type")} {ReturnParams(colorLB, "color")} {ReturnParams(seasonLB, "season")} {ReturnParams(materialLB, "material")}{SearchCond()}";
                showButton.Text = $"Показать ({general.ReturnElement($"SELECT COUNT(*) FROM Shoes {filters}")})";
            }
        }
        private int AmountIDShoes()
        {
            var amount = 0;
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT Shoes.id_shoes FROM Shoes {filters}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            ++amount;
                    }
                }
            }
            return amount;
        }
        private string Price()
        {
            var price = string.Empty;
            var priceWithDiscount = "price - price * discount / 100";
            if (startPriceTB.Text != "" && endPriceTB.Text != "")
            {
                if (int.Parse(startPriceTB.Text) < int.Parse(endPriceTB.Text))
                    price = $"{priceWithDiscount} >= {startPriceTB.Text} AND {priceWithDiscount} <= {endPriceTB.Text}";
                else if(int.Parse(startPriceTB.Text) == int.Parse(endPriceTB.Text))
                    price = $"{priceWithDiscount} = {startPriceTB.Text}";
                else
                    price = "price = -1";
            }
            else if (startPriceTB.Text != "")
                price = $"{priceWithDiscount} >= {startPriceTB.Text}";
            else if (endPriceTB.Text != "")
                price = $"{priceWithDiscount} <= {endPriceTB.Text}";
            else
                price = "price >= 0";
            return price;
        }
        private string Discount() => discountTS.Checked ? "AND discount != 0" : "";

        private string Liked() => likedTS.Checked ? $"INNER JOIN Liked ON Shoes.id_shoes = Liked.id_shoes AND Liked.id_user = {ID_user}" : "";

        private void StartPriceTB_TextChanged(object sender, EventArgs e) => Condition();

        private void EndPriceTB_TextChanged(object sender, EventArgs e) => Condition();

        private void StartPriceTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);

        private void EndPriceTB_KeyPress(object sender, KeyPressEventArgs e) => general.DigitKeyPress(e);

        private void DiscountTS_CheckedChanged(object sender, EventArgs e) => Condition();

        private void ClearPriceB_Click(object sender, EventArgs e)
        {
            startPriceTB.Clear();
            endPriceTB.Clear();
        }

        public string ReturnParams(ListBox listBox, string nameAttribute)
        {
            if(listBox.Items.Count != 0)
            {
                var condition = nameAttribute.Equals("material") ? $"AND {nameAttribute} LIKE '%{listBox.Items[0]}%'" : $"AND {nameAttribute} = '{listBox.Items[0]}'";
                if (listBox.Items.Count > 1)
                {
                    condition = nameAttribute.Equals("material") ? $"AND ({nameAttribute} LIKE '%{listBox.Items[0]}%'" : $"AND ({nameAttribute} = '{listBox.Items[0]}'";
                    for (var i = 1; i < listBox.Items.Count; i++)
                        condition += nameAttribute.Equals("material") ? $" OR {nameAttribute} LIKE '%{listBox.Items[i]}%'" : $" OR {nameAttribute} = '{listBox.Items[i]}'";
                    condition = $"{condition})";
                }
                return condition.Replace(",", ".");
            }
            return "";
        }
        private void DeleteParams(ListBox listBox, string text)
        {
            if (listBox.SelectedIndex != -1)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                Condition();
            }
            else
                new Message($"Выберите {text}.", false).ShowDialog();
        }
        private void Clear(ListBox listBox, Guna2ComboBox comboBox)
        {
            listBox.Items.Clear();
            comboBox.SelectedIndex = -1;
        }
        private void GenderCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(genderLB, genderCB,"пол");
            Condition();
        }

        private void DeleteGenderB_Click(object sender, EventArgs e) => DeleteParams(genderLB, "пол");

        private void ClearGenderB_Click(object sender, EventArgs e) => Clear(genderLB, genderCB);

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(typeLB, typeCB,"вид");
            Condition();
        }

        private void DeleteTypeB_Click(object sender, EventArgs e) => DeleteParams(typeLB, "вид");

        private void ClearTypeB_Click(object sender, EventArgs e) => Clear(typeLB, typeCB);

        private void SizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(sizeLB, sizeCB,"размер");
            Condition();
        }

        private void DeleteSizeB_Click(object sender, EventArgs e) => DeleteParams(sizeLB, "размер");

        private void ClearSizeB_Click(object sender, EventArgs e) => Clear(sizeLB, sizeCB);

        private void ColorCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(colorLB, colorCB, "цвет");
            Condition();
        }

        private void DeleteColorB_Click(object sender, EventArgs e) => DeleteParams(colorLB, "цвет");

        private void ClearColorB_Click(object sender, EventArgs e) => Clear(colorLB, colorCB);

        private void SeasonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(seasonLB, seasonCB, "сезон");
            Condition();
        }

        private void DeleteSeasonB_Click(object sender, EventArgs e) => DeleteParams(seasonLB, "сезон");

        private void ClearSeasonB_Click(object sender, EventArgs e) => Clear(seasonLB, seasonCB);

        private void MaterialCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(materialLB, materialCB, "материал");
            Condition();
        }

        private void DeleteMaterialB_Click(object sender, EventArgs e) => DeleteParams(materialLB, "материал");

        private void ClearMaterialB_Click(object sender, EventArgs e) => Clear(materialLB, materialCB);

        private void ResetFiltersB_Click(object sender, EventArgs e)
        {
            if(filterP.Height == 672)
                filterP.Height = 126;
            NotFound(true);
            CreateAndFillShoesList("");
            Clear(brandLB, brandCB);
            Clear(genderLB, genderCB);
            Clear(typeLB, typeCB);
            Clear(sizeLB, sizeCB);
            Clear(colorLB, colorCB);
            Clear(seasonLB, seasonCB);
            Clear(materialLB, materialCB);
            ClearPriceB_Click(sender, e);
            discountTS.Checked = false;
            likedTS.Checked = false;
            filters = "";
        }

        private void LikedTS_CheckedChanged(object sender, EventArgs e) => Condition();
        public void SelectLiked()
        {
            likedTS.Checked = true;
            if (filters != string.Empty)
                CreateAndFillShoesList(filters.Replace("Shoes", "S"));
        }

        private async void SearchTB_TextChanged(object sender, EventArgs e)
        {
            await Task.Run(async () => { await Task.Delay(1); });
            searchTB.Refresh();
            if(searchTB.Text != "")
                Search();
            else
                CreateAndFillShoesList("");
        }

        private void BrandCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            general.CheckAndAdd(brandLB, brandCB, "бренд");
            Condition();
        }

        private void ClearBrandB_Click(object sender, EventArgs e) => Clear(brandLB, brandCB);

        private void DeleteBrandB_Click(object sender, EventArgs e) => DeleteParams(brandLB, "бренд");
    }
}
