using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akademinė_sistema;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Diagnostics;

namespace Akademinė_sistema
{
    class UsersRepository
    {
        private SqlConnection connection;

        public UsersRepository()
        {
            connection = new SqlConnection(@"Server=.;Database=academic_is;Integrated Security=true;");
        }

        public Student StudentLogin(string username, string password)
        {
            try
            {
                string sql = "select id, name, surname, birthdate, username from Student " +
                        "where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        DateTime date = DateTime.Parse(reader["birthdate"].ToString());
                        string usrname = reader["username"].ToString();
                        connection.Close();
                        return new Student(id, name, surname, date, usrname, "");
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return null;
        }
        public Professor ProfessorLogin(string username, string password)
        {
            try
            {
                string sql = "select id, degree, name, surname, birthdate, username from Professor " +
                        "where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string degree = reader["degree"].ToString();
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        DateTime date = DateTime.Parse(reader["birthdate"].ToString());
                        string usrname = reader["username"].ToString();
                        connection.Close();
                        return new Professor(id, degree, name, surname, date, usrname, "");
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return null;
        }
        public Admin AdminLogin(string username, string password)
        {
            try
            {
                string sql = "select id, name, surname, birthdate, username from Admin " +
                        "where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                connection.Open();



                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        string name = reader["name"].ToString();
                        string surname = reader["surname"].ToString();
                        DateTime date = DateTime.Parse(reader["birthdate"].ToString());
                        string usrname = reader["username"].ToString();
                        connection.Close();
                        return new Admin(id, name, surname, date, usrname, "");
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return null;
        }
         public void AddNewStudent(Student student)
         {
             try
             {
                 string sql = "insert into Student(name, surname, birthdate, username, password) " +
                     "values (@name, @surname, @birthdate, @username, @password)";
                 SqlCommand cmd = new SqlCommand(sql, connection);
                 cmd.Parameters.AddWithValue("@name", student.Name);
                 cmd.Parameters.AddWithValue("@surname", student.Surname);
                 cmd.Parameters.AddWithValue("@birthdate", student.BirthDate);
                 cmd.Parameters.AddWithValue("@username", student.Username);
                 cmd.Parameters.AddWithValue("@password", student.Password);
                 connection.Open();
                 cmd.ExecuteNonQuery();
                 connection.Close();
             }
             catch (Exception exc)
             {
                 throw new Exception(exc.Message);
             }
         }
        public void AddNewProfessor(Professor professor)
        {
            try
            {
                string sql = "insert into Professor(name, degree, surname, birthdate, username, password) " +
                    "values (@name, @degree, @surname, @birthdate, @username, @password)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@degree", professor.degree);
                cmd.Parameters.AddWithValue("@name", professor.Name);
                cmd.Parameters.AddWithValue("@surname", professor.Surname);
                cmd.Parameters.AddWithValue("@birthdate", professor.BirthDate);
                cmd.Parameters.AddWithValue("@username", professor.Username);
                cmd.Parameters.AddWithValue("@password", professor.Password);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                string sql = "select id, name, surname, birthdate, username, password from Student ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["birthdate"].ToString());
                    string username = reader["username"].ToString();
                    studentsList.Add(new Student(id, name, surname, birthdate, username, ""));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return studentsList;
        }

        public List<Student> GetAllUnassignedStudents()
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                string sql = "select id, name, surname, birthdate, username, password from Student where group_id is null";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["birthdate"].ToString());
                    string username = reader["username"].ToString();
                    studentsList.Add(new Student(id, name, surname, birthdate, username, ""));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return studentsList;
        }

        public List<Student> GetAllAssignedStudents()
        {
            List<Student> studentsList = new List<Student>();
            try
            {
                string sql = "select id, name, surname, birthdate, username, password from Student where group_id is not null";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["birthdate"].ToString());
                    string username = reader["username"].ToString();
                    studentsList.Add(new Student(id, name, surname, birthdate, username, ""));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return studentsList;
        }

        public List<Professor> GetAllProfessors()
        {
            List<Professor> professorsList = new List<Professor>();
            try
            {
                string sql = "select id, degree, name, surname, birthdate, username, password from Professor ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id= int.Parse(reader["id"].ToString());
                    string degree = reader["degree"].ToString();
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    DateTime birthdate = DateTime.Parse(reader["birthdate"].ToString());
                    string username = reader["username"].ToString();
                    professorsList.Add(new Professor(id, degree, name, surname, birthdate, username, ""));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return professorsList;
        }
        public string FirstLetterToLowerCase(string s)
        {
            if (s.Trim(' ').Equals(""))
                throw new Exception("Laukai negali likti tušti");
            char[] a = s.ToCharArray();
            a[0] = char.ToLower(a[0]);
            return new string(a);
        }
        public void RemoveStudent(int IdRow)
        {
            try
            {
                RemovePreviousGrade(IdRow);
                string sql = "delete from Student where id=@id ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", IdRow);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        public void RemovePreviousGrade(int studentid)
        {
            try
            {
                string sql = "delete from Grade where studentid=@studentid ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@studentid", studentid);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void RemoveProfessor(int IdRow)
        {
            try
            {
                RemoveSubjectRelationWithProfessor(IdRow);
                string sql = "delete from Professor where id=@id ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", IdRow);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        private void RemoveSubjectRelationWithProfessor(int professorid)
        {
            try
            {
                string sql = "UPDATE Subject SET professorid=null WHERE professorid=@professorid";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@professorid", professorid);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();
                throw new Exception(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public int FindStudentsId(string name, string surname)
        {
            try
            {
                string sql = "select id from Student where name=@name and surname=@surname";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        return id;
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
               
                Debug.WriteLine(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("Jūs turite pasirinkti iš galimų variantų");

        }
        public void AssignStudentsToGroup(int group_id, int student_id)
        {
            try
            {
                string sql = "UPDATE Student SET group_id=@group_id WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", student_id);
                cmd.Parameters.AddWithValue("@group_id", group_id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();
                throw new Exception(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UnassignStudentsFromGroupByGroupId(int IdRow)
        {
            try
            {
                string sql = "UPDATE Student SET group_id=null WHERE group_id=@group_id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@group_id", IdRow);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void UnassignStudentsFromGroupByStudentId(int IdRow)
        {
            try
            {
                string sql = "UPDATE Student SET group_id=null WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", IdRow);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        public int FindProfessorId(string name, string surname)
        {
            try
            {
                string sql = "select id from Professor where name=@name and surname=@surname";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["id"].ToString());
                        return id;
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {

                Debug.WriteLine(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("Jūs turite pasirinkti iš galimų variantų");

        }
        public int FindStudentsGroupId(string name, string surname)
        {
            try
            {
                string sql = "select group_id from Student where name=@name and surname=@surname";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int group_id = int.Parse(reader["group_id"].ToString());
                        return group_id;
                    }
                }
                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();
                Debug.WriteLine(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("Something went wrong");

        }
    }
}


