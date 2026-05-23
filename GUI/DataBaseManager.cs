using System;
using System.Data;
using System.Data.SqlClient;

namespace BoutiqueHospitalityApp
{
    public class DatabaseManager
    {
        private string connectionString = @"Server=localhost;Database=The Boutique Hospitality;Integrated Security=True;";

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetAll(string tableName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // ==============================
        // HOTEL CRUD
        // ==============================
        public void InsertHotel(int id, string name, string loc, string theme)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO HOTEL (HOTEL_ID, HOTEL_NAME, LOCATION, THEME) VALUES (@id, @name, @loc, @theme)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@loc", loc);
                    cmd.Parameters.AddWithValue("@theme", theme);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateHotel(int id, string name, string loc, string theme)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE HOTEL SET HOTEL_NAME=@name, LOCATION=@loc, THEME=@theme WHERE HOTEL_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@loc", loc);
                    cmd.Parameters.AddWithValue("@theme", theme);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // CONCIERGE CRUD
        // ==============================
        public void InsertConcierge(int id, string name, string skills)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO CONCIERGE (CONCIERGE_ID, CONCIERGE_NAME, SPECIALIZED_SKILLS) VALUES (@id, @name, @skills)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@skills", skills);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateConcierge(int id, string name, string skills)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE CONCIERGE SET CONCIERGE_NAME=@name, SPECIALIZED_SKILLS=@skills WHERE CONCIERGE_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@skills", skills);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // EXPERIENCE CRUD
        // ==============================
        public void InsertExperience(int id, int conciergeId, string name, string description)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO EXPERIENCE (EXPERIENCE_ID, CONCIERGE_ID, EXPERIENCE_NAME, DESCRIPTION) VALUES (@id, @conciergeId, @name, @description)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@conciergeId", conciergeId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateExperience(int id, int conciergeId, string name, string description)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE EXPERIENCE SET CONCIERGE_ID=@conciergeId, EXPERIENCE_NAME=@name, DESCRIPTION=@description WHERE EXPERIENCE_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@conciergeId", conciergeId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // GUEST CRUD
        // ==============================
        public void InsertGuest(int id, string name, string email, string phone, DateTime regDate, string billAdd)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO GUEST (GUEST_ID, GUEST_NAME, EMAIL, PHONE, REGISTRATION_DATE, BILLING_ADDRESS) VALUES (@id, @name, @email, @phone, @regDate, @billAdd)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@regDate", regDate);
                    cmd.Parameters.AddWithValue("@billAdd", billAdd);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateGuest(int id, string name, string email, string phone, DateTime regDate, string billAdd)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE GUEST SET GUEST_NAME=@name, EMAIL=@email, PHONE=@phone, REGISTRATION_DATE=@regDate, BILLING_ADDRESS=@billAdd WHERE GUEST_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@regDate", regDate);
                    cmd.Parameters.AddWithValue("@billAdd", billAdd);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // SUITE CRUD
        // ==============================
        public void InsertSuite(int id, int hotelId, int suiteNumber, string type, decimal price, string amenities)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO SUITE (SUITE_ID, HOTEL_ID, SUITE_NUMBER, SUITE_CLASS, PRICE_PER_NIGHT, AMENITIES) VALUES (@id, @hotelId, @suiteNumber, @type, @price, @amenities)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@hotelId", hotelId);
                    cmd.Parameters.AddWithValue("@suiteNumber", suiteNumber);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@amenities", amenities);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSuite(int id, int hotelId, int suiteNumber, string type, decimal price, string amenities)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE SUITE SET HOTEL_ID=@hotelId, SUITE_NUMBER=@suiteNumber, SUITE_CLASS=@type, PRICE_PER_NIGHT=@price, AMENITIES=@amenities WHERE SUITE_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@hotelId", hotelId);
                    cmd.Parameters.AddWithValue("@suiteNumber", suiteNumber);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@amenities", amenities);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // RESERVATION CRUD
        // ==============================
        public void InsertReservation(int id, int guestId, int suiteId, DateTime checkIn, DateTime checkOut, decimal total, string status)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO RESERVATION (RESERVATION_ID, GUEST_ID, SUITE_ID, START_DATE, END_DATE, TOTAL_PRICE, RESERVATION_STATUS) VALUES (@id, @guestId, @suiteId, @checkIn, @checkOut, @total, @status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@guestId", guestId);
                    cmd.Parameters.AddWithValue("@suiteId", suiteId);
                    cmd.Parameters.AddWithValue("@checkIn", checkIn);
                    cmd.Parameters.AddWithValue("@checkOut", checkOut);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateReservation(int id, int guestId, int suiteId, DateTime checkIn, DateTime checkOut, decimal total, string status)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE RESERVATION SET GUEST_ID=@guestId, SUITE_ID=@suiteId, START_DATE=@checkIn, END_DATE=@checkOut, TOTAL_PRICE=@total, RESERVATION_STATUS=@status WHERE RESERVATION_ID=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@guestId", guestId);
                    cmd.Parameters.AddWithValue("@suiteId", suiteId);
                    cmd.Parameters.AddWithValue("@checkIn", checkIn);
                    cmd.Parameters.AddWithValue("@checkOut", checkOut);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // RESERVATION_EXPERIENCE CRUD
        // ==============================
        public void InsertReservationExperience(int resExpId, int resId, int expId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO RESERVATION_EXPERIENCE (RES_EXP_ID, RESERVATION_ID, EXPERIENCE_ID) VALUES (@resExpId, @resId, @expId)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@resExpId", resExpId);
                    cmd.Parameters.AddWithValue("@resId", resId);
                    cmd.Parameters.AddWithValue("@expId", expId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateReservationExperience(int oldResExpId, int newResId, int newExpId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "UPDATE RESERVATION_EXPERIENCE SET RESERVATION_ID=@newResId, EXPERIENCE_ID=@newExpId WHERE RES_EXP_ID=@oldResExpId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newResId", newResId);
                    cmd.Parameters.AddWithValue("@newExpId", newExpId);
                    cmd.Parameters.AddWithValue("@oldResExpId", oldResExpId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // GENERIC DELETE FOR ALL TABLES
        // ==============================
        public void DeleteRecord(string tableName, string pkColumn, int pkValue)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = $"DELETE FROM {tableName} WHERE {pkColumn} = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pkValue);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCompositeRecord(string tableName, string pkCol1, int pkVal1, string pkCol2, int pkVal2)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = $"DELETE FROM {tableName} WHERE {pkCol1} = @id1 AND {pkCol2} = @id2";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id1", pkVal1);
                    cmd.Parameters.AddWithValue("@id2", pkVal2);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ==============================
        // JOIN QUERIES
        // ==============================
        public DataTable GetJoinReservationGuestSuite()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT r.RESERVATION_ID, g.GUEST_NAME, 
                           s.SUITE_NUMBER, r.START_DATE, r.END_DATE, r.TOTAL_PRICE, r.RESERVATION_STATUS
                    FROM RESERVATION r
                    INNER JOIN GUEST g ON r.GUEST_ID = g.GUEST_ID
                    INNER JOIN SUITE s ON r.SUITE_ID = s.SUITE_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetJoinExperienceConcierge()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT e.EXPERIENCE_ID, e.EXPERIENCE_NAME, 
                           c.CONCIERGE_NAME
                    FROM EXPERIENCE e
                    INNER JOIN CONCIERGE c ON e.CONCIERGE_ID = c.CONCIERGE_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable GetJoinReservationExperiences()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                string query = @"
                    SELECT re.RESERVATION_ID, g.GUEST_NAME, 
                           e.EXPERIENCE_NAME
                    FROM RESERVATION_EXPERIENCE re
                    INNER JOIN RESERVATION r ON re.RESERVATION_ID = r.RESERVATION_ID
                    INNER JOIN GUEST g ON r.GUEST_ID = g.GUEST_ID
                    INNER JOIN EXPERIENCE e ON re.EXPERIENCE_ID = e.EXPERIENCE_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}