﻿using Explorer.BuildingBlocks.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Core.Domain
{
    public class TourReview : Entity
    {
        public int Grade { get; init; }
        public string Comment { get; init; }
        public int TouristId { get; init; }
        public DateTime AttendanceDate { get; init; }
        public DateTime ReviewDate { get; init; }
        public List<string> Images { get; init; }

        public int TourId { get; init; }

        public TourReview( int grade, string comment, int touristId, DateTime attendanceDate, DateTime reviewDate, List<string> images, int tourId)
        {
            Grade = grade;
            Comment = comment;
            TouristId = touristId;
            AttendanceDate = attendanceDate;
            ReviewDate = reviewDate;
            Images = images;
            TourId = tourId;
        }
    }
}
