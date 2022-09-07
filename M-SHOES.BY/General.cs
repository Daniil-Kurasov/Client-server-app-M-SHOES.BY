using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Guna.UI2.WinForms;
using System.Data.OleDb;

namespace M_SHOES.BY
{
    class General
    {
        public FlowLayoutPanel FlowLayoutPanel { get; set; }
        public static string connectString;
        string nameAttribute;
        public General() => connectString = StringConnection();
        public General(FlowLayoutPanel flowLayoutPanel)
        {
            FlowLayoutPanel = flowLayoutPanel;
            connectString = StringConnection();
            FlowLayoutPanel.Controls.Clear();
        }
        public string StringConnection() => "Server = DESKTOP-0IO56GE; Database = M-SHOES.BY; Trusted_connection = true";        //TEACHER3242        //DESKTOP-557D9NJ
        public void RemindPassword() => FlowLayoutPanel.Controls.Add(new RemindPassword(FlowLayoutPanel));
        public void SignUp() => FlowLayoutPanel.Controls.Add(new SignUp(FlowLayoutPanel));
        public void SignIn() => FlowLayoutPanel.Controls.Add(new SignIn(FlowLayoutPanel));
        public bool NameCheck(string name)
        {
            if (name.Length < 2 || name.Length > 20)
            {
                new Message("Имя должно содержать от 2 до 20 букв.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool PasswordAndReenterPasswordCheck(string password, string reenterPassword)
        {
            if (password.Length < 6 || reenterPassword.Length < 6 || password.Length > 30 || reenterPassword.Length > 30)
            {
                new Message("Пароль должен содержать от 6 до 30 символов.", false).ShowDialog();
                return false;
            }
            else if (!password.Equals(reenterPassword))
            {
                new Message("Пароли не совпадают.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool PasswordCheck(string password)
        {
            if (password.Length < 6 || password.Length > 30)
            {
                new Message("Пароль должен содержать от 6 до 30 символов.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool EmailCheck(string email)
        {
            if (!EmailCheck2(email))
                return false;
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand("SELECT email FROM Users WHERE email ='" + email + "'", conn);
                var reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    new Message("Введенная электронная почта уже зарегистрирована.", false).ShowDialog();
                    return false;
                }
            }
            return true;
        }
        public bool EmailCheck2(string email)
        {
            if (email.Length > 350)
            {
                new Message("Почта не должна содержать более 350 символов.", false).ShowDialog();
                return false;
            }
            var pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (!Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
            {
                new Message("Некорректно введена электронная почта.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool PhoneCheck(string phone)
        {
            var pattern = @"^(\+375)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            if (!Regex.IsMatch(phone, pattern, RegexOptions.IgnoreCase))
            {
                new Message("Некорректно введен номер телефона.", false).ShowDialog();
                return false;
            }
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand("SELECT phone FROM Users WHERE phone = '" + phone + "'", conn);
                var reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    new Message("Введенный номер телефона уже существует.", false).ShowDialog();
                    return false;
                }
            }
            return true;
        }
        public bool IsThereAnInternetConnection(bool flag, string mess)
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(@"google.com");
                IPStatus status = reply.Status;
                if (status != IPStatus.Success)
                    throw new Exception();
            }
            catch (Exception)
            {
                if (flag)
                    new Message(mess, false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool SendMessageToEmail(string email, string head, string text, bool flag, Bitmap bitmap)
        {
            try
            {
                var fromMailAddress = new MailAddress("m-shoes.by@bk.ru", $"M-SHOES.BY");
                var toAddress = new MailAddress(email, $"M-SHOES.BY");
                Task.Run(async () =>
                {
                    using (var mailMessage = new MailMessage(fromMailAddress, toAddress))
                    using (var smtpClient = new SmtpClient())
                    {
                        mailMessage.Subject = head;
                        mailMessage.IsBodyHtml = true;
                        if (flag)
                        {
                            var stream = new MemoryStream();
                            bitmap.Save(stream, ImageFormat.Jpeg);
                            stream.Position = 0;
                            mailMessage.Attachments.Add(new Attachment(stream, "Заказ.jpeg", "image/jpeg"));
                        }
                        mailMessage.AlternateViews.Add(GetEmbeddedImage(text));
                        smtpClient.Host = "smtp.mail.ru";
                        smtpClient.Port = 587;
                        smtpClient.EnableSsl = true;
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "tBnVAWVCWMjMK9bErER7");
                        await smtpClient.SendMailAsync(mailMessage);
                    }
                });
            }
            catch (Exception)
            {
                new Message("Почта недействительна.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public AlternateView GetEmbeddedImage(string confirmCode) => AlternateView.CreateAlternateViewFromString($@"<html><body><table width=""50%""><tr><td style=""font-style:Century Gothic; color:black; font-weight:bold; font-size:50pt; text-align:right"">{confirmCode} <br></td></tr></table></body></html>", null, MediaTypeNames.Text.Html);
        public void ShowAndHide(Guna2TextBox passwordTB)
        {
            if (passwordTB.PasswordChar == '●')
            {
                passwordTB.PasswordChar = '\0';
                passwordTB.IconRight = Properties.Resources.Show;
            }
            else
            {
                passwordTB.PasswordChar = '●';
                passwordTB.IconRight = Properties.Resources.Hide;
            }
        }
        public void TextGhanged1(Guna2TextBox emailTB) => emailTB.Text = emailTB.Text.Replace(' ', '_');
        public void KeyPress1(KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        public void PhoneKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 43 || e.KeyChar == 8)
                return;
            e.Handled = true;
        }
        public void NameKeyPress(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
                return;
            e.Handled = true;
        }
        public void DigitKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                return;
            e.Handled = true;
        }
        public void InsertIntoTable(string tableName, object[] array)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"INSERT INTO {tableName} VALUES ({CreateParamValues(array)})", conn);
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                        comm.Parameters.AddWithValue($"@{i}", array[i]);
                    else
                        comm.Parameters.Add($"@{i}", SqlDbType.Image).Value = DBNull.Value;
                }
                comm.ExecuteNonQuery();
            }
        }
        public string CreateParamValues(object[] array)
        {
            var paramValues = string.Empty;
            for (var i = 0; i < array.Length; i++)
                paramValues += $"@{i},";
            return paramValues.TrimEnd(',');
        }
        public void ImageToNull<T>(T pictureBox) where T : PictureBox
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
            if(pictureBox is Guna2PictureBox)
                pictureBox.BackgroundImage = Properties.Resources.AddRectangle;
            else
                pictureBox.BackgroundImage = Properties.Resources.Add;
        }
        public void UpdateTable(DataGridView dataGridView, string query)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var dataTable = new DataTable();
                var adapter = new SqlDataAdapter(new SqlCommand(query, conn));
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                for(var i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if(dataGridView.Columns[i].HeaderText.Contains("id"))
                        dataGridView.Columns[i].Visible = false;
                }
            }
        }
        public void ExecuteQuery(string query)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery(); 
            }
        }
        public bool CheckLength(string text)
        {
            if (text.Length == 0)
            {
                new Message("Имеется незаполненное поле.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public bool CheckItemsCount(int count)
        {
            if (count == 0)
            {
                new Message("Имеется незаполненное поле.", false).ShowDialog();
                return false;
            }
            return true;
        }
        public void PictureBoxMouseClick(Guna2PictureBox pictureBox, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button && pictureBox.Image != null)
                ImageToNull(pictureBox);

            else if (MouseButtons.Left == e.Button)
                AddPicture(pictureBox);
        }
        public bool PictureBoxMouseClick(Guna2CirclePictureBox pictureBox, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button && pictureBox.Image != null)
            {
                ImageToNull(pictureBox);
                return true;
            }
            else if (MouseButtons.Left == e.Button && AddPicture(pictureBox))
                return true;

            return false;
        }
        public void AddPicture(object pictureBox)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Image Files(*.JPG; *.JPEG;*.BMP,*.PNG)|*.JPG; *.JPEG;*.BMP; *.PNG" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    if (pictureBox is Guna2PictureBox p)
                    {
                        if (p.Image != null)
                            ImageToNull(p);
                        GetImage(p, openFileDialog.FileName);
                    }
                    if(pictureBox is Guna2CirclePictureBox p2)
                    {
                        if (p2.Image != null)
                            ImageToNull(p2);
                        GetImage(p2, openFileDialog.FileName);
                    }
                }
                catch { new Message("Формат не поддерживается.", false).ShowDialog(); }
        }
        public bool AddPicture(Guna2CirclePictureBox pictureBox)
        {
            var openFileDialog = new OpenFileDialog { Filter = "Image Files(*.JPG; *.JPEG;*.BMP,*.PNG)|*.JPG; *.JPEG;*.BMP; *.PNG" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    if (pictureBox.Image != null)
                        ImageToNull(pictureBox);
                    GetImage(pictureBox, openFileDialog.FileName);
                    return true;
                }
                catch { new Message("Формат не поддерживается.", false).ShowDialog(); }
            return false;
        }
        public void PictureBoxDragDrop(Guna2PictureBox pictureBox, DragEventArgs e)
        {
            if (GetFilename(e))
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0)
                        GetImage(pictureBox, fileNames[0]);
                }
            }
        }
        public bool PictureBoxDragDrop(Guna2CirclePictureBox pictureBox, DragEventArgs e)
        {
            if (GetFilename(e))
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var fileNames = data as string[];
                    if (fileNames.Length > 0)
                    {
                        GetImage(pictureBox, fileNames[0]);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool GetFilename(DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy && e.Data.GetData("FileDrop") is Array data)
                if ((data.Length == 1) && (data.GetValue(0) is string))
                {
                    var filename = ((string[])data)[0];
                    var ext = Path.GetExtension(filename).ToLower();
                    if (ext == ".jpg" || ext == ".png" || ext == ".bmp" || ext == ".jpeg" || ext == ".gif")
                        return true;
                }
            new Message("Формат не поддерживается.", false).ShowDialog();
            return false;
        }
        public string TranslateAttributes(string tableName, string name)
        {
            if (name != "")
            {
                var attributes = File.ReadAllLines($@"{Application.StartupPath}\M-SHOES.BY\Tables\{tableName}.txt");
                var index = Array.IndexOf(attributes, name);
                nameAttribute = attributes[index - 1];
            }
            return nameAttribute;
        }
        public string NameAttribute() => nameAttribute;
        public void GetImage<T>(T pictureBox, string path) where T : PictureBox
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                pictureBox.Image = Image.FromStream(stream);
            pictureBox.BackgroundImage = null;
        }
        public void GetPicture<T>(T pictureBox, byte[] image) where T : PictureBox
        {
            using (var ms = new MemoryStream(image))
                pictureBox.Image = Image.FromStream(ms);
            pictureBox.BackgroundImage = null;
        }
        public bool CheckEmail(string email, string emailTB) => !email.Equals(emailTB) ? EmailCheck(emailTB) : true;
        public bool CheckPhone(string phone, string phoneTB) => !phone.Equals(phoneTB) ? PhoneCheck(phoneTB) : true;

        public string ReturnElement(string query)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand(query, conn);
                if (comm.ExecuteScalar() == null)
                    return "0";
                return comm.ExecuteScalar().ToString().Equals("") ? "0" : comm.ExecuteScalar().ToString();
            }
        }
        public void CheckAndAdd(ListBox listBox, Guna2ComboBox comboBox, string text)
        {
            if (listBox.Items.Count != comboBox.Items.Count)
            {
                if (listBox.Items.Count != 0)
                {
                    var i = listBox.Items.IndexOf(comboBox.SelectedItem);
                    if(i != -1)
                        new Message($"Такой {text} уже имеется.", false).ShowDialog();
                    else
                        listBox.Items.Add(comboBox.Text);
                }
                else if (comboBox.SelectedIndex != -1)
                    listBox.Items.Add(comboBox.Text);
            }
            else
                new Message($"Такой {text} уже имеется.", false).ShowDialog();
        }
        public void FillAddresses(Guna2ComboBox addressesCB)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand("SELECT address FROM Self_pickup_points", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            addressesCB.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        public void FillDate(Guna2ComboBox dateCB)
        {
            for (var i = 1; i <= 7; i++)
                dateCB.Items.Add(DateTime.Now.AddDays(i).ToLongDateString());
        }
        public void ClearBasket(FlowLayoutPanel basketFLP, Label countBasketL, long ID_user, Timer menuAnimate, Guna2Button menuB, Guna2PictureBox basketPB)
        {
            basketFLP.Controls.Clear();
            basketFLP.Controls.Add(basketPB);
            countBasketL.Text = "Корзина (" + ReturnElement($"SELECT COUNT(*) FROM Order_realisation INNER JOIN Basket ON Order_realisation.id_order_realisation = Basket.id_order_realisation WHERE {ID_user} = Order_realisation.id_user AND Order_realisation.realized = 0") + "/10):";
            menuAnimate.Enabled = true;
            menuB.Checked = false;
        }
        public void IsSendToEmail(ref bool flag, Guna2ImageButton imageButton) 
        {
            if (!flag)
            { imageButton.Image = Properties.Resources.Not; flag = true; }
            else
            { imageButton.Image = Properties.Resources.Yes; flag = false; }
        }
        public void SendToEmail(long id_order_realisation, long ID_user)
        {
            if (IsThereAnInternetConnection(true, "Заказ не может быть отправлен на почту, так как отсутствует подключение к интернету."))
            {

                using (var conn = new SqlConnection(connectString))
                {
                    conn.Open();
                    var comm = new SqlCommand($"SELECT id_order,status, id_self_pickup_point, delivery_date, cost FROM Orders WHERE id_order_realisation = {id_order_realisation}", conn);
                    using (var reader = comm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var address = ReturnElement($"SELECT address FROM Self_pickup_points WHERE id_self_pickup_point = {reader[2]}");
                                var orderItem = new Order(reader[0].ToString(), reader.GetString(1), address, reader.GetDateTime(3).ToLongDateString(), reader[4].ToString(), id_order_realisation.ToString(), ID_user);
                                SendMessageToEmail(ReturnElement($"SELECT email FROM Users WHERE id_user = {ID_user}"), "Ваш заказ:", "", true, orderItem.OrderP());
                                orderItem.Dispose();
                            }
                        }
                    }
                }
            }
        }
        public async void FillOrder(FlowLayoutPanelDoubleBuffered flowLayoutPanel, long ID_order_realisation, bool flag)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT id_size, cost, amount FROM Basket WHERE id_order_realisation = {ID_order_realisation}", conn);
                using (var reader = comm.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var name = ReturnElement($"SELECT CONCAT(brand, ' / ', name) FROM Shoes WHERE id_shoes = " + $"{ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}")}");
                            var size = $"{ReturnElement($"SELECT size FROM Sizes WHERE id_size = {reader[0]}")}";
                            var color = ReturnElement($"SELECT color FROM Shoes WHERE id_shoes = " +
                            $"{ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}")}");
                            var id_shoes = ReturnElement($"SELECT id_shoes FROM Sizes WHERE id_size = {reader[0]}");
                            await Task.Run(async () =>{ await Task.Delay(1); });
                            if (!flag)
                                flowLayoutPanel.Controls.Add(new OrderItem(GetPictureFromByte(reader.GetInt64(0)), name, size, color, reader[1].ToString(), id_shoes, reader[2].ToString()));
                            else
                                flowLayoutPanel.Controls.Add(new OrderItem2(GetPictureFromByte(reader.GetInt64(0)), name, size, color, reader[1].ToString(), id_shoes, reader[2].ToString()));
                        }
                    }
                }

            }
        }
        public void QuantityGoods(string id_order_realisation, string condition)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var comm = new SqlCommand($"SELECT amount, id_size FROM Basket WHERE id_order_realisation = {id_order_realisation}", conn);
                var reader = comm.ExecuteReader();
                var list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader[0].ToString());
                    list.Add(reader[1].ToString());
                }
                var c = -1;
                for (var i = 0; i < list.Count / 2; i++)
                    ExecuteQuery($"UPDATE Sizes SET amount {condition} {list[++c]} FROM Sizes WHERE id_size = {list[++c]}");
            }
        }
        public void UpdateTableEntry(Guna2CirclePictureBox pictureBox, List<object> list, long ID_user)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                SqlCommand cmd;
                if (pictureBox.Image != null)
                {
                    cmd = new SqlCommand($"UPDATE Users SET role = @0, email = @1, password = @2, name = @3, phone = @4, picture = @5 WHERE id_user = {ID_user}", conn);
                    list.Add(PicturesConverter(pictureBox));
                }
                else
                    cmd = new SqlCommand($"UPDATE Users SET role = @0, email = @1, password = @2, name = @3, phone = @4 WHERE id_user = {ID_user}", conn);

                foreach (var i in list)
                {
                    var param = new SqlParameter($"@{list.IndexOf(i)}", i);
                    cmd.Parameters.Add(param);
                }
                cmd.ExecuteNonQuery();
            }
        }
        public byte[] PicturesConverter (Guna2CirclePictureBox pictureBox)
        {
            var bmp = new Bitmap((Bitmap)pictureBox.Image.Clone());
            var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            ms.Seek(0, SeekOrigin.Begin);
            return ms.ToArray();
        }
        public byte[] GetPictureFromByte(long id_size)
        {
            using (var conn = new SqlConnection(connectString))
            {
                conn.Open();
                var cmd = new SqlCommand($"SELECT TOP 1 picture FROM Pictures WHERE id_shoes IN (SELECT id_shoes FROM Sizes WHERE id_size = {id_size})", conn);
                return (byte[])cmd.ExecuteScalar();
            }
        }
    }
}
