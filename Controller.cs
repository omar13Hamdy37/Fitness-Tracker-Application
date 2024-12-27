using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using System.Data.SqlClient;

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

        //  View Academy's sessions

        public DataTable GetAcademySessions(int ID, string SortBy, int limit)
        {
            string query;
            if (limit != 0)
            {
                query = $"SELECT TOP {limit} * FROM Sessions WHERE AcademyID = {ID}"; // Rebuild query to include TOP
            }
            else
            { query = $"SELECT * FROM Sessions WHERE AcademyID = {ID}"; }

            // han add sorting option based on the selected value
            switch (SortBy.ToLower())
            {
                case "oldest":
                    query += " ORDER BY Date ASC, Time ASC";
                    break;
                case "newest":
                    query += " ORDER BY Date DESC, Time DESC"; 
                    break;

            }



            return dbMan.ExecuteReader(query);
        }
        // Get all sessions
        public DataTable GetAllSessions(string SortBy, int limit)
        {
            string query;
            if (limit != 0)
            {
                query = $"SELECT TOP {limit} * FROM Sessions"; // Rebuild query to include TOP
            }
            else
            { query = $"SELECT * FROM Sessions"; }

            // han add sorting option based on the selected value
            switch (SortBy.ToLower())
            {
                case "oldest":
                    query += " ORDER BY Date ASC, Time ASC";
                    break;
                case "newest":
                    query += " ORDER BY Date DESC, Time DESC";
                    break;

            }



            return dbMan.ExecuteReader(query);
        }

        // Updating academy session



        public int AcademyUpdateSession(int sessionId,int AcademyID, string description, float price, int limit, string duration, string location, string date, string time)
        {
            string query = $"UPDATE Sessions SET Description = '{description}', Price = {price}, Limit = {limit}, " +
                           $"Duration = '{duration}', Location = '{location}', Date = '{date}', Time = '{time}' " +
                           $"WHERE SessionID = {sessionId} AND AcademyID = {AcademyID}";

            return dbMan.ExecuteNonQuery(query);
        }


        // Deleting Session

        public int DeleteSession(int sessionId, int academyId)
        {
            string query = $"DELETE FROM Sessions " +
                           $"WHERE SessionID = {sessionId} AND AcademyID = {academyId}";

            return dbMan.ExecuteNonQuery(query);
        }

        // Getting num of ppl attending

        public int GetNumberOfMembersAttendingSession(int sessionId, int academyId)
        {
            string query = $"SELECT COUNT(MemberID) " +
                           $"FROM ReservedSession " +
                           $"WHERE SessionID = {sessionId} AND AcademyID = {academyId}";

            return  (int) dbMan.ExecuteScalar(query);

        }

        // Session stats
        public DataTable GetMembersAgeGroupOfSession(int sessionID, int academyID)
        {
          string query = $@"
                           SELECT 
                               M.Age, 
                               COUNT(M.MemberID) AS NumberOfMembers
                           FROM 
                               ReservedSession RS
                           JOIN 
                               Members M ON RS.MemberID = M.MemberID
                           WHERE 
                               RS.SessionID = {sessionID }
                               AND RS.AcademyID = {academyID}
                           GROUP BY 
                               M.Age
                           ORDER BY 
                               M.Age";

          return dbMan.ExecuteReader(query);
            

        }
        public DataTable GetMembersAgeGroupOfAcademy( int academyID)
        {
            string query = $@"
                           SELECT 
                               M.Age, 
                               COUNT(M.MemberID) AS NumberOfMembers
                           FROM 
                               ReservedSession RS
                           JOIN 
                               Members M ON RS.MemberID = M.MemberID
                           WHERE 
                                RS.AcademyID = {academyID}
                           GROUP BY 
                               M.Age
                           ORDER BY 
                               M.Age";

            return dbMan.ExecuteReader(query);


        }
        public DataTable GetMembersGenderGroupOfSession(int sessionID, int academyID)
        {
            string query = $@"
                           SELECT 
                               M.Gender, 
                               COUNT(M.Gender) AS NumberOfMembers
                           FROM 
                               ReservedSession RS
                           JOIN 
                               Members M ON RS.MemberID = M.MemberID
                           WHERE 
                               RS.SessionID = {sessionID}
                               AND RS.AcademyID = {academyID}
                           GROUP BY 
                               M.Gender
";

            return dbMan.ExecuteReader(query);


        }


        public DataTable GetMembersGenderGroupOfAcademy( int academyID)
        {
            string query = $@"
                           SELECT 
                               M.Gender, 
                               COUNT(M.Gender) AS NumberOfMembers
                           FROM 
                               ReservedSession RS
                           JOIN 
                               Members M ON RS.MemberID = M.MemberID
                           WHERE 

                              RS.AcademyID = {academyID}
                           GROUP BY 
                               M.Gender
";

            return dbMan.ExecuteReader(query);


        }
        // Overall Stats

        public int GetCountDoneSessions(int academyID, DateTime today)
        {
                string query = $@"
                 SELECT COUNT(*) 
                 FROM Sessions
                 WHERE AcademyID = {academyID} 
                 AND Date < '{today:yyyy-MM-dd}' 
                 ";  


                return (int)dbMan.ExecuteScalar(query);
            }


        public int GetAllSessionsCount(int academyId)
        {
            string query = $@"
        SELECT COUNT(*) 
        FROM Sessions
        WHERE AcademyID = {academyId}";  

        return (int)dbMan.ExecuteScalar(query);  // ExecuteScalar returns the first column of the first row
        }

        public int GetAverageMembersPerSession(int academyID)
        {
            string query = $@"
        SELECT AVG(NumberOfMembers) AS AverageMembers
        FROM (
            SELECT 
                RS.SessionID, 
                COUNT(M.MemberID) AS NumberOfMembers
            FROM 
                ReservedSession RS
            JOIN 
                Members M ON RS.MemberID = M.MemberID
            WHERE 
                RS.AcademyID = {academyID}
            GROUP BY 
                RS.SessionID
        ) AS smt";
            // why does subquery need an alias? ask
            // remember en lazem el group by condition yeba fel select

            return (int)dbMan.ExecuteScalar(query); 
        }
        public int GetNumberOfSessions(int academyId)
        {
            string query = $@"
            SELECT COUNT(*) 
            FROM Sessions
            WHERE AcademyID = {academyId}";

            return (int)dbMan.ExecuteScalar(query);
        }

        // func to get total num of attendees ever

        public int GetTotalMembersAttendedAcademy(int academyID)
        {
            string query = $@"
        SELECT COUNT(RS.MemberID) 
        FROM ReservedSession RS
        WHERE RS.AcademyID = {academyID}";

            return (int)dbMan.ExecuteScalar(query);


        }
        // Reserve session

        public int ReserveSession(int MemberID, int SessionID, int AcademyID, int NumSeats)
        {
            string query = $@"
        INSERT INTO ReservedSession (MemberID, SessionID, AcademyID, NumberOfSeats)
        VALUES ({MemberID}, {SessionID}, {AcademyID}, {NumSeats});
          ";

            return dbMan.ExecuteNonQuery(query);
        }
        // Mark session as full

        public int MarkSessionAsFull(int sessionId, int academyId)
        {
            string query = $@"
        UPDATE Sessions
        SET FullSession = 1
        WHERE SessionID = {sessionId} AND AcademyID = {academyId};
        ";

            return dbMan.ExecuteNonQuery(query);
        }

        public int GetSeatsLeft(int sessionId, int academyId)
        {
            // negeeb limit
            string LimitQuery = $@"
                SELECT Limit
                FROM Sessions
                WHERE SessionID = {sessionId} AND AcademyID = {academyId};
            ";

            int sessionLimit = (int)dbMan.ExecuteScalar(LimitQuery);

            // Get the total number of reserved seats
            string reservedSeatsQuery = $@"
            SELECT SUM(NumberOfSeats)
            FROM ReservedSession
            WHERE SessionID = {sessionId} AND AcademyID = {academyId};
        ";

            object result = dbMan.ExecuteScalar(reservedSeatsQuery);
            int reservedSeats;
            // result can be null if no seats
            if (result != DBNull.Value)
            {
                reservedSeats =(int) result; 
            }
            else
            {
                reservedSeats = 0; 
            }

            int seatsLeft = sessionLimit - reservedSeats;

            return seatsLeft;
        }

        // Check if reservation exists

        public bool ReservationExists(int sessionId, int memberId, int academyId)
        {

            string query = $@"
            SELECT COUNT(*)
            FROM ReservedSession
            WHERE SessionID = {sessionId}
            AND MemberID = {memberId}
            AND AcademyID = {academyId};
    ";


            int count = (int) dbMan.ExecuteScalar(query);


            return count > 0;
        }



    }
}
