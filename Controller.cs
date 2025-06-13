﻿using System;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan;

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
            return (int)dbMan.ExecuteScalar(query);
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
                query = $"SELECT TOP {limit} * FROM Sessions WHERE AcademyID = {ID}";
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
                query = $"SELECT TOP {limit} * FROM Sessions";
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

        public int AcademyUpdateSession(int sessionId, int AcademyID, string description, float price, int limit, string duration, string location, string date, string time)
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

            return (int)dbMan.ExecuteScalar(query);
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
                               RS.SessionID = {sessionID}
                               AND RS.AcademyID = {academyID}
                           GROUP BY
                               M.Age
                           ORDER BY
                               M.Age";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMembersAgeGroupOfAcademy(int academyID)
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

        public DataTable GetMembersGenderGroupOfAcademy(int academyID)
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

        // Mark as not full

        public int MarkSessionAsNotFull(int sessionId, int academyId)
        {
            string query = $@"
        UPDATE Sessions
        SET FullSession = 0
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
            if (result != null && result != DBNull.Value)
            {
                reservedSeats = (int)result;
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

            int count = (int)dbMan.ExecuteScalar(query);

            return count > 0;
        }

        // Get all meals

        public DataTable GetAllMeals(string SortBy, int limit)
        {
            string query;
            if (limit != 0)
            {
                query = $"SELECT TOP {limit} Meals.*, Coaches.Username FROM Meals JOIN Coaches ON Meals.CoachID = Coaches.CoachID";
            }
            else
            { query = query = $"SELECT Meals.*, Coaches.Username FROM Meals JOIN Coaches ON Meals.CoachID = Coaches.CoachID"; }

            // han add sorting option based on the selected value
            switch (SortBy.ToLower())
            {
                case "oldest":
                    query += " ORDER BY DatePosted ASC";
                    break;

                case "newest":
                    query += " ORDER BY DatePosted DESC";
                    break;
            }

            return dbMan.ExecuteReader(query);
        }

        // Get num of seats of member in a certain session
        public int GetNumberOfSeatsOfMember(int sessionId, int memberId, int academyId)
        {
            string query = $@"
             SELECT NumberOfSeats
             FROM ReservedSession
             WHERE SessionID = {sessionId}
             AND MemberID = {memberId}
             AND AcademyID = {academyId};
             ";

            object result = dbMan.ExecuteScalar(query);

            if (result != null && result != DBNull.Value)
            {
                return (int)result;
            }

            return 0;
        }

        // Delete reservation of member
        public int DeleteReservation(int sessionId, int memberId, int academyId)
        {
            string query = $@"
             DELETE FROM ReservedSession
             WHERE SessionID = {sessionId}
             AND MemberID = {memberId}
             AND AcademyID = {academyId};
             ";

            return dbMan.ExecuteNonQuery(query);
        }

        public int GetSeatsTaken(int sessionId, int academyId)
        {
            string query = $@"
         SELECT SUM(NumberOfSeats)
         FROM ReservedSession
         WHERE SessionID = {sessionId} AND AcademyID = {academyId};
         ";

            object result = dbMan.ExecuteScalar(query);
            int reservedSeats;

            if (result != null && result != DBNull.Value)
            {
                reservedSeats = (int)result;
            }
            else
            {
                reservedSeats = 0;
            }

            // Return the number of seats taken
            return reservedSeats;
        }

        public bool IsSessionFull(int sessionId, int academyId)
        {
            string query = $@"
             SELECT FullSession
             FROM Sessions
             WHERE SessionID = {sessionId} AND AcademyID = {academyId};
             ";

            object result = dbMan.ExecuteScalar(query);

            if (result != null && result != DBNull.Value)
            {
                return (bool)result;
            }

            // no reservation keda
            return false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////// ROZA //////////////////// MEMBER STUFF///////////////////////////////////////////////////
        // Member Functions for loading info
       // public int GetMemberID(string username)
       // {
       //     string query = $"SELECT MemberID FROM Members WHERE Username = '{username}'";
       //     return (int)dbMan.ExecuteScalar(query);
       // }

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

        /////////////////////////////////////fitness goal /////////////////////////////////////
        ///////////////////////////////remove the check after fixing the notnull in db/////////////////////
        public int GetMemberFitnessGoalID(int ID)
        {
            string query = $"SELECT FitnessGoalID FROM Members WHERE MemberID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            if (result == DBNull.Value)
            {
                return 0;
            }
            else
            {
                return (int)result;
            }
        }

        /// /////////////////////////////////////////////////////////////////////////

        public string GetFitnessGoalName(int goalID)
        {
            if (goalID == 0)
                return "";

            string query = $"SELECT GoalName FROM FitnessGoals WHERE GoalID = {goalID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int UpdateUsernamePasswordmember(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);
        }

        //public int UpdateUsernamePasswordmember(string OldUsername, string NewUsername, string password)
        //{
        //    // First, set the old username to null
        //    string query1 = $"UPDATE Members SET Username = NULL WHERE Username = '{OldUsername}'";
        //    dbMan.ExecuteNonQuery(query1);

        //    // Then, update the username
        //    string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username IS NULL";
        //    return dbMan.ExecuteNonQuery(query);

        //}
        public int DeleteMemberByID(int ID)
        {
            // Update the Username in Users table to NULL
            string query1 = $"UPDATE Users SET Username = NULL WHERE MemberID = {ID}";
            dbMan.ExecuteNonQuery(query1);

            // Delete the member from the Members table
            string query = $"DELETE FROM Members WHERE MemberID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1)edit profile
        ///////////////////////////////////////////////////////////////
        ///
        public int UpdateMemberProfile(string username, string firstName, string lastName, int age, decimal weight, decimal height, char gender)
        {
            string query = $"UPDATE Members " +
                           $"SET Fname = '{firstName}', Lname = '{lastName}', Age = {age}, Weight = {weight}, Height = {height}, Gender='{gender}'" +
                           $"WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }

        ////////////////////////////////////////////////////////////
        //2)Choose a Fitness Goal
        ////////////////////////////////////////////////////////////////////
        public int GetFitnessGoalIDByName(string goalName)
        {
            string query = $"SELECT GoalID FROM FitnessGoals WHERE GoalName = '{goalName}'";
            object result = dbMan.ExecuteScalar(query);
            return (int)result;
        }

        public int UpdateMemberFitnessGoal(string username, int goalID)
        {
            string query = $"UPDATE Members SET FitnessGoalID = {goalID} WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SetFitnessGoal(string username, string fitnessgoalName)
        {
            int goalID = GetFitnessGoalIDByName(fitnessgoalName);
            return UpdateMemberFitnessGoal(username, goalID);
        }

        ////////////////////////////////////////////////////////////////
        //////////////////////////

        public DataTable GetExercises()
        {
            string query = "SELECT * FROM Exercises";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt;
        }

        /////////////////////////////////////////////////////////////

        public decimal GetCaloriesBurnedByExerciseID(string exercisen)
        {
            string query = $"SELECT CaloriesBurnedPerMin FROM Exercises WHERE ExerciseName =  '{exercisen}' ";

            return (decimal)(dbMan.ExecuteScalar(query));
        }

        public int Getpointsearned(string exercisen)
        {
            string query = $"SELECT PointsPerMin FROM Exercises WHERE ExerciseName =  '{exercisen}' ";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

      //public int GetExerciseID(string exerciseName)
      //{
      //    string query = $"SELECT ExerciseID FROM Exercises WHERE ExerciseName = '{exerciseName}'";
      //    return Convert.ToInt32(dbMan.ExecuteScalar(query));
      //}

        public int UpdateMemberPoints(int ID, int pointsToAdd)
        {
            string query = $"UPDATE Members SET Points = Points + {pointsToAdd} WHERE MemberID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        // 4. Log Calories
        ///////////////////////////////////////////////

        //public int LogData(int memberID, string dataName, string dataValue)
        //{
        //    string query = $"INSERT INTO MemberLogData (MemberID, DataName, DataValue, LogDate) " +
        //                   $"VALUES ({memberID}, '{dataName}', '{dataValue}', GETDATE())";
        //    return dbMan.ExecuteNonQuery(query);
        //}
        //3)Log Exercise
        //////////////////////////////////////////////////////////
        public int LogCalories(int ID, string Datetime, int caloriesConsumed)
        {
            int count = countofCaloriesRecordExist(ID, Datetime);
            if (count > 0)
            {
                // Calorie entry for this member and date already exists
                MessageBox.Show("Calories for this member on this date is already logged.");
                return 0;
            }

            string query = $"INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed) " +
                           $"VALUES ({ID}, '{Datetime}', {caloriesConsumed})";

            return dbMan.ExecuteNonQuery(query);
        }

        private int countofCaloriesRecordExist(int memberID, string datetime)
        {
            string query = $"SELECT COUNT(*) FROM MemberLogCalories " +
                           $"WHERE MemberID = {memberID} AND DateTimeLogged = '{datetime}'";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        /// for streak

        ////////////////////////////////////////////////////////////////////////////
        public int LogMemberExercise(int ID, int exerciseId, string Datetime, int minutesExercised, decimal caloriesBurned, int pointsAwarded)
        {
            int count = countofLogExerciseRecordExist(ID, exerciseId, Datetime);
            if (count > 0)
            {
                MessageBox.Show("Exercise for this member and date already logged.");
                return 0;
            }
            string query = $"INSERT INTO  MemberLogExercise(MemberID, ExerciseID, DateTimeLogged, MinutesExercised, CaloriesBurned, PointsAwarded) " +
                           $"VALUES ({ID},{exerciseId},'{Datetime}', {minutesExercised},{caloriesBurned},{pointsAwarded})";
            return dbMan.ExecuteNonQuery(query);
        }

        ///////////////////////////////////////////////////////////////to count law dakhal before //////////////////
        private int countofLogExerciseRecordExist(int ID, int exerciseId, string datetime)
        {
            string query = $"SELECT COUNT(*) FROM MemberLogExercise WHERE MemberID = {ID} AND ExerciseID = {exerciseId} AND DateTimeLogged = '{datetime}'";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        ////////////////////////////////////////////////////////////////////////////////////////for streak///////////////////////////////////////////////
        //public int GetSuggestedCalories(int ID)
        //{
        //    string query = $"SELECT SuggestedCalories FROM Members WHERE MemberID = {ID}";

        //    return Convert.ToInt32(dbMan.ExecuteScalar(query));
        //}
        public int GetAllowedCalories(int memberID)
        {
            string query = $"SELECT AllowedCalorieIntake FROM Members WHERE MemberID = {memberID}";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int LogCalories(int memberID, string datetime, int caloriesConsumed, int allowedcalories)
        {
            int count = countofCaloriesRecordExist(memberID, datetime);
            if (count > 0)
            {
                MessageBox.Show("Calories for this member and date already logged.");
                return 0;
            }

            string query = $"INSERT INTO MemberLogCalories (MemberID, DateTimeLogged, CaloriesConsumed) " +
                           $"VALUES ({memberID}, '{datetime}', {caloriesConsumed})";

            int insertion = dbMan.ExecuteNonQuery(query);

            if (insertion > 0)
            {
                if (caloriesConsumed <= allowedcalories)
                {
                    UpdateStreak(memberID);
                }
                else
                {
                    ResetStreak(memberID);
                }
            }

            return insertion;
        }

        private void UpdateStreak(int ID)
        {
            string query = $"UPDATE Members SET Streak = Streak + 1 WHERE MemberID = {ID}";

            dbMan.ExecuteNonQuery(query);
        }

        private void ResetStreak(int ID)
        {
            string query = $"UPDATE Members SET Streak = 0 WHERE MemberID = {ID}";

            dbMan.ExecuteNonQuery(query);
        }

        public int GetStreak(int ID)
        {
            string query = $"SELECT Streak FROM Members WHERE MemberID = {ID}";

            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        /////////////////////updating allowed calories with weight and height ....///////
        public int UpdateAllowedCalorieIntake(decimal weight, decimal height, int age, char gender, string username)
        {
            int caloriess;

            if (gender == 'M')
            {
                caloriess = (int)(88.362 + (13.397 * (double)weight) + (4.799 * (double)height) - (5.677 * age));
            }
            else if (gender == 'F')
            {
                caloriess = (int)(447.593 + (9.247 * (double)weight) + (3.098 * (double)height) - (4.330 * age));
            }
            else
            {
                MessageBox.Show(" problem with gender in update allowedcalorieintake function");
                caloriess = 0;
            }

            // SQL query to update the AllowedCalorieIntake
            string query = $"UPDATE Members " +
                           $"SET AllowedCalorieIntake = {caloriess} " +
                           $"WHERE Username = '{username}'";

            return dbMan.ExecuteNonQuery(query);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///new but also fih fo2 new///////////////////////////////////////////////////////////
        ///ibrahim ask
        public int GetMemberRankById(int memberId)
        {
            string query = $"SELECT 1 + (SELECT COUNT(*) FROM Members AS OtherMembers WHERE OtherMembers.Points > (SELECT Points FROM Members WHERE MemberID = {memberId}))";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable getbadgesearnedbyMember(int memberId)
        {
            string query = $"SELECT b.BadgeName, b.Description, b.PointsNeeded, be.DateEarned " +
                           $"FROM Badges b, BadgesEarned be " +
                           $"WHERE b.BadgeID = be.BadgeID AND be.MemberID = {memberId}";

            return dbMan.ExecuteReader(query);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////for feedback//////////////////////////////////
        public DataTable GetFeedbackTypes()
        {
            string query = "SELECT TypeID, TypeName FROM FeedbackTypes";
            return dbMan.ExecuteReader(query);
        }

        public int Insertfeedback(int Id, string feedbackText, int rating, int feedbackTypeId, string feedbackDate)
        {
            string query1 = $"INSERT INTO Feedback (Comment, Rating, FeedbackTypeID, DatePosted) " +
                                     $"VALUES ('{feedbackText}', {rating}, {feedbackTypeId}, '{feedbackDate}')";

            dbMan.ExecuteNonQuery(query1);

            string getLastInsertedIdQuery = "SELECT MAX(FeedbackID) FROM Feedback";
            int feedbackId = Convert.ToInt32(dbMan.ExecuteScalar(getLastInsertedIdQuery));

            // inserting into MemberFeedback table //ask ibrahim abt identity (1,1)
            string q2 = $"INSERT INTO MemberFeedback (FeedbackID, MemberID) VALUES ({feedbackId}, {Id});";
            dbMan.ExecuteNonQuery(q2);

            return feedbackId;
        }

        public bool DoesMemberHaveCoach(int memberId)
        {
            string query = $"SELECT COUNT(*) FROM CoachedBy WHERE MemberID = {memberId} AND Ongoing = 1";
            int count = Convert.ToInt32(dbMan.ExecuteScalar(query));
            if (count > 0)
            { return true; }
            else { return false; }
        }

        public int GetFeedbackTypeID(string feedbackTypeName)
        {
            string query = $"SELECT TypeID FROM FeedbackTypes WHERE TypeName = '{feedbackTypeName}'";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int UpdateCoachedByRating(int memberId, decimal newRating)
        {
            string query = $"UPDATE CoachedBy SET Rating = {newRating} WHERE MemberID = {memberId} AND Ongoing = {1}";

            return dbMan.ExecuteNonQuery(query);
        }

        public decimal GetAverageCaloriesIntake(int memberId)
        {
            string query = $"SELECT AVG(CaloriesConsumed) FROM MemberLogCalories WHERE MemberID = {memberId}";
            return Convert.ToDecimal(dbMan.ExecuteScalar(query));
        }

        public decimal GetAverageCaloriesBurned(int memberId)
        {
            string query = $"SELECT AVG(CaloriesBurned) FROM MemberLogExercise WHERE MemberID = {memberId}";
            return Convert.ToDecimal(dbMan.ExecuteScalar(query));
        }

        public bool DeleteMember(int memberId)
        {
            string query = $"DELETE FROM Members WHERE MemberID = {memberId}";
            return dbMan.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteUser(string username)
        {
            string query = $"DELETE FROM Users WHERE Username = '{username}'";
            return dbMan.ExecuteNonQuery(query) > 0;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////NOUR ISLAM///////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //coach functionalities
        //getting all the coach info
        public int GetCoachID(string username)
        {
            string query = $"SELECT CoachID FROM Coaches WHERE Username ='{username}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetCoachName(int ID)
        {
            string query = $"SELECT Fname FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetCoachLastName(int ID)
        {
            string query = $"SELECT Lname FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetGender(int ID)
        {
            string query = $"SELECT Gender FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int GetCoachAge(int ID)
        {
            string query = $"SELECT Age FROM Coaches WHERE CoachID={ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int GetMemberLimit(int ID)
        {
            string query = $"SELECT MemberLimit FROM Coaches WHERE CoachID={ID}";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetCoachPassword(string username)
        {
            string query = $"SELECT Password FROM Users WHERE Username = '{username}'";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int UpdateCoachProfile(string fname, string lname, int coachid, string gender, int age)
        {
            if (gender == "Female")
            {
                gender = "F";
            }
            else
            {
                gender = "M";
            }
            string query = $"UPDATE Coaches SET Fname = '{fname}', Lname = '{lname}', Age = '{age}', Gender='{gender}' WHERE CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateUsernamePasswordCoach(string OldUsername, string NewUsername, string password)
        {
            string query = $"UPDATE Users SET Username = '{NewUsername}', Password = '{password}' WHERE Username = '{OldUsername}'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateCoachCertificate(int ID, string Title, string DateOfIssue, string IssuingBody, string ExpirationDate)
        {
            string query = $"UPDATE Coaches SET CertificateTitle = '{Title}', CertificateDateOfIssue = '{DateOfIssue}', CertificateIssuingBody = '{IssuingBody}', CertificateExpirationDate = '{ExpirationDate}'  WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        //to get all certificate info
        public string GetCoachCertificateTitle(int ID)
        {
            string query = $"SELECT CertificateTitle FROM Coaches WHERE CoachID={ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetCoachCertificateDateOfIssue(int ID)
        {
            string query = $"SELECT CertificateDateOfIssue FROM Coaches WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma
        }

        public string GetCoachCertificateIssuingBody(int ID)
        {
            string query = $"SELECT CertificateIssuingBody FROM Coaches WHERE CoachID = {ID}";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string GetCoachCertificateExpirationDate(int ID)
        {
            string query = $"SELECT CertificateExpirationDate FROM Coaches WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            DateTime certificateDate = (DateTime)result;
            return certificateDate.ToString("yyyy-MM-dd"); // or any other desired forma
        }

        //view member
        //public int GetMemberID(string username)
        //{
        //    string query = $"SELECT MemberID FROM Members WHERE Username={username}";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public int GetMemberID(string username)
        {
            string query = $"SELECT MemberID FROM Members WHERE Username = '{username}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MemberID"]);
            }
            else
            {
                return 0;
            }
        }

        public DataTable ViewMember(int ID)
        {
            string query = $"SELECT m.Fname, m.Lname, m.Age, m.Weight, m.Height, m.AllowedCalorieIntake, m.Streak, m.Points, m.Gender, fg.GoalName, d.DietName  " +
                          $"FROM Members m  " +
                          $"LEFT JOIN FitnessGoals fg ON m.FitnessGoalID = fg.GoalID  " +
                          $"LEFT JOIN Diets d ON m.DietID = d.DietID WHERE m.MemberID = {ID}";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetUsernamesofMembers(int ID)
        {
            string query = $"SELECT m.Username, m.Points " +
                $"FROM Members m " +
                $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1;";
            return dbMan.ExecuteReader(query);
        }

        public int GetMaxChallengeID()
        {
            string query = $"SELECT MAX(ChallengeID) AS MaxChallengeID FROM CoachChallenges ";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxChallengeID"]);
            }
            else
            {

                return 0;
            }
        }

        public int InsertCoachChallenge(string challengename, int points, string description, string startdate, string enddate, int coachid)
        {
            int challengeid = GetMaxChallengeID() + 1;

            string query = $"INSERT INTO CoachChallenges (ChallengeID,Description,PointsRewarded,ChallengeName,StartDate,EndDate,CoachID)" +
                           $" VALUES('{challengeid}','{description}','{points}','{challengename}','{startdate}','{enddate}','{coachid}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAllCoachRequests(int ID)
        {
            string query = $"SELECT m.Username, m.Fname, m.Lname, m.Age, m.Weight, m.Height, m.Gender " +
                           $"FROM Members m INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                           $"WHERE cb.CoachID = {ID} AND cb.Accepted = 0;";
            return dbMan.ExecuteReader(query);
        }

        public int AcceptMember(string username, int coachid)
        {
            int memberid = GetMemberID(username);
            string query = $"UPDATE CoachedBy SET Accepted = 1, Ongoing = 1 WHERE MemberID = {memberid} AND CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeclineMember(string username, int coachid)
        {
            int memberid = GetMemberID(username);
            string query = $"UPDATE CoachedBy SET Accepted = 0, Ongoing = 0 WHERE MemberID = {memberid} AND CoachID = {coachid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetMaxMealID()
        {
            string query = $"SELECT MAX(MealID) AS MaxMealID FROM Meals ";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxMealID"]);
            }
            else
            {

                return 0;
            }
        }

        public DataTable GetMealTypes()
        {
            string query = $"SELECT DISTINCT MealType FROM Meals";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewMeal(int coachid, string name, string ingredients, string steps, string dateposted, string duration, string mealtype, double fats, double protein, double carbs, int calories)
        {
            int mealid = GetMaxMealID() + 1;
            string query = $"INSERT INTO Meals (MealID, Steps, Ingredients, Duration, MealType, CaloriesPerServing, MealName, Fats, Protein, Carbs, DatePosted, CoachID)" +
                           $"VALUES ('{mealid}', '{steps}', '{ingredients}', '{duration}', '{mealtype}', '{calories}', '{name}', '{fats}', '{protein}', '{carbs}', '{dateposted}', '{coachid}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetMembersandBadges(int ID)
        {
            string query = $"SELECT m.Username, m.Points, b.BadgeName FROM Members m INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID LEFT JOIN BadgesEarned be ON m.MemberID = be.MemberID AND cb.CoachID = be.CoachID LEFT JOIN Badges b ON be.BadgeID = b.BadgeID WHERE cb.CoachID = {ID} AND cb.Ongoing = 1";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllBadges()
        {
            string query = "SELECT BadgeName, PointsNeeded FROM Badges;";
            return dbMan.ExecuteReader(query);
        }

        public int GetBadgeID(string badgename)
        {
            string query = $"SELECT BadgeID FROM Badges WHERE BadgeName = '{badgename}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["BadgeID"]);
            }
            else
            {
                return 0;
            }
        }

        public bool HasMemberBeenAwardedBadge(int memberID, int badgeID)
        {
            string query = $"SELECT COUNT(*) FROM BadgesEarned WHERE MemberID = {memberID} AND BadgeID = {badgeID}";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }
            return false;
        }

        public int AwardBadge(string username, int coachid, string badgename, string date)
        {
            int memberid = GetMemberID(username);
            int badgeID = GetBadgeID(badgename);

            if (HasMemberBeenAwardedBadge(memberid, badgeID))
            {
                MessageBox.Show("Member has already been awarded this Badge");
                return 0;
            }

            string query = $"INSERT INTO BadgesEarned (MemberID, CoachID, BadgeID, DateEarned) " +
                           $"VALUES ({memberid}, {coachid}, {badgeID}, '{date}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveMember(int ID, string username)
        {
            int memberid = GetMemberID(username);
            string query = $"DELETE FROM CoachedBy WHERE MemberID = {memberid} AND CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public bool HasExerciseBeenSuggested(int memberID, int exerciseID)
        {
            string query = $"SELECT COUNT(*) FROM SuggestedExercises WHERE MemberID = {memberID} AND ExerciseID = {exerciseID}";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public bool HasCalorieBeenSuggested(int memberID, int calories)
        {
            string query = $"SELECT COUNT(*) FROM SuggestedCalories WHERE MemberID = {memberID} AND SuggestedCalroies = {calories}";
            DataTable dt = dbMan.ExecuteReader(query);
            return dt != null && dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public int GetExerciseID(string exercisename)
        {
            string query = $"SELECT ExerciseID FROM Exercises WHERE ExerciseName = '{exercisename}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["ExerciseID"]);
            }
            else
            {
                return 0;
            }
        }

        public DataTable GetExerciseNames()
        {
            string query = $"SELECT ExerciseName FROM Exercises";
            return dbMan.ExecuteReader(query);
        }

        public int InsertSuggestedCalorie(string username, int coachid, int calories, string datesuggested)
        {
            int memberid = GetMemberID(username);

            if (HasCalorieBeenSuggested(memberid, calories))
            {
                MessageBox.Show("This calorie number has already been suggested to the member.");
                return 0;
            }

            string query = $"INSERT INTO SuggestedCalories (MemberID, CoachID, SuggestedCalroies, DateSuggested) " +
                           $"VALUES ({memberid}, {coachid}, {calories}, '{datesuggested}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertSuggestedExercises(string username, int coachid, string exercisename, string dateposted)
        {
            int memberid = GetMemberID(username);
            int exerciseid = GetExerciseID(exercisename);

            if (HasExerciseBeenSuggested(memberid, exerciseid))
            {
                MessageBox.Show("This exercise has already been suggested to the member.");
                return 0;
            }

            string query = $"INSERT INTO SuggestedExercises (MemberID, CoachID, ExerciseID, DateSuggested) " +
                           $"VALUES ({memberid}, {coachid}, {exerciseid}, '{dateposted}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetFeedbackTypesS()
        {
            string query = $"SELECT TypeName FROM FeedbackTypes";
            return dbMan.ExecuteReader(query);
        }

        public int GetFeedbackID(string feedbackname)
        {
            string query = $"SELECT TypeID FROM FeedbackTypes WHERE TypeName = '{feedbackname}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["TypeID"]);
            }
            return 0;

        }

        public int GetMaxFeedbackID()
        {
            string query = $"SELECT MAX(FeedbackID) AS MaxFeedbackID FROM Feedback";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["MaxFeedbackID"]);
            }
            else
            {

                return 0;
            }
        }

        public int InsertFeedback(string comment, int rating, string typename, string dateposted)
        {
            int feedbacktypeID = GetFeedbackID(typename);
            string query = $"INSERT INTO Feedback (Comment, Rating, FeedbackTypeID, DatePosted) " +
                           $"VALUES ('{comment}', {rating}, {feedbacktypeID}, '{dateposted}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable MembersWithHighestPoints(int ID)
        {
            string query = $"SELECT TOP 5 m.Username, m.Points " +
                           $"FROM Members m " +
                           $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                           $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1 " +
                           $"ORDER BY m.Points DESC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable MostBadges(int ID)
        {
            string query = $"SELECT m.Username, COUNT(be.BadgeID) AS BadgeCount " +
                           $"FROM Members m " +
                           $"INNER JOIN CoachedBy cb ON m.MemberID = cb.MemberID " +
                           $"LEFT JOIN BadgesEarned be ON m.MemberID = be.MemberID AND cb.CoachID = be.CoachID " +
                           $"WHERE cb.CoachID = {ID} AND cb.Ongoing = 1 " +
                           $"GROUP BY m.Username " +
                           $"ORDER BY BadgeCount DESC";
            return dbMan.ExecuteReader(query);
        } ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////OMAR///////////////////////////////////////////////////////////////////////////////////////
        public int CheckIfUserExist(string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}' AND Password = '{password}';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataRow GetTypeOfUser(string username)
        {
            string query = $"Select type_of_user from Users where username = '{username}'";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public int UpdateMemberLimit(int CoachID, int memberLimit)
        {
            string query = $"UPDATE Coaches SET MemberLimit = {memberLimit} WHERE CoachID = {CoachID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveCoach(int CoachID)
        {
            string query = $"DELETE Coaches WHERE CoachID = {CoachID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int CheckifUsernameExist(string username)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{username}';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int UpdateAdminUsername(string OldUsername, string username)
        {
            string query = $"UPDATE Users SET Username = '{username}' where Username = '{OldUsername}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateAdminPasswords(string username, string password)
        {
            string query = $"UPDATE Users SET Password = '{password}' where Username = '{username}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAdminUsers()
        {
            string query = "select Username from Users where type_of_user = 'admin';";
            return dbMan.ExecuteReader(query);
        }

        public int AddNewAdmin(string username, string password)
        {
            string query = $"Insert into Users values ('{username}', '{password}', 'admin')";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataRow getCoachdetails(int ID)
        {
            string query = $"Select Username, Fname, Lname, CertificateTitle from Coaches where CoachID = {ID}";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public DataRow getAcademyDetails(int id)
        {
            string query = $"Select Username, Name, CertificateTitle from Academies where AcademyID = {id}";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        public DataTable getCoachesRankings()
        {
            string query = "SELECT Username, Fname, Lname, CoachID, (SELECT AVG(Rating) FROM CoachedBy WHERE CoachedBy.CoachID = Coaches.CoachID) AS AvgRating, (SELECT Count(*) from CoachedBy WHERE CoachedBy.CoachID = Coaches.CoachID and Ongoing = 1) as MemberCount FROM Coaches WHERE Accepted = 1 ORDER BY AvgRating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllmembersOfCoach(int ID)
        {
            string query = $"Select Username, Fname, Lname, m.MemberID FROM Members m, CoachedBy c WHERE m.MemberID = c.MemberID and CoachID = {ID} and Ongoing = 1";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetNonAcceptedCoachesData()
        {
            string query = "SELECT Fname, Lname, CoachID, Age, Gender, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody FROM Coaches WHERE Accepted = 0";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetNonAcceptedAcademies()
        {
            string query = "select Username, Name, AcademyID, Description, AreaOfExpertise, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody from Academies where Accepted = 0";
            return dbMan.ExecuteReader(query);
        }
        public int AcceptCoach(int ID)
        {
            string query = $"UPDATE Coaches SET Accepted = 1 WHERE CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AcceptAcademy(int ID)
        {
            string query = $"update Academies set Accepted = 1 where AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RejectCoach(int ID)
        {
            string query = $"DELETE Coaches WHERE CoachID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int RejectAcademy(int ID)
        {
            string query = $"DELETE Academies WHERE AcademyID = {ID}";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable GetAllCoachesData()
        {
            string query = "SELECT Fname, Lname, CoachID, MemberLimit FROM Coaches WHERE Accepted = 1";
            return dbMan.ExecuteReader(query);
        }

        public double GetAvgRating(int ID)
        {
            string query = $"SELECT AVG(Rating) as avgrating FROM CoachedBy WHERE CoachID = {ID}";
            object result = dbMan.ExecuteScalar(query);

            if (result == null || result == DBNull.Value)
                return 0;
            return Convert.ToDouble(result);
        }

        public int GetCoachedMemCount(int CoachID)
        {
            string query = $"SELECT COUNT(MemberID) FROM CoachedBy WHERE CoachID = {CoachID}";
            object result = dbMan.ExecuteScalar(query);
            if (result == null || result == DBNull.Value)
                return 0;
            return (int)result;
        }

        public DataTable GetAllFeedbacks()
        {
            string query = "Select FeedbackID, Comment, Rating, TypeName, DatePosted FROM Feedback, FeedbackTypes where FeedbackTypeID = TypeID ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetAllBadgesR()
        {
            string query = "select BadgeID, BadgeName, Description, PointsNeeded from Badges";
            return dbMan.ExecuteReader(query);
        }

        public int AddBadge(string name, string description, int points)
        {
            string query;
            if (points == 0)
                query = $"insert into Badges values ('{name}', '{description}', null)";
            else
                query = $"insert into Badges values ('{name}', '{description}', {points})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveBadge(int id)
        {
            string query = $"delete from Badges where BadgeID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getAllHabits()
        {
            string query = "select HabitID, HabitName, Description, Points from DailyHabits";
            return dbMan.ExecuteReader(query);
        }

        public int AddDailyHabit(string name, string description, int points)
        {
            string query;
            if (description == "")
                query = $"insert into DailyHabits values ('{name}', null, {points}, 3)";
            else
                query = $"insert into DailyHabits values ('{name}', '{description}', {points}, 2)";
            return dbMan.ExecuteNonQuery(query);
        }

        public int RemoveDailyHabit(int id)
        {
            string query = $"Delete from DailyHabits where HabitID = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int IsAcademyAccepted(string username)
        {
            string query = $"select count(*) from Academies where Username = '{username}' and Accepted = 1";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int IsCoachAccepted(string username)
        {
            string query = $"select count(*) from Coaches where Username = '{username}' and Accepted = 1";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int AddAcademy(string username, string name, string description, string areaofexperties, string certificatetitle, string certitficatedateofissue, string CertificateExpirationDate, string issueingbody)
        {
            string query = $"INSERT INTO Academies (Username, Name, Description, AreaOfExpertise, Accepted, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody) VALUES ('{username}', '{name}', '{description}', '{areaofexperties}', 0, '{certificatetitle}', '{certitficatedateofissue}', '{CertificateExpirationDate}', '{issueingbody}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddUser(string username, string password, string type)
        {
            string query = $"insert into Users values ('{username}', '{password}', '{type}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddMember(string username, string fname, string lname, int age, double weight, double height, char gender)
        {
            string query = $"INSERT INTO Members (Username, Fname, Lname, Age, Weight, Height, AllowedCalorieIntake, Streak, Points, Gender, FitnessGoalID, DietID) VALUES ('{username}', '{fname}', '{lname}', {age}, {weight}, {height}, null, 0, 0, '{gender}', null, null)";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddCoach(string username, string fname, string lname, int age, char gender, string CertTitle, string CertDate, string CertExp, string CertBody)
        {
            string query = $"INSERT INTO Coaches (Username, Fname, Lname, Age, Gender, MemberLimit, Accepted, CertificateTitle, CertificateDateOfIssue, CertificateExpirationDate, CertificateIssuingBody) VALUES ('{username}', '{fname}', '{lname}', {age}, '{gender}', 0, 0, '{CertTitle}', '{CertDate}', '{CertExp}', '{CertBody}')";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}