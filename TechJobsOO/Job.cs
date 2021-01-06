﻿using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency ) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override string ToString()
        {
            string output = $"ID:{Id} \n Name:{Name} \n Employer:{EmployerName.Value} \n Location:{EmployerLocation.Value} \n Position Type:{JobType.Value} \n Core Competency:{JobCoreCompetency.Value}";
            return output;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        // TODO: Generate Equals() and GetHashCode() methods.*********DONE*********
    }
}
