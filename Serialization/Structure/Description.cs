﻿using System;
using System.Collections.Generic;

namespace Serialization.Structure
{
    [Serializable]
    public class Description : IDescription
    {
        public string Name { get; set; }
        public string Value { get; set; }


        public virtual List<Description> GetDescription()
        {
            var descriptionList = new List<Description> {this};

            return descriptionList;
        }
    }
}
