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
    class NonUsersRepository
    {
        private SqlConnection connection;
        private UsersRepository otherRepository = new UsersRepository();
        public NonUsersRepository()
        {
            connection = new SqlConnection(@"Server=.;Database=academic_is;Integrated Security=true;");
        }

        public List<Group> GetAllGroups()
        {
            List<Group> groupsList = new List<Group>();
            try
            {
                string sql = "SELECT [id],[name] FROM [academic_is].[dbo].[Group]";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    groupsList.Add(new Group(id, name));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return groupsList;
        }
        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjectsList = new List<Subject>();
            try
            {
                string sql = "select id, title, description from Subject ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    subjectsList.Add(new Subject(id, title, description));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return subjectsList;
        }
        public void AddNewGroup(string name)
        {
            try
            {
                string sql = "insert into [Group](name) " +
                     "values (@name)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        public int FindSubjectsId(string title)
        {
            try
            {
                string sql = "select id from Subject where title=@title";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@title", title);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    return id;
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
            throw new Exception("Something went bad");
        }
        public int FindGroupsId(string name)
        {
            try
            {
                string sql = "select id from [Group] where name=@name";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@name", name);
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
                connection.Close();
                Debug.WriteLine(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("Something went bad with groups id");
        }
        public void AssignSubjectsToGroup(int group_id, int subject_id)
        {
            try
            {
                string sql = "insert into Subject_Group(group_id, subject_id) " +
                    "values (@group_id, @subject_id)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@group_id", group_id);
                cmd.Parameters.AddWithValue("@subject_id", subject_id);
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
        public void RemoveGroup(int IdRow)
        {
            try
            {
                UnassignSubjectsFromGroup(IdRow);
                otherRepository.UnassignStudentsFromGroupByGroupId(IdRow);
                string sql = "delete from [Group] where id=@id ";
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
        private void UnassignSubjectsFromGroup(int IdRow)
        {
            try
            {
                string sql = "delete from Subject_Group where group_id=@group_id";
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
        public string FindGroupNameById(int id)
        {

            try
            {
                string sql = "select name from [Group] where id=@id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        return name;
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
            throw new Exception("Nerasta grupė");
        }

        public List<Subject_Group> GetAllSubject_Group()
        {
            List<Subject_Group> subjectsGroupsList = new List<Subject_Group>();
            try
            {
                string sql = "select group_id, subject_id from Subject_Group ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int group_id = int.Parse(reader["group_id"].ToString());
                    int subject_id = int.Parse(reader["subject_id"].ToString());
                    subjectsGroupsList.Add(new Subject_Group(group_id, subject_id));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return subjectsGroupsList;
        }
        public void UnAssignSubjectsToGroup(int group_id, int subject_id)
        {
            try
            {
                string sql = "DELETE from Subject_Group WHERE group_id=@group_id and subject_id=@subject_id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@group_id", group_id);
                cmd.Parameters.AddWithValue("@subject_id", subject_id);
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
        public void AddNewSubject(string title, string description)
        {
            try
            {
                string sql = "insert into Subject (title, description) " +
                     "values (@title, @description)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        public void RemoveSubject(int IdRow)
        {
            try
            {
                RemoveGradesBeforeDeletingSubject(IdRow);
                WhenSubjectDeletesRemoveSubject_Group(IdRow);
                string sql = "delete from Subject where id=@id ";
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
        public void RemoveGradesBeforeDeletingSubject(int subjectid)
        {
            try
            {
                string sql = "delete from Grade where subjectid=@subjectid ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        private void WhenSubjectDeletesRemoveSubject_Group(int subject_id)
        {
            try
            {
                string sql = "DELETE from Subject_Group WHERE subject_id=@subject_id";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@subject_id", subject_id);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                connection.Close();
                throw new Exception(exc.Message);
            }
        }

        public List<Subject> GetAllAssignedSubjects()
        {
            List<Subject> subjectsList = new List<Subject>();
            try
            {
                string sql = "select id, title, description from Subject where professorid is not null";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    subjectsList.Add(new Subject(id, title, description));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return subjectsList;
        }
        public List<Subject> GetAllUnassignedSubjects()
        {
            List<Subject> subjectsList = new List<Subject>();
            try
            {
                string sql = "select id, title, description from Subject where professorid is null";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string title = reader["title"].ToString();
                    string description = reader["description"].ToString();
                    subjectsList.Add(new Subject(id, title, description));
                }

                connection.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return subjectsList;
        }

        public void AssignSubjectsToProfessor(string title, int professorid)
        {
            try
            {
                string sql = "UPDATE Subject SET professorid=@professorid WHERE title=@title";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@professorid", professorid);
                cmd.Parameters.AddWithValue("@title", title);
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
        public void UnassignSubjectsToProfessor(string title)
        {
            try
            {
                string sql = "UPDATE Subject SET professorid=null WHERE title=@title";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@title", title);
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
        public int FindSubjectProfessorId(string title)
        {
            try
            {
                string sql = "select professorid from Subject where title=@title";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@title", title);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int professorid = int.Parse(reader["professorid"].ToString());
                        return professorid;
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
            throw new Exception("kazkasnoGood");

        }
        public void AddNewGrade(int grade, int studentid, int subjectid)
        {
            try
            {
                string sql = "insert into Grade(grade, date, studentid, subjectid) " +
                     "values (@grade, @date, @studentid, @subjectid)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@studentid", studentid);
                cmd.Parameters.AddWithValue("@subjectid", subjectid);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        public List<Grade> GetAllGrades()
        {
            List<Grade> gradesList = new List<Grade>();
            try
            {
                string sql = "select id, grade, date, studentid, subjectid from Grade ";
                SqlCommand cmd = new SqlCommand(sql, connection);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int grade = int.Parse(reader["grade"].ToString());
                    DateTime date = DateTime.Parse(reader["date"].ToString());
                    int studentid = int.Parse(reader["studentid"].ToString());
                    int subjectid = int.Parse(reader["subjectid"].ToString());
                    gradesList.Add(new Grade(id, grade, date, studentid, subjectid));
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

            return gradesList;
        }
        public int GetStudentsGroup(string name, string surname)
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

                Debug.WriteLine(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            throw new Exception("kazkasnoGood");
        }
    }
}
