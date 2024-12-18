using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        // Academy Functions
        public string GetAcademyName(int ID)
        {
            string query = $"SELECT Name FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        // Academy Profile Function
        public string GetAcademyAOE(int ID)
        {
            string query = $"SELECT AreaOfExpertise FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyDescription(int ID)
        {
            string query = $"SELECT Description FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int UpdateBasicAcademyProfile(int ID, string Name, string Description, string AOE)
        {
            string query = $"UPDATE Academies SET Name = '{Name}', Description = '{Description}', AreaOfExpertise = '{AOE}' WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }
        public string GetAcademyCertificateTitle(int ID)
        {
            string query = $"SELECT CertificateTitle FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyCertificateDateOfIssue(int ID)
        {
            string query = $"SELECT CertificateDateOfIssue FROM Academies WHERE AcademyID = {ID}";
            object result = dbMan.ExecuteScalar(query);



            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma

        }
        public string GetAcademyCertificateIssuingBody(int ID)
        {
            string query = $"SELECT CertificateIssuingBody FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyCertificateExpirationDate(int ID)
        {
            string query = $"SELECT CertificateExpirationDate FROM Academies WHERE AcademyID = {ID}";
            object result = dbMan.ExecuteScalar(query);



            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma
        }

        public int UpdateAcademyCertificate(int ID, string Title, string DateOfIssue, string IssuingBody, string ExpirationDate)
        {
            string query = $"UPDATE Academies SET CertificateTitle = '{Title}', CertificateDateOfIssue = '{DateOfIssue}', CertificateIssuingBody = '{IssuingBody}', CertificateExpirationDate = '{ExpirationDate}'  WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }






    }
}
