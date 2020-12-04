using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace _76
{
    public static class Bağla
    {
        public static SqlConnection conn;

        static Bağla()
        {
            conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|Db.mdf;");
        }

        #region Aç/Kapa

        public static void Open()
        {
            conn.Open();
        }
        public static void Close()
        {
            conn.Close();
        }

        #endregion

        #region Listele

        public static DataView Listele(string sorgu)
        {
            Open();
            SqlCommand komut = new SqlCommand(sorgu, conn);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            Close();
            return dt.DefaultView;
        }

        #endregion

        #region Resim

        public static byte[] BitmapSourcetoByteArray(BitmapSource ResimKaynak)
        {
            #region BitmapSource'u byte[]'a Çevir (Veritabanına yazarken)

            byte[] byteDizisi;
            if (ResimKaynak == null)
            {
                byteDizisi = new byte[0];
            }
            else
            {
                using (var stream = new MemoryStream())
                {
                    var kodlayıcı = new PngBitmapEncoder();
                    kodlayıcı.Frames.Add(BitmapFrame.Create(ResimKaynak));
                    kodlayıcı.Save(stream);
                    byteDizisi = stream.ToArray();
                }
            }
            return byteDizisi;
            #endregion
        }
        public static BitmapSource ByteArraytoBitmapSource(byte[] byteDizisi)
        {
            #region byte[]'ı BitmapSource'a Çevir (Veritabanından okurken)

            if (byteDizisi != null && byteDizisi.Length > 0)
            {
                using (var stream = new MemoryStream(byteDizisi))
                {
                    var kodÇözücü = BitmapDecoder.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                    return kodÇözücü.Frames[0];
                }
            }
            else
            {
                return null;
            }

            #endregion
        }

        #endregion

    }
}
