using HastaneOtomasyon.Hasta.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Hasta.Services
{
    public interface IPatientService
    {
        void AddPatient(PatientModel patient);
        void UpdatePatient(PatientModel patient);
        void DeletePatient(int patientId);
        PatientModel FindPatient(int patientId);
    }

    public class PatientService : IPatientService
    {
        //https://www.connectionstrings.com/ : Bilinen pek çok veritabanı için bağlantı cümlesi formatlarını tutar.
        private string connection_string = @"Server=localhost\sqlexpress;Database=HastaneOtomasyon;Trusted_Connection=True;";

        private SqlConnection connection;

        public PatientService()
        {
            connection = new SqlConnection(connection_string);
        }

        public void AddPatient(PatientModel patient)
        {
            string columns = "", values = "";
            if (!string.IsNullOrEmpty(patient.Neighbourhood))
            {
                columns += "Mahalle,";
                values += "@mahalle,";
            }

            if (!string.IsNullOrEmpty(patient.StreetAlley))
            {
                columns += "Sokak,";
                values += "@sokak,";
            }

            if (!string.IsNullOrEmpty(patient.BloodType.ToString()))
            {
                columns += "KanGrubu,";
                values += "@kangrubu,";
            }

            if (!string.IsNullOrEmpty(patient.Phone1))
            {
                columns += "TelefonNo1,";
                values += "@telefonNo1,";
            }

            if (!string.IsNullOrEmpty(patient.Phone2))
            {
                columns += "TelefonNo2,";
                values += "@telefonNo2,";
            }

            if (!string.IsNullOrEmpty(patient.Phone3))
            {
                columns += "TelefonNo3,";
                values += "@telefonNo3,";
            }

            string query = $"INSERT INTO Hasta ({columns}TCKimlikNo,Ad,Soyad,Cinsiyet,DogumTarihi,Il,Ilce) VALUES ({values}@tckimlikno,@ad,@soyad,@cinsiyet,@dogumtarihi,@il,@ilce)";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@tckimlikno", patient.NationalID);
            command.Parameters.AddWithValue("@ad", patient.Firstname);
            command.Parameters.AddWithValue("@soyad", patient.Lastname);
            command.Parameters.AddWithValue("@cinsiyet", patient.Gender);
            command.Parameters.AddWithValue("@dogumtarihi", patient.DateOfBirth);
            command.Parameters.AddWithValue("@il", patient.City);
            command.Parameters.AddWithValue("@ilce", patient.District);
            if (!string.IsNullOrEmpty(patient.Neighbourhood))
            {
                command.Parameters.AddWithValue("@mahalle", patient.Neighbourhood);
            }

            if (!string.IsNullOrEmpty(patient.StreetAlley))
            {
                command.Parameters.AddWithValue("@sokak", patient.StreetAlley);
            }

            if (!string.IsNullOrEmpty(patient.BloodType.ToString()))
            {
                command.Parameters.AddWithValue("@kangrubu", patient.BloodType);
            }

            if (!string.IsNullOrEmpty(patient.Phone1))
            {
                command.Parameters.AddWithValue("@telefonNo1", patient.Phone1);
            }

            if (!string.IsNullOrEmpty(patient.Phone2))
            {
                command.Parameters.AddWithValue("@telefonNo2", patient.Phone2);
            }

            if (!string.IsNullOrEmpty(patient.Phone3))
            {
                command.Parameters.AddWithValue("@telefonNo3", patient.Phone3);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeletePatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public PatientModel FindPatient(int patientId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient(PatientModel patient)
        {
            throw new NotImplementedException();
        }
    }
}
