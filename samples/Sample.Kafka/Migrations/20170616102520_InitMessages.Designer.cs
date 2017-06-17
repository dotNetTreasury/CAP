﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Sample.Kafka;
using Cap.Consistency.Infrastructure;

namespace Sample.Kafka.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170616102520_InitMessages")]
    partial class InitMessages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cap.Consistency.Infrastructure.ConsistencyMessage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Payload");

                    b.Property<DateTime>("SendTime");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
        }
    }
}
