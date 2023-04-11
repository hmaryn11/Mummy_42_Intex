using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mummy_42_Intex.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mummy_42_Intex.Data
{
    //THIS IS A TEMPORARY FILE TO USE DUMMY DATA!!!
    public class ArtifactContext : DbContext
    {
        public ArtifactContext()
        {

        }
        public ArtifactContext(DbContextOptions<ArtifactContext> options) : base(options)
        {

        }

        public DbSet<Artifacts> Artifacts { get; set; }
        protected override void OnModelCreating(ModelBuilder mb) //seeding the db
        {
            mb.Entity<Artifacts>().HasData(
                new Artifacts
                {
                    ArtifactId = 1,
                    Description = "Big and scary",
                    Date = "2022-01-13",
                    Material = "Spikes",
                    Dimensions = "6 ft",
                    CurrentLocation = "Rio",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 2,
                    Description = "Small and fluffy",
                    Date = "2022-04-30",
                    Material = "Cotton",
                    Dimensions = "8 in",
                    CurrentLocation = "Spain",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 3,
                    Description = "Big and scary",
                    Date = "2022-01-13",
                    Material = "Spikes",
                    Dimensions = "6 ft",
                    CurrentLocation = "Rio",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 4,
                    Description = "Small and fluffy",
                    Date = "2022-04-30",
                    Material = "Cotton",
                    Dimensions = "8 in",
                    CurrentLocation = "Spain",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 5,
                    Description = "Big and scary",
                    Date = "2022-01-13",
                    Material = "Spikes",
                    Dimensions = "6 ft",
                    CurrentLocation = "Rio",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 6,
                    Description = "Small and fluffy",
                    Date = "2022-04-30",
                    Material = "Cotton",
                    Dimensions = "8 in",
                    CurrentLocation = "Spain",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 7,
                    Description = "Big and scary",
                    Date = "2022-01-13",
                    Material = "Spikes",
                    Dimensions = "6 ft",
                    CurrentLocation = "Rio",
                    StorageLocation = "Chicago"
                },
                new Artifacts
                {
                    ArtifactId = 8,
                    Description = "Small and fluffy",
                    Date = "2022-04-30",
                    Material = "Cotton",
                    Dimensions = "8 in",
                    CurrentLocation = "Spain",
                    StorageLocation = "Chicago"
                });
        }
    }
}

//ArtifactId
//Description
//Date
//Material
//Dimensions
//CurrentLocation
//StorageLocation

