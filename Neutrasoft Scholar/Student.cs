﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neutrasoft_Scholar
{
    //Class to store all information for one student
    public class Student
    {
        public int StudentID { get; }
        public string Username { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string FullName { get; }
        public string FullNameWithoutMiddleName { get; }
        public string Gender { get; }

        public Student(string username)
        {
            Username = username;
            string query = "SELECT StudentID,FirstName,MiddleName,LastName,Gender " +
                "FROM Students " +
                "WHERE Username='" + Username + "'";
            Dictionary<string, List<string>> output = null;  

            try
            {
                output = SQLDatabase.ReadFromSQLServer(query, new List<string> { "StudentID", "FirstName", "MiddleName", "LastName", "Gender" });
                StudentID = int.Parse(output["StudentID"][0]);
                FirstName = output["FirstName"][0];
                MiddleName = output["MiddleName"][0];
                LastName = output["LastName"][0];
                Gender = output["Gender"][0];
                FullName = String.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
                FullNameWithoutMiddleName = String.Format("{0} {1}", FirstName, LastName);
            }
            catch (SQLDatabase.InvalidColumnException e)
            {
               DialogResult result =  MessageBox.Show("You submitted an invalid query or invalid columns in you SQL Server database request. Please report this bug to your administrators. The application will now close. \nDetails: " + e.Message + "\n" + e.StackTrace);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("An error has occured, please restart the program and try again. Please report this bug to your administrators. The application will now close. \nDetails: " + e.Message + "\n" + e.StackTrace);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

        }
    }
}