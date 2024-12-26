using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using System.Xml.Linq;

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
        public int GetAcademyID(string username)
        { 
            string query = $"SELECT AcademyID FROM Academies WHERE Username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetAcademyName(int ID)
        {
            string query = $"SELECT Name FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
        // Academy Profile Function

        // Profile part

        // Getting
        public string GetAcademyUsername(int ID)
        {
            string query = $"SELECT AreaOfExpertise FROM Academies WHERE AcademyID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }
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

        public string GetAcademyPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }


        // Updating
        public int UpdateBasicAcademyProfile(int ID, string Name, string Description, string AOE)
        {
            string query = $"UPDATE Academies SET Name = '{Name}', Description = '{Description}', AreaOfExpertise = '{AOE}' WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateUsernamePasswordAcademy(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);

        }

        // Certificate part
        // Getting
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
        // Updating
        public int UpdateAcademyCertificate(int ID, string Title, string DateOfIssue, string IssuingBody, string ExpirationDate)
        {
            string query = $"UPDATE Academies SET CertificateTitle = '{Title}', CertificateDateOfIssue = '{DateOfIssue}', CertificateIssuingBody = '{IssuingBody}', CertificateExpirationDate = '{ExpirationDate}'  WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);

        }

        // Academy Post Session

        // Inserting 
        public int AcademyInsertSession(string description, float price, int limit, string duration, string location, string date, string time, int academyId)
        {
            // Session should not be empty
            int fullSession = 0;
            // new session id
            int SessionID = GetCountSessionFromAcademy(academyId) + 1; 

            string query = $"INSERT INTO Sessions (SessionID, Description, Price, Limit, Duration, FullSession, Location, Date, Time, AcademyID) " +
                           $"VALUES ({SessionID},'{description}', {price}, {limit}, '{duration}',{fullSession}, '{location}', '{date}', '{time}', {academyId})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetCountSessionFromAcademy(int ID)
        {
            string query = $"SELECT COUNT(*) FROM Sessions WHERE AcademyID = {ID}";
            return (int) dbMan.ExecuteScalar(query);
        }


        // Delete academy account

        public int DeleteAcademyUser(string username)
        {
            string query = $"DELETE FROM Users WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);

        }

        public int DeleteAcademy(int ID)
        {
            string query = $"DELETE FROM Academies WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// ROZA //////////////////// MEMBER STUFF///////////////////////////////////////////////////
        // Member Functions for loading info
        public int GetMemberID(string username)
        {
            string query = $"SELECT MemberID FROM Members WHERE Username = '{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetMemberName(int ID)
        {
            string query = $"SELECT Fname + ' ' + Lname AS FullName FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        // Member Profile Functions

        // Getting
        public string GetMemberUsername(int ID)
        {
            string query = $"SELECT Username FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetMemberPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetMemberFirstName(int ID)
        {
            string query = $"SELECT Fname FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetMemberLastName(int ID)
        {
            string query = $"SELECT Lname FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int GetMemberAge(int ID)
        {
            string query = $"SELECT Age FROM Members WHERE MemberID = {ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public decimal GetMemberWeight(int ID)
        {
            string query = $"SELECT Weight FROM Members WHERE MemberID = {ID}";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public decimal GetMemberHeight(int ID)
        {
            string query = $"SELECT Height FROM Members WHERE MemberID = {ID}";
            return (decimal)dbMan.ExecuteScalar(query);
        }

        public string GetMemberGender(int ID)
        {
            string query = $"SELECT Gender FROM Members WHERE MemberID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1)edit profile 
        ///////////////////////////////////////////////////////////////
        ///   
        public int UpdateMemberProfile(string username, string firstName, string lastName, int age, float weight, float height, int dietId)
        {
            string query = $"UPDATE Members " +
                           $"SET Fname = '{firstName}', Lname = '{lastName}', Age = {age}, Weight = {weight}, Height = {height}, DietID = {dietId} " +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }
        ////////////////////////////////////////////////////////////
        //2)Choose a Fitness Goal
        ////////////////////////////////////////////////////////////////////
        public int SetFitnessGoal(string username, string goalName)
        {
            string query = $"UPDATE Members " +
                           $"SET FitnessGoalID = (SELECT GoalID FROM FitnessGoals WHERE GoalName = '{goalName}') " +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }
        ////////////////////////////////////////////////////////////////
        //3)Log Exercise
        //////////////////////////////////////////////////////////
        public int LogMemberExercise(string username, int exerciseId, int minutesExercised, int caloriesBurned, int pointsAwarded)
        {
            string query = $"INSERT INTO MemberLogExercise (MemberID, ExerciseID, DateTimeLogged, MinutesExercised, CaloriesBurned, PointsAwarded) " +
                           $"VALUES ((SELECT MemberID FROM Members WHERE Username = '{username}'), {exerciseId}, GETDATE(), {minutesExercised}, {caloriesBurned}, {pointsAwarded})";
            return dbMan.ExecuteNonQuery(query);
        }
        ///////////////////////////////////////////////////////////////

    }
}
