﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebCoreDbMananger;

namespace WebCoreDbMananger.Migrations
{
    [DbContext(typeof(RyanContext))]
    [Migration("20161122095648_addcountry")]
    partial class addcountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiCore.DomainModel.WebApiCore.BallEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ball");
                });
        }
    }
}
