﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSYS
{
    class RentalItem
    {
        private int RentalId;
        private int MovieId;
        private String Category;
        private String ReturnedDate;
        private int ReturnedByMemId;
        private Decimal Fine;

        //Constructor
        public RentalItem()
        {
            RentalId = 0;
            MovieId = 0;
            Category = "";
            ReturnedDate = "";
            ReturnedByMemId = 0;
            Fine = 0;
        }

        public RentalItem(int RentalId, int MovieId, String Category, String ReturnedDate, int ReturnedByMemId, Decimal Fine)
        {
            this.RentalId = RentalId;
            this.MovieId = MovieId;
            this.Category = Category;
            this.ReturnedDate = ReturnedDate;
            this.ReturnedByMemId = ReturnedByMemId;
            this.Fine = Fine;
        }

        public int getRentalId()
        {
            return this.RentalId;
        }

        public int getMovieId()
        {
            return this.MovieId;
        }

        public String getCategory()
        {
            return this.Category;
        }

        public String getReturnedDate()
        {
            return this.ReturnedDate;
        }

        public int getReturnedByMemId()
        {
            return this.ReturnedByMemId;
        }

        public Decimal getFine()
        {
            return this.Fine;
        }

        public void setRentalId(int RentalId)
        {
            this.RentalId = RentalId;
        }

        public void setMovieId(int MovieId)
        {
            this.MovieId = MovieId;
        }

        public void setCategory(String Category)
        {
            this.Category = Category;
        }

        public void setReturnedDate(String ReturnedDate)
        {
            this.ReturnedDate = ReturnedDate;
        }

        public void setReturnedByMemId(int ReturnedByMemId)
        {
            this.ReturnedByMemId = ReturnedByMemId;
        }

        public void setFine(Decimal Fine)
        {
            this.Fine = Fine;
        }

        public void rentedMovie()
        {
            //define Sql Query
            String strSQL = "INSERT INTO RentalItems (RentalId, MovieId, Category, Fine) VALUES (" + this.RentalId + "," +
            this.MovieId + ",'" + this.Category + "'," + this.Fine + ")";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void returnedMovie()
        {
            //define Sql Query
            String strSQL = "UPDATE RentalItems SET ReturnedDate = '" + this.ReturnedDate + "', ReturnedByMemId = " + this.ReturnedByMemId +
            " WHERE MovieId LIKE '" + this.MovieId + "'";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Query Rented Movies based on Rental ID (e.g. WHERE RI.RentalId LIKE '%<rentalId>%')
        public static DataSet getMembersRentalItems(String rentalIdSearch, String memberIdSearch)
        {
            //define Sql Query
            String strSQL = "SELECT RI.RentalId, RT.MemberId, RI.MovieId, M.Title, RI.Category, M.Status " +
                "FROM RentalItems RI JOIN Rentals RT ON RI.RentalId = RT.RentalId JOIN Movies M ON M.MovieId = RI.MovieId " +
                "WHERE RI.RentalId LIKE '%" + rentalIdSearch + "%' AND M.Status LIKE 'U' AND RT.MemberId LIKE '%" +
                memberIdSearch + "%'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "RTD");

            //Close database connection
            conn.Close();

            return ds;
        }

    }
}
