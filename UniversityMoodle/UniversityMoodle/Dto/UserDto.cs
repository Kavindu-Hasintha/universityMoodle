﻿using UniversityMoodle.Models;

namespace UniversityMoodle.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DoB { get; set; }
    }
}
