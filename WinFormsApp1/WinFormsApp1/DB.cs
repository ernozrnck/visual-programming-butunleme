using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DB
    {
        readonly string server;
        readonly int port;
        readonly string uid;
        readonly string password;
        readonly string database;
        string sql;
        MySqlCommand cmd;
        private MySqlConnection conn;

        public DB(string server, int port, string uid, string password, string database)
        {
            this.server = server;
            this.port = port;
            this.uid = uid;
            this.password = password;
            this.database = database;
        }


        public void Connect()
        {
            string sql = "server=" + server + ";port=" + port + ";uid=" + uid + ";pwd=" + password + ";database=" + database + ";";
            conn = new MySqlConnection(sql);
            Open();
            Close();
        }

        private void Open()
        {
            conn.Open();
        }

        private void Close()
        {
            conn.Close();
        }

        public string[] KullaniciGetir(string TC)
        {
            sql = "SELECT * FROM `kullanici` where TC=" + TC;
            string[] result = rdrToArray(sql);
            return result;
        }

        public string[] PersonelGetir(string TC)
        {
            sql = "SELECT * FROM `personel` where TC=" + TC;
            string[] result = rdrToArray(sql);
            return result;
        }


        public void KullaniciEkle(string TC, string tamAd, string sifre, string Turk)
        {
            try
            {
                Open();
                sql = $"INSERT INTO `kullanici`(`TC`, `TamAd`, `sifre`, `turkmu`) VALUES ('{TC}','{tamAd}','{sifre}', '{Turk}')";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                Close();
            }
        }

        public void PersonelEkle(string TC, string ad, string soyad, string sifre)
        {
            try
            {
                Open();
                sql = $"INSERT INTO `personel`(`TC`, `ad`, `soyad`, `sifre`) VALUES ('{TC}','{ad}','{soyad}', '{sifre}')";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                Close();
            }
        }


        public string[][] Ilaclar()
        {
            sql = "SELECT isim, ureticisi FROM `ilaclar`;";
            string[][] result = rdrToArray2D(sql);
            return result;
        }

        public string[] ilacGetir(string isim)
        {
            sql = "SELECT ureticisi FROM `ilaclar` where isim='" + isim + "'";
            string[] result = rdrToArray(sql);
            return result;
        }



        public void IlacGuncelle(string eskiad, string yeniad, string uretici)
        {
            Open();
            sql = $"UPDATE `ilaclar` SET `isim`='{yeniad}', `ureticisi` = '{uretici}' WHERE `isim`='{eskiad}'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }


        public void ilacEkle(string isim, string uretici)
        {
            Open();
            sql = $"INSERT INTO `ilaclar`(`isim`, `ureticisi`) VALUES ('{isim}','{uretici}')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void ilacSil(string isim)
        {
            Open();
            sql = "DELETE FROM `ilaclar` WHERE isim = '" + isim + "'";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            Close();
        }




        private string[][] rdrToArray2D(string sql)
        {
            string[][] result = new string[0][];

            try
            {
                Open();
                MySqlCommand commandDatabase = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                int nrRanduri = 0;

                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nrRanduri++;
                    }
                }
                reader.Close();

                if (nrRanduri > 0)
                {
                    reader = commandDatabase.ExecuteReader();
                    result = new string[nrRanduri][];
                    for (int i = 0; i < nrRanduri; i++)
                    {
                        result[i] = new string[reader.FieldCount];
                    }
                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            for (int j = 0; j < reader.FieldCount; j++)
                            {
                                result[i][j] = reader.GetString(j);
                            }
                            i++;
                        }
                    }
                }
                Close();

            }
            catch (Exception ex)
            {
                Close();
                MessageBox.Show(ex.Message);
            }

            return result;
        }




        private string[] rdrToArray(string sql)
        {
            string[] result = null;
            try
            {
                Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result[i] = reader.GetValue(i).ToString();
                    }
                }
                reader.Close();
                Close();
            }
            catch (Exception ex)
            {
                Close();
                MessageBox.Show(ex.Message);
            }
            return result;
        }








    }
}
