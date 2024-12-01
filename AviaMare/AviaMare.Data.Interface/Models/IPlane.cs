﻿using Enums.Users;

namespace AviaMare.Data.Interface.Models
{
    public interface IPlane : IBaseModel
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public int BaseSpeed { get; set; }
        public int Seats { get; set; }
    }
}