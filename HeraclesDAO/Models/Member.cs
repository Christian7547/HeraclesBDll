﻿namespace HeraclesDAO.Models
{
    public class Member : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
    }
}