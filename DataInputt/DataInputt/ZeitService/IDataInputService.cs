﻿using System;
using System.Collections.Generic;

namespace DataInputt.ZeitService
{
    public interface IDataInputService
    {
        int CreateUser(User user);

        int Login(User user);

        List<Time> GetTimes(int userId);

        void AddTime(Time time, int userId);

        List<string> Projects();
    }

    public class DataInputService : IDataInputService
    {
        public void AddTime(Time time, int userId)
        {
            
        }

        public int CreateUser(User user)
        {
            return 0;
        }

        public List<Time> GetTimes(int userId)
        {
            return new List<Time>();
        }

        public int Login(User user)
        {
            return 0;
        }

        public List<string> Projects()
        {
            return new List<string>();
        }
    }

    public interface IDataCallback
    {
        void EarningsCalculated(IDictionary<int, decimal> earnings);
    }

    public class User
    {
        public string Name { get; set; }
        public string Passwort { get; set; }
    }

    public class Time
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Project { get; set; }
        public int uId { get; set; }
        public int Id { get; set; }
    }
}