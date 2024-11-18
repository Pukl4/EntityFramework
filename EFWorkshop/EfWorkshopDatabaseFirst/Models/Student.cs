﻿using System;
using System.Collections.Generic;

namespace EfWorkshopDatabaseFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public decimal? AverageGrade { get; set; }

    public int? FacultyId { get; set; }
}
