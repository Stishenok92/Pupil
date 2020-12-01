using System;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Collections.Generic;
using Model.Entity;

namespace Controller
{
    
    
    internal class Program
    {
        private const string CONNECTION_STRING = "Data Source = *****; User ID = Pupil; Password = ******";

        private const string SELECT_ALL_PUPILS = "SELECT * FROM pupil";
        private const string SELECT_PUPIL_COUNT = "SELECT COUNT(*) FROM pupil";
        private const string DELETE_STUDENT = "DELETE FROM Pupil WHERE pupil_id = @id";
        private const string INSERT_PUPIL = "INSERT INTO Pupil(surname, name, passport, birthday, rating) VALUES (@surname, @name, @passport, @birthday, @rating)";
        private const string UPDATE_STUDENTS_MARK = "UPDATE Pupil SET rating = rating - 0.5";

        private static void Main(string[] args)
        {
            IList<Pupil> list = null;
            SqlConnection connection = null;
            
            connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            
            SqlCommand cmd = new SqlCommand(UPDATE_STUDENTS_MARK, connection);
            
            // SqlParameter idPrm = new SqlParameter();
            // idPrm.Value = 15;
            // idPrm.SqlDbType = SqlDbType.Int;
            // idPrm.ParameterName = "@id";
            // idPrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(idPrm);
            
            
            
            
            // SqlCommand cmd = new SqlCommand(INSERT_PUPIL, connection);
            // Pupil pupil = new Pupil("Stishenok", "Anna", "HB4353553", new DateTime(2001, 12, 12), 7.5);
            // SqlParameter surnamePrm = new SqlParameter();
            // surnamePrm.Value = pupil.Surname;
            // surnamePrm.SqlDbType = SqlDbType.NVarChar;
            // surnamePrm.ParameterName = "@surname";
            // surnamePrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(surnamePrm);
            //
            // SqlParameter namePrm = new SqlParameter();
            // namePrm.Value = pupil.Name;
            // surnamePrm.SqlDbType = SqlDbType.NVarChar;
            // namePrm.ParameterName = "@name";
            // namePrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(namePrm);
            //
            // SqlParameter passportPrm = new SqlParameter();
            // passportPrm.Value = pupil.Passport;
            // surnamePrm.SqlDbType = SqlDbType.NVarChar;
            // passportPrm.ParameterName = "@passport";
            // passportPrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(passportPrm);
            //
            // SqlParameter birthdayPrm = new SqlParameter();
            // birthdayPrm.Value = pupil.Birthday;
            // birthdayPrm.SqlDbType = SqlDbType.DateTime;
            // birthdayPrm.ParameterName = "@birthday";
            // birthdayPrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(birthdayPrm);
            //
            // SqlParameter ratingPrm = new SqlParameter();
            // ratingPrm.Value = pupil.Rating;
            // ratingPrm.SqlDbType = SqlDbType.Real;
            // ratingPrm.ParameterName = "@rating";
            // ratingPrm.Direction = ParameterDirection.Input;
            // cmd.Parameters.Add(ratingPrm);
            
            cmd.ExecuteNonQuery();
            
            
            // SqlCommand cmd = new SqlCommand(SELECT_ALL_PUPILS, connection);
            // SqlDataReader reader = cmd.ExecuteReader();
            //
            // list = new List<Pupil>();
            //
            // if (reader.HasRows) //если есть данные
            // {
            //     while (reader.Read())
            //     {
            //         Pupil pupil = new Pupil();
            //
            //
            //         if (!reader.IsDBNull(1)) pupil.Surname = reader.GetString(1);
            //         if (!reader.IsDBNull(2)) pupil.Name = reader.GetString(2);
            //         if (!reader.IsDBNull(3)) pupil.Passport = reader.GetString(3);
            //         if (!reader.IsDBNull(4)) pupil.Birthday = reader.GetDateTime(4);
            //         if (!reader.IsDBNull(5)) pupil.Rating = reader.GetFloat((5));
            //         list.Add(pupil);
            //     }
            // }
            
            // SqlCommand cmd = new SqlCommand(SELECT_PUPIL_COUNT, connection);
            // int count = (int)cmd.ExecuteScalar();
            // Console.WriteLine(count);
            
            
            
            
            
            
            
            
            
            
            // Pupil pupil1 = new Pupil("Stishenok", "Vadim", "HB3120050", new DateTime(1992, 11,07), 57.345);
            // Pupil pupil2 = new Pupil("Stishenok", "Vadim", "HB3120050", new DateTime(1992, 11,07), 6.0);
            // Pupil pupil3 = new Pupil("Stishenok", "Vadim", "HB3120050", new DateTime(1992, 11,07), 7.6);
            //
            // IList<Pupil> list = new List<Pupil>();
            // list.Add(pupil1);
            // list.Add(pupil2);
            // list.Add(pupil3); 
            //
            //
            // Console.WriteLine(Manager.CalculateAvgRating(list));
            // Console.WriteLine(pupil1);


            // foreach (Pupil pupil in list)
            // {
            //     Console.WriteLine(pupil);
            // }
            
            connection.Close();
        }
    }
}