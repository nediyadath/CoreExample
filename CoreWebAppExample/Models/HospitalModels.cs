using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAppExample.Models
{
    public class Hospital
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public bool check { get; set; }
    }

    public class Doctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string speciality { get; set; }
    }

    public class Patient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Allergies { get; set; }
    }

    public class Appointment
    {
        public int id { get; set; }
        [ForeignKey("doctor")]
        public int docID { get; set; }
        public Doctor doctor { get; set; }
        [ForeignKey("patient")]
        public int ptID { get; set; }
        public Patient patient { get; set; }
        public DateTime date { get; set; }

    }

    public class Schedule
    {
        public int id { get; set; }
        [ForeignKey("doc")]
        public int docID { get; set; }
        public Doctor doc { get; set; }
        public string schedule { get; set; }
    }

    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
           : base(options)
        {
        }
        public DbSet<Hospital> hospital { get; set; }
        public DbSet<Patient> patient { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Appointment> appointment { get; set; }
        public DbSet<Schedule> schedule { get; set; }
    }
}
